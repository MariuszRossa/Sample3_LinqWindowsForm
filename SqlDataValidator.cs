using Sample3_LinqWindowsForm.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public static class SqlDataValidator
    {
        public static bool ValidateProduct(InsertProductModel insertProduct) {

            ValidationContext validationContext = new ValidationContext(insertProduct, null, null);

            IList<ValidationResult> validationErrors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(insertProduct, validationContext, validationErrors, true))
            {
                foreach (ValidationResult error in validationErrors)
                {
                    MessageBox.Show(error.MemberNames.First() + " - " + error.ErrorMessage);
                }
                return false;
            }

            return true;
        }
    }
}
