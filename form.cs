using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
       private  List<String> data = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Alert about inserted data,if the cell receives unwanted data,then you can alert the user from here
            if(e.RowIndex>=0 && e.ColumnIndex >= 0)
            {
                //Console.WriteLine(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                return;
            }
        }
        private void dataGridView2_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //for the current row,if a row cell is empty then stop event of validating this row.
            for(int i=0;i<dataGridView2.Columns.Count;i++)
            {
                Object data = dataGridView2.Rows[e.RowIndex].Cells[i].Value;
                if (data == null)
                {
                    e.Cancel = true;
                }
            }
        }

        //necessary to re implement the form closing event.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //validate the data of wanted cells.
            //e.Cancel = true;
        }
    }
}
