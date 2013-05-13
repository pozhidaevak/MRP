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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS1.Part". При необходимости она может быть перемещена или удалена.
            this.partTableAdapter1.Fill(this.assyPartDS1.Part);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part_Assy". При необходимости она может быть перемещена или удалена.
            this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Assy". При необходимости она может быть перемещена или удалена.
            this.assyTableAdapter.Fill(this.dataSet.Assy);
           
           
        
            
        }

       

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1[0,0].Value.ToString());
            //MessageBox.Show(assyTableAdapter1.GetIDByName2(dataGridView1[0, e.RowIndex].Value.ToString()).ToString());
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
                UpdateFunc(Convert.ToInt64(dataGridView1[2, e.RowIndex].Value.ToString()),
                    (long)dataGridView1[1, e.RowIndex].Value, 
                    (long)dataGridView1[0, e.RowIndex].Value);
            
        }
        private delegate int PartAssyUpdateDelegate(long Qty, long Part, long Assy); 
    }
}
