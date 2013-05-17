using System;
using System.Windows.Forms;

namespace MRP
{
    public partial class Form1 : Form
    {
        private AssyPartDSTableAdapters.TableAdapterManager TAM = new AssyPartDSTableAdapters.TableAdapterManager();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // table adapter manager initialization
            TAM.AssyTableAdapter = assyTableAdapter;
            TAM.ClientTableAdapter = clientTableAdapter;
            TAM.OrderTableAdapter = orderTableAdapter;
            TAM.Part_AssyTableAdapter = part_AssyTableAdapter;
            TAM.PartTableAdapter = partTableAdapter;
            TAM.PurchaseTableAdapter = purchaseTableAdapter;
            
            //fill datagrids
            this.purchaseTableAdapter.Fill(this.assyPartDS.Purchase);
            this.orderTableAdapter.Fill(this.assyPartDS.Order);
            this.clientTableAdapter.Fill(this.assyPartDS.Client);
            this.assyTableAdapter.Fill(this.assyPartDS.Assy);
            this.partTableAdapter.Fill(this.assyPartDS.Part);
            this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);  
        }

        private void CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            for (int i = 0; i < dgv.ColumnCount; ++i)
            {
                if (dgv[i, e.RowIndex].Value == null || dgv[i, e.RowIndex].Value.ToString().Length < 1)
                    return;
            }
            SyncToDB(dgv);
        }

        private void UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            SyncToDB(dgv);
        }

        private void SyncToDB(DataGridView dgv)
        {
            try
            {
                ((BindingSource)dgv.DataSource).EndEdit();
                assyPartDS.GetChanges();
                TAM.UpdateAll(assyPartDS);
                assyPartDS.AcceptChanges();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                assyPartDS.RejectChanges();
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get input data from text boxes
                int minStock = Convert.ToInt32(minStockBox.Text);
                int maxStock = Convert.ToInt32(maxStockBox.Text);
                int day = Convert.ToInt32(daysBox.Text);
                int endDay = Convert.ToInt32(endDayBox.Text);

                //testing of input data
                if (minStock < 0 || maxStock < 0 || endDay < 1 || day < 1 || maxStock <= minStock)
                    throw new Exception("Invalid data");

                //Calc Purchase table and parse function return
                DataClasses1DataContext dc = new DataClasses1DataContext();
                switch (dc.CalcMRP(1, endDay, minStock, day, maxStock))
                {
                    case 1:
                        throw new Exception("StOck overflow");
                    case 2:
                        throw new Exception("Very little stock");
                }
                this.purchaseTableAdapter.Fill(this.assyPartDS.Purchase);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }  
    }
}
