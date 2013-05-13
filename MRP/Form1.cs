﻿using System;
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
            this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
            
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
                    bool isNew = AssyPartView.Rows[e.RowIndex].IsNewRow;
                    if (newRow)
                    {
                        int rowsInserted = part_AssyTableAdapter.Insert((long)AssyPartView[1, e.RowIndex].Value,
                       (long)AssyPartView[0, e.RowIndex].Value, Convert.ToInt64(AssyPartView[2, e.RowIndex].Value.ToString()));
                        newRow = false;
                    }
                    else
                    {
                        int rowsUpdated = UpdateFunc(Convert.ToInt64(AssyPartView[2, e.RowIndex].Value.ToString()),
                        (long)AssyPartView[1, e.RowIndex].Value,
                        (long)AssyPartView[0, e.RowIndex].Value);
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
        private delegate int PartAssyUpdateDelegate(long Qty, long Part, long Assy);

        private void AssyPartView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rowInd = e.Row.Index;
            part_AssyTableAdapter.Delete1((long)AssyPartView[1, rowInd].Value,
                        (long)AssyPartView[0, rowInd].Value);
        }

        private void AssyPartView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRow = true;
        }
        private bool newRow = false;

        private void PartView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           // if (PartView[0, e.RowIndex].Value != null && PartView[1, e.RowIndex].Value != null 
           //    && PartView[0, e.RowIndex].Value.ToString().Length > 0 && PartView[1, e.RowIndex].Value.ToString().Length > 0)
            //partBindingSource.EndEdit();
            


        }

        private void PartView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
