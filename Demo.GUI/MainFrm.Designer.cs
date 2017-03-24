namespace Demo.GUI
{
    partial class MainFrm
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
            this.BtnInstall = new System.Windows.Forms.Button();
            this.BtnUnInstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxSqlConn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminEmail = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInstall
            // 
            this.BtnInstall.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnInstall.AllowDrop = true;
            this.BtnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInstall.Location = new System.Drawing.Point(330, 202);
            this.BtnInstall.Name = "BtnInstall";
            this.BtnInstall.Size = new System.Drawing.Size(118, 43);
            this.BtnInstall.TabIndex = 0;
            this.BtnInstall.Text = "Install";
            this.BtnInstall.UseVisualStyleBackColor = true;
            this.BtnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // BtnUnInstall
            // 
            this.BtnUnInstall.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnUnInstall.AllowDrop = true;
            this.BtnUnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUnInstall.Location = new System.Drawing.Point(466, 202);
            this.BtnUnInstall.Name = "BtnUnInstall";
            this.BtnUnInstall.Size = new System.Drawing.Size(118, 43);
            this.BtnUnInstall.TabIndex = 1;
            this.BtnUnInstall.Text = "Uninstall";
            this.BtnUnInstall.UseVisualStyleBackColor = true;
            this.BtnUnInstall.Click += new System.EventHandler(this.BtnUnInstall_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = " Service Admin Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sql Connnection:";
            // 
            // TbxSqlConn
            // 
            this.TbxSqlConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxSqlConn.Location = new System.Drawing.Point(16, 60);
            this.TbxSqlConn.Multiline = true;
            this.TbxSqlConn.Name = "TbxSqlConn";
            this.TbxSqlConn.Size = new System.Drawing.Size(568, 72);
            this.TbxSqlConn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin email:";
            // 
            // AdminEmail
            // 
            this.AdminEmail.Location = new System.Drawing.Point(16, 170);
            this.AdminEmail.Name = "AdminEmail";
            this.AdminEmail.Size = new System.Drawing.Size(243, 26);
            this.AdminEmail.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(16, 202);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(118, 43);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 257);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.AdminEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxSqlConn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUnInstall);
            this.Controls.Add(this.BtnInstall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInstall;
        private System.Windows.Forms.Button BtnUnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxSqlConn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminEmail;
        private System.Windows.Forms.Button BtnSave;
    }
}

