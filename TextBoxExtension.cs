using System;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public static class TextBoxExtension
    {
        public static void ClearTextBoxes(Form form)
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

            func(form.Controls);
        }
    }
}
