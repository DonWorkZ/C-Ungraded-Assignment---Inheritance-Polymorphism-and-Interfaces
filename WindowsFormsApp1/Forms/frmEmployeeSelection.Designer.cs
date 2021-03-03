
namespace WindowsFormsApp1.Forms
{
    partial class frmEmployeeSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProductionWorker = new System.Windows.Forms.Button();
            this.btnShiftSupervisor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductionWorker
            // 
            this.btnProductionWorker.Location = new System.Drawing.Point(32, 21);
            this.btnProductionWorker.Name = "btnProductionWorker";
            this.btnProductionWorker.Size = new System.Drawing.Size(93, 34);
            this.btnProductionWorker.TabIndex = 0;
            this.btnProductionWorker.Text = "Production Worker";
            this.btnProductionWorker.UseVisualStyleBackColor = true;
            this.btnProductionWorker.Click += new System.EventHandler(this.btnProductionWorker_Click);
            // 
            // btnShiftSupervisor
            // 
            this.btnShiftSupervisor.Location = new System.Drawing.Point(163, 21);
            this.btnShiftSupervisor.Name = "btnShiftSupervisor";
            this.btnShiftSupervisor.Size = new System.Drawing.Size(84, 34);
            this.btnShiftSupervisor.TabIndex = 1;
            this.btnShiftSupervisor.Text = "Shift Supervisor";
            this.btnShiftSupervisor.UseVisualStyleBackColor = true;
            this.btnShiftSupervisor.Click += new System.EventHandler(this.btnShiftSupervisor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(100, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmployeeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 109);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShiftSupervisor);
            this.Controls.Add(this.btnProductionWorker);
            this.Name = "frmEmployeeSelection";
            this.Text = "Employee Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductionWorker;
        private System.Windows.Forms.Button btnShiftSupervisor;
        private System.Windows.Forms.Button btnExit;
    }
}