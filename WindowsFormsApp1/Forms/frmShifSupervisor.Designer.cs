
namespace WindowsFormsApp1.Forms
{
    partial class frmShiftSupervisor
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblBonusInfo = new System.Windows.Forms.Label();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.lblSalaryInfo = new System.Windows.Forms.Label();
            this.txtNumberInfo = new System.Windows.Forms.TextBox();
            this.lblNumberInfo = new System.Windows.Forms.Label();
            this.txtBonusInfo = new System.Windows.Forms.TextBox();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.txtSalaryInfo = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(95, 44);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(188, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(95, 100);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(188, 20);
            this.txtBonus.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(95, 72);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(188, 20);
            this.txtSalary.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(17, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(17, 75);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(17, 103);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 7;
            this.lblBonus.Text = "Bonus";
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.lblBonusInfo);
            this.grpInformation.Controls.Add(this.txtNameInfo);
            this.grpInformation.Controls.Add(this.lblSalaryInfo);
            this.grpInformation.Controls.Add(this.txtNumberInfo);
            this.grpInformation.Controls.Add(this.lblNumberInfo);
            this.grpInformation.Controls.Add(this.txtBonusInfo);
            this.grpInformation.Controls.Add(this.lblNameInfo);
            this.grpInformation.Controls.Add(this.txtSalaryInfo);
            this.grpInformation.Location = new System.Drawing.Point(20, 137);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(263, 145);
            this.grpInformation.TabIndex = 8;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            // 
            // lblBonusInfo
            // 
            this.lblBonusInfo.AutoSize = true;
            this.lblBonusInfo.Location = new System.Drawing.Point(6, 106);
            this.lblBonusInfo.Name = "lblBonusInfo";
            this.lblBonusInfo.Size = new System.Drawing.Size(37, 13);
            this.lblBonusInfo.TabIndex = 16;
            this.lblBonusInfo.Text = "Bonus";
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(75, 19);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.ReadOnly = true;
            this.txtNameInfo.Size = new System.Drawing.Size(182, 20);
            this.txtNameInfo.TabIndex = 9;
            this.txtNameInfo.TabStop = false;
            // 
            // lblSalaryInfo
            // 
            this.lblSalaryInfo.AutoSize = true;
            this.lblSalaryInfo.Location = new System.Drawing.Point(6, 78);
            this.lblSalaryInfo.Name = "lblSalaryInfo";
            this.lblSalaryInfo.Size = new System.Drawing.Size(36, 13);
            this.lblSalaryInfo.TabIndex = 15;
            this.lblSalaryInfo.Text = "Salary";
            // 
            // txtNumberInfo
            // 
            this.txtNumberInfo.Location = new System.Drawing.Point(75, 47);
            this.txtNumberInfo.Name = "txtNumberInfo";
            this.txtNumberInfo.ReadOnly = true;
            this.txtNumberInfo.Size = new System.Drawing.Size(182, 20);
            this.txtNumberInfo.TabIndex = 10;
            this.txtNumberInfo.TabStop = false;
            // 
            // lblNumberInfo
            // 
            this.lblNumberInfo.AutoSize = true;
            this.lblNumberInfo.Location = new System.Drawing.Point(6, 50);
            this.lblNumberInfo.Name = "lblNumberInfo";
            this.lblNumberInfo.Size = new System.Drawing.Size(44, 13);
            this.lblNumberInfo.TabIndex = 14;
            this.lblNumberInfo.Text = "Number";
            // 
            // txtBonusInfo
            // 
            this.txtBonusInfo.Location = new System.Drawing.Point(75, 103);
            this.txtBonusInfo.Name = "txtBonusInfo";
            this.txtBonusInfo.ReadOnly = true;
            this.txtBonusInfo.Size = new System.Drawing.Size(182, 20);
            this.txtBonusInfo.TabIndex = 11;
            this.txtBonusInfo.TabStop = false;
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(6, 22);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(35, 13);
            this.lblNameInfo.TabIndex = 13;
            this.lblNameInfo.Text = "Name";
            // 
            // txtSalaryInfo
            // 
            this.txtSalaryInfo.Location = new System.Drawing.Point(75, 75);
            this.txtSalaryInfo.Name = "txtSalaryInfo";
            this.txtSalaryInfo.ReadOnly = true;
            this.txtSalaryInfo.Size = new System.Drawing.Size(182, 20);
            this.txtSalaryInfo.TabIndex = 12;
            this.txtSalaryInfo.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(20, 297);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Display";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(114, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(208, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShiftSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 343);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Name = "frmShiftSupervisor";
            this.Text = "Shift Supervisor";
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblBonusInfo;
        private System.Windows.Forms.TextBox txtNameInfo;
        private System.Windows.Forms.Label lblSalaryInfo;
        private System.Windows.Forms.TextBox txtNumberInfo;
        private System.Windows.Forms.Label lblNumberInfo;
        private System.Windows.Forms.TextBox txtBonusInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.TextBox txtSalaryInfo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
    }
}