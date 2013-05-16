using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void CellEndEdit(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv.ColumnCount; ++i)
            {
                if (dgv[i, e.RowIndex].Value == null || dgv[i, e.RowIndex].Value.ToString().Length < 1)
                    return;
            }
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

        private void UserDeletedRow(DataGridView dgv, DataGridViewRowEventArgs e)
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

        private void AssyPartView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CellEndEdit((DataGridView)sender, e);
            /*DataGridView dgv = (DataGridView)sender;
            for (int i = 0; i < dgv.ColumnCount; ++i)
            {
                if (dgv[i, e.RowIndex].Value == null || dgv[i, e.RowIndex].Value.ToString().Length < 1)
                    return;
            }
            partAssyBindingSource.EndEdit();
            assyPartDS.GetChanges();
            part_AssyTableAdapter.Update(assyPartDS);
            assyPartDS.AcceptChanges();
                */
            
        }
        

        private void AssyPartView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UserDeletedRow((DataGridView)sender, e);
        }

        
       

        private void PartView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (PartView[0, e.RowIndex].Value != null && PartView[1, e.RowIndex].Value != null
              && PartView[0, e.RowIndex].Value.ToString().Length > 0 && PartView[1, e.RowIndex].Value.ToString().Length > 0)
            {
                partBindingSource.EndEdit();
                assyPartDS.GetChanges();
                partTableAdapter.Update(assyPartDS);
                assyPartDS.AcceptChanges();
            }


        }

        private void PartView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {

                partBindingSource.EndEdit();
                assyPartDS.GetChanges();
                partTableAdapter.Update(assyPartDS);
                assyPartDS.AcceptChanges();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
                assyPartDS.RejectChanges();
            }
        }

        

        private void ClientView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            for (int i = 0; i < dgv.ColumnCount; ++i)
            {
                if (dgv[i, e.RowIndex].Value == null || dgv[i, e.RowIndex].Value.ToString().Length < 1)
                    return;
            }
            clientBindingSource.EndEdit();
            assyPartDS.GetChanges();
            clientTableAdapter.Update(assyPartDS);
            assyPartDS.AcceptChanges();
            
        }

        private void ClientView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                clientBindingSource.EndEdit();
                assyPartDS.GetChanges();
                clientTableAdapter.Update(assyPartDS);
                
                assyPartDS.AcceptChanges();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
                assyPartDS.RejectChanges();
                
            }
        }

        private void OrderView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            for (int i = 0; i < dgv.ColumnCount; ++i)
            {
                if (dgv[i, e.RowIndex].Value == null || dgv[i, e.RowIndex].Value.ToString().Length < 1)
                    return;
            }
            orderBindingSource.EndEdit();
            assyPartDS.GetChanges();
            orderTableAdapter.Update(assyPartDS);
            assyPartDS.AcceptChanges();
        }

        private void OrderView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                orderBindingSource.EndEdit();
                assyPartDS.GetChanges();
                orderTableAdapter.Update(assyPartDS);
                assyPartDS.AcceptChanges();
                //var t =((DataSet)OrderView.DataSource).Tables[0];
                //AssyPartDSTableAdapters.TableAdapterManager q = new AssyPartDSTableAdapters.TableAdapterManager();
                //q.UpdateAll

            }
            catch (SqlException exc)
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

                //TODO add testing of input data

                DataClasses1DataContext dc = new DataClasses1DataContext();
                dc.CalcMRP(1, endDay, minStock, day, maxStock);
                this.purchaseTableAdapter.Fill(this.assyPartDS.Purchase);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        


       

       
    }
}
