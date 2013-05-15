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
        public Form1()
        {
            InitializeComponent();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.assyPartDS.Purchase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.assyPartDS.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.assyPartDS.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.assyPartDS1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Assy". При необходимости она может быть перемещена или удалена.
            this.assyTableAdapter.Fill(this.assyPartDS.Assy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part". При необходимости она может быть перемещена или удалена.
            this.partTableAdapter.Fill(this.assyPartDS.Part);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part_Assy". При необходимости она может быть перемещена или удалена.
            this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part". При необходимости она может быть перемещена или удалена.
            this.partTableAdapter.Fill(this.assyPartDS.Part);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Assy". При необходимости она может быть перемещена или удалена.
            this.assyTableAdapter.Fill(this.assyPartDS.Assy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part_Assy". При необходимости она может быть перемещена или удалена.
            this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS1.Part". При необходимости она может быть перемещена или удалена.
            //this.partTableAdapter.Fill(this.assyPartDS.Part);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part_Assy". При необходимости она может быть перемещена или удалена.
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Assy". При необходимости она может быть перемещена или удалена.
            //this.assyTableAdapter.Fill(this.assyPartDS.Assy);
            //this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
            
            
        }

       

        private void AssyPartView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1[0,0].Value.ToString());
            //MessageBox.Show(assyTableAdapter1.GetIDByName2(dataGridView1[0, e.RowIndex].Value.ToString()).ToString());
            if (AssyPartView[0, e.RowIndex].Value != null && AssyPartView[1, e.RowIndex].Value != null && AssyPartView[2, e.RowIndex].Value != null
                && AssyPartView[0, e.RowIndex].Value.ToString().Length > 0 && AssyPartView[1, e.RowIndex].Value.ToString().Length > 0 && AssyPartView[2, e.RowIndex].Value.ToString().Length > 0)
            {
                PartAssyUpdateDelegate UpdateFunc = null;
                switch (e.ColumnIndex) 
                {
                    case 0:
                        UpdateFunc = new PartAssyUpdateDelegate(part_AssyTableAdapter.UpdateAssy);
                        break;
                    case 1:
                        UpdateFunc = new PartAssyUpdateDelegate(part_AssyTableAdapter.UpdatePart);
                        break;
                    case 2:
                        UpdateFunc = new PartAssyUpdateDelegate(part_AssyTableAdapter.UpdateQty);
                        break;
                    default:
                        Debug.WriteLine("Part Assy table column index out of range");
                        break;

                }
            
                    //TODO: add SqlException handling
                try
                {
                    
                    if (newRow)
                    {
                        int rowsInserted = part_AssyTableAdapter.Insert((long)AssyPartView[1, e.RowIndex].Value,
                       (long)AssyPartView[0, e.RowIndex].Value, Convert.ToInt64(AssyPartView[2, e.RowIndex].Value.ToString()));
                        newRow = false;
                    }
                    else
                    {
                        int rowsUpdated = UpdateFunc((long)AssyPartView[e.ColumnIndex, e.RowIndex].Value,
                        (long)AssyPartView[3, e.RowIndex].Value);
                    }
                    
                }
                catch (SqlException exc)
                {
                    
                    newRow = false;
                    this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
                    MessageBox.Show(exc.Message);

                }
            }
            
        }
        private delegate int PartAssyUpdateDelegate(long item, long ID);

        private void AssyPartView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rowInd = e.Row.Index;
            part_AssyTableAdapter.Delete1(
                        (long)AssyPartView[3, rowInd].Value);
        }

        private void AssyPartView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRow = true;
        }
        private bool newRow = false;

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
                //this.assyTableAdapter.Fill(this.assyPartDS.Assy);
                //this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
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
