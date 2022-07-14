namespace WindowsFormsApp2
{
    partial class formADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formADMIN));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtbxPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(117, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(178, 75);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(154, 20);
            this.txtbxUsername.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(199, 27);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(89, 20);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Log History";
            // 
            // txtbxPass
            // 
            this.txtbxPass.Location = new System.Drawing.Point(178, 116);
            this.txtbxPass.Name = "txtbxPass";
            this.txtbxPass.Size = new System.Drawing.Size(154, 20);
            this.txtbxPass.TabIndex = 4;
            this.txtbxPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(117, 119);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(203, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 25);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // formADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 308);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbxPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formADMIN";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtbxPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
    }
}