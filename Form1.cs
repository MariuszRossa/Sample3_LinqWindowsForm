using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public partial class Form1 : Form
    {
        private IDataContext dataContext {  get; set; }


        public Form1(IDataContext dataContext)
        {
            InitializeComponent();

            this.dataContext = dataContext;

            dataGridView1.DataSource = dataContext.linqDataContext.SAMPLE1_GET_PRODUCT_DATA();
        }

        public void RefreshForm()
        {
            dataGridView1.DataSource = dataContext.linqDataContext.SAMPLE1_GET_PRODUCT_DATA();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(dataContext);
            formAdd.ShowDialog();

            RefreshForm();
        }

        private void buttonDisableSells2_Click(object sender, EventArgs e)
        {
            List<int> selected = GetRowId.ForProductID(dataGridView1);

            try
            {
                foreach (int id in selected)
                {
                    int result = dataContext.linqDataContext.SAMPLE1_UPDATE_DISABLE_PRODUCT_SELLS(id);
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }

            RefreshForm();
        }

        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            List<int> selected = GetRowId.ForProductID(dataGridView1);

            try
            {
                foreach (int id in selected)
                {
                    int result = dataContext.linqDataContext.SAMPLE1_DELETE_PRODUCT_SELLS(id);
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }

            RefreshForm();
        }
    }
}
