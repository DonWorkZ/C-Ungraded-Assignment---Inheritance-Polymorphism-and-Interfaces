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
    public partial class frmProductionWorker : Form
    {
        public frmProductionWorker()
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
            txtShift.Text = string.Empty;
            txtPayRate.Text = string.Empty;

            txtNameInfo.Text = string.Empty;
            txtNumberInfo.Text = string.Empty;
            txtShiftInfo.Text = string.Empty;
            txtPayRateInfo.Text = string.Empty;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                ProductionWorker productionWorker = new ProductionWorker
                {
                    Name = txtName.Text,
                    EmpNumber = Int32.Parse(txtNumber.Text),
                    Shift = Int32.Parse(txtShift.Text),
                    HourlyRate = Double.Parse(txtPayRate.Text)
                };

                txtNameInfo.Text = productionWorker.Name;
                txtNumberInfo.Text = productionWorker.EmpNumber.ToString();
                txtShiftInfo.Text = productionWorker.Shift.ToString();
                txtPayRateInfo.Text = productionWorker.HourlyRate.ToString("$#.00");
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
            else if (Utilities.ValidateIntegerField(txtShift, "shift") == false)
            {
                result = false;
            }
            else if (Utilities.ValidateDecimalField(txtPayRate, "pay rate") == false)
            {
                result = false;
            }
            else if(!(txtShift.Text == "1" || txtShift.Text == "2"))
            {
                result = false;
                txtShift.Focus();
                MessageBox.Show("Shift value must be 1 or 2.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            return result;
        }

        
    }
}
