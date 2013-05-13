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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Assy". При необходимости она может быть перемещена или удалена.
            this.assyTableAdapter.Fill(this.dataSet.Assy);
           
           
           
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.AssyPart". При необходимости она может быть перемещена или удалена.
            this.assyPartTableAdapter.Fill(this.assyPartDS.AssyPart);
            this.partTableAdapter1.Fill(this.assyPartDS.Part);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "assyPartDS.Part_Assy". При необходимости она может быть перемещена или удалена.
            //this.part_AssyTableAdapter.Fill(this.assyPartDS.Part_Assy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Assy". При необходимости она может быть перемещена или удалена.
            
        }

       

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1[0,0].Value.ToString());
            //MessageBox.Show(assyTableAdapter1.GetIDByName2(dataGridView1[0, e.RowIndex].Value.ToString()).ToString());
            if (e.ColumnIndex == 2)
            {//можно изменять только количество
                assyPartTableAdapter.UpdateQty(Convert.ToInt64(dataGridView1[2, e.RowIndex].Value.ToString()),
                    (long)partTableAdapter1.GetIDByName(dataGridView1[1, e.RowIndex].Value.ToString()), 
                    (long)assyTableAdapter1.GetIDByName2(dataGridView1[0, e.RowIndex].Value.ToString()));
            }
        }
    }
}
