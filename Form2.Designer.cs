namespace WindowsFormsApp2
{
    partial class formQR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQR));
            this.pcbxVidCam = new System.Windows.Forms.PictureBox();
            this.cmbxCam = new System.Windows.Forms.ComboBox();
            this.lblCam = new System.Windows.Forms.Label();
            this.btnOpenCam = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.tmrScan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVidCam)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxVidCam
            // 
            this.pcbxVidCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbxVidCam.ErrorImage = null;
            this.pcbxVidCam.Location = new System.Drawing.Point(44, 91);
            this.pcbxVidCam.Name = "pcbxVidCam";
            this.pcbxVidCam.Size = new System.Drawing.Size(266, 227);
            this.pcbxVidCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxVidCam.TabIndex = 0;
            this.pcbxVidCam.TabStop = false;
            // 
            // cmbxCam
            // 
            this.cmbxCam.FormattingEnabled = true;
            this.cmbxCam.Location = new System.Drawing.Point(106, 51);
            this.cmbxCam.Name = "cmbxCam";
            this.cmbxCam.Size = new System.Drawing.Size(214, 21);
            this.cmbxCam.TabIndex = 1;
            this.cmbxCam.Text = "Choose Camera";
            // 
            // lblCam
            // 
            this.lblCam.AutoSize = true;
            this.lblCam.Location = new System.Drawing.Point(55, 54);
            this.lblCam.Name = "lblCam";
            this.lblCam.Size = new System.Drawing.Size(46, 13);
            this.lblCam.TabIndex = 2;
            this.lblCam.Text = "Camera:";
            // 
            // btnOpenCam
            // 
            this.btnOpenCam.Location = new System.Drawing.Point(58, 349);
            this.btnOpenCam.Name = "btnOpenCam";
            this.btnOpenCam.Size = new System.Drawing.Size(114, 43);
            this.btnOpenCam.TabIndex = 3;
            this.btnOpenCam.Text = "Open Camera:";
            this.btnOpenCam.UseVisualStyleBackColor = true;
            this.btnOpenCam.Click += new System.EventHandler(this.btnOpenCam_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(196, 349);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(114, 43);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan QR Code";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // tmrScan
            // 
            this.tmrScan.Interval = 1000;
            this.tmrScan.Tick += new System.EventHandler(this.tmrScan_Tick);
            // 
            // formQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnOpenCam);
            this.Controls.Add(this.lblCam);
            this.Controls.Add(this.cmbxCam);
            this.Controls.Add(this.pcbxVidCam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formQR";
            this.Text = "Fill out via QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formQR_FormClosing);
            this.Load += new System.EventHandler(this.formQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVidCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxVidCam;
        private System.Windows.Forms.ComboBox cmbxCam;
        private System.Windows.Forms.Label lblCam;
        private System.Windows.Forms.Button btnOpenCam;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Timer tmrScan;
    }
}