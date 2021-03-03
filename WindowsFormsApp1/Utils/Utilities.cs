using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Utils
{
    public static class Utilities
    {
        public static bool ValidateIntegerField(TextBox textBox, string controlName)
        {
            bool result = true;
            int output;

            if (textBox.Text.Trim() == string.Empty)
            {
                result = false;
                textBox.Focus();
                MessageBox.Show($"Please enter {controlName}", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.TryParse(textBox.Text, out output) == false || output <= 0)
            {
                result = false;
                textBox.Focus();
                MessageBox.Show("Please enter numeric value greater than zero", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
        public static bool ValidateDecimalField(TextBox textBox, string controlName)
        {
            bool result = true;
            double output;

            if (textBox.Text.Trim() == string.Empty)
            {
                result = false;
                textBox.Focus();
                MessageBox.Show($"Please enter {controlName}", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Double.TryParse(textBox.Text, out output) == false || output <= 0)
            {
                result = false;
                textBox.Focus();
                MessageBox.Show("Please enter numeric value greater than zero", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

    }
}
