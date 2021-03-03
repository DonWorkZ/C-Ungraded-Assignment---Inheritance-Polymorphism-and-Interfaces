using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class frmEmployeeSelection : Form
    {
        public frmEmployeeSelection()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductionWorker_Click(object sender, EventArgs e)
        {
            var frmProductionWorker = new frmProductionWorker();
            frmProductionWorker.Show();
        }

        private void btnShiftSupervisor_Click(object sender, EventArgs e)
        {
            var frmShiftSupervisor = new frmShiftSupervisor();
            frmShiftSupervisor.Show();
        }
    }
}
