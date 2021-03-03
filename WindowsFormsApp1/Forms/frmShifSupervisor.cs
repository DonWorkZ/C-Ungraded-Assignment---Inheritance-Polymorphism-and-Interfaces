using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class frmShiftSupervisor : Form
    {
        public frmShiftSupervisor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtBonus.Text = string.Empty;

            txtNameInfo.Text = string.Empty;
            txtNumberInfo.Text = string.Empty;
            txtSalaryInfo.Text = string.Empty;
            txtBonusInfo.Text = string.Empty;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                ShiftSupervisor shiftSupervisor = new ShiftSupervisor
                {
                    Name = txtName.Text,
                    EmpNumber = Int32.Parse(txtNumber.Text),
                    AnnualSalary = Int32.Parse(txtSalary.Text),
                    AnnualBonus = Double.Parse(txtBonus.Text)
                };

                txtNameInfo.Text = shiftSupervisor.Name;
                txtNumberInfo.Text = shiftSupervisor.EmpNumber.ToString();
                txtSalaryInfo.Text = shiftSupervisor.AnnualSalary.ToString("$#.00");
                txtBonusInfo.Text = shiftSupervisor.AnnualBonus.ToString("$#.00");
            }
        }

        private bool ValidateFields()
        {
            string errorMessage = string.Empty;
            bool result = true;

            if (txtName.Text.Trim() == string.Empty)
            {
                result = false;
                txtName.Focus();
                MessageBox.Show("Please enter name.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Utilities.ValidateIntegerField(txtNumber, "number") == false)
            {
                result = false;
            }
            else if (Utilities.ValidateDecimalField(txtSalary, "annual salary") == false)
            {
                result = false;
            }
            else if (Utilities.ValidateDecimalField(txtBonus, "bonus") == false)
            {
                result = false;
            }
        
            return result;
        }

        
    }
}
