using Sample3_LinqWindowsForm.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public partial class FormAdd : Form
    {
        public InsertProductModel InsertProduct { get; set; } = new InsertProductModel();

        public IDataContext dataContext {  get; set; }

        public FormAdd(IDataContext dataContext)
        {
            InitializeComponent();
            this.dataContext = dataContext;
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            Int16 parseInt16Out;
            int parseIntOut;

            Int16.TryParse(textBoxStockLevel4.Text, out parseInt16Out);
            InsertProduct.StockLevel = parseInt16Out;

            Int16.TryParse(textBoxReorder5.Text, out parseInt16Out);
            InsertProduct.ReorderPoint = parseInt16Out;

            int.TryParse(textBoxLastPrice6.Text, out parseIntOut);
            InsertProduct.LastPrice = parseIntOut;

            InsertProduct.Name = textBoxName1.Text;
            InsertProduct.ProductNumber = textBoxProductNumber2.Text;
            InsertProduct.Color = textBoxColor3.Text;
            InsertProduct.Size = textBoxSize7.Text;

            if (SqlDataValidator.ValidateProduct(InsertProduct))
            {
                try
                {
                    dataContext.linqDataContext.SAMPLE1_INSERT_PRODUCT_DATA(
                            InsertProduct.Name,
                            InsertProduct.ProductNumber,
                            InsertProduct.Color,
                            InsertProduct.StockLevel,
                            InsertProduct.ReorderPoint,
                            InsertProduct.LastPrice,
                            InsertProduct.Size
                        );


                    MessageBox.Show("Added");

                    TextBoxExtension.ClearTextBoxes(this);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
