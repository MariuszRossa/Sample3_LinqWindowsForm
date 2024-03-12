using Sample3_LinqWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public partial class FormAdd : Form
    {
        public Form_LinqSqlConnectionDataContext DataContext { get; }

        public InsertProductModel InsertProduct { get; set; } = new InsertProductModel();


        public FormAdd(Form_LinqSqlConnectionDataContext dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
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

            ValidationContext validationContext = new ValidationContext(InsertProduct, null, null);

            IList<ValidationResult> validationErrors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(InsertProduct, validationContext, validationErrors, true))
            {
                foreach (ValidationResult error in validationErrors)
                {
                    MessageBox.Show(error.MemberNames.First() + " - " + error.ErrorMessage);
                }
            }
            else
            {
                try
                {
                    DataContext.SAMPLE1_INSERT_PRODUCT_DATA(
                            InsertProduct.Name,
                            InsertProduct.ProductNumber,
                            InsertProduct.Color,
                            InsertProduct.StockLevel,
                            InsertProduct.ReorderPoint,
                            InsertProduct.LastPrice,
                            InsertProduct.Size
                        );


                    MessageBox.Show("Added");

                    ClearTextBoxes();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
