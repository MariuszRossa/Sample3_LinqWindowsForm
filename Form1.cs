using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public partial class Form1 : Form
    {
        private Form_LinqSqlConnectionDataContext dataContext = new Form_LinqSqlConnectionDataContext();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = dataContext.SAMPLE1_GET_PRODUCT_DATA();
        }

        public void RefreshForm()
        {
            dataGridView1.DataSource = dataContext.SAMPLE1_GET_PRODUCT_DATA();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(dataContext);
            formAdd.ShowDialog();

            RefreshForm();
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            List<int> selected = new List<int>();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    selected.Add((int)dataGridView1.SelectedRows[i].Cells["ProductID"].Value);
                }
            }
            else
            {
                List<int> rowIndex = new List<int>();

                for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                {
                    int value = dataGridView1.SelectedCells[i].RowIndex;

                    if (!rowIndex.Contains(value))
                    {
                        rowIndex.Add(value);
                    }
                }

                foreach (int value in rowIndex)
                {
                    selected.Add((int)dataGridView1.Rows[value].Cells["ProductID"].Value);
                }
            }

            foreach(int id in selected)
            {
                dataContext.SAMPLE1_UPDATE_DISABLE_PRODUCT_SELLS(id);
            }
            RefreshForm();
        }
    }
}
