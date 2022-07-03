namespace Contact_Tracing_App
{
    partial class formQRcode
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblCam = new System.Windows.Forms.Label();
            this.cmboxCamera = new System.Windows.Forms.ComboBox();
            this.pcbxCamera = new System.Windows.Forms.PictureBox();
            this.tmrScan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(228, 368);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 55;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(44, 368);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 54;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblCam
            // 
            this.lblCam.AutoSize = true;
            this.lblCam.Location = new System.Drawing.Point(44, 47);
            this.lblCam.Name = "lblCam";
            this.lblCam.Size = new System.Drawing.Size(51, 15);
            this.lblCam.TabIndex = 53;
            this.lblCam.Text = "Camera:";
            // 
            // cmboxCamera
            // 
            this.cmboxCamera.FormattingEnabled = true;
            this.cmboxCamera.Location = new System.Drawing.Point(101, 44);
            this.cmboxCamera.Name = "cmboxCamera";
            this.cmboxCamera.Size = new System.Drawing.Size(219, 23);
            this.cmboxCamera.TabIndex = 52;
            this.cmboxCamera.Text = "Select Camera";
            // 
            // pcbxCamera
            // 
            this.pcbxCamera.Location = new System.Drawing.Point(44, 86);
            this.pcbxCamera.Name = "pcbxCamera";
            this.pcbxCamera.Size = new System.Drawing.Size(276, 256);
            this.pcbxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxCamera.TabIndex = 51;
            this.pcbxCamera.TabStop = false;
            // 
            // tmrScan
            // 
            this.tmrScan.Interval = 1000;
            this.tmrScan.Tick += new System.EventHandler(this.tmrScan_Tick);
            // 
            // formQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblCam);
            this.Controls.Add(this.cmboxCamera);
            this.Controls.Add(this.pcbxCamera);
            this.Name = "formQRcode";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formQRcode_FormClosing);
            this.Load += new System.EventHandler(this.formQRcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStop;
        private Button btnScan;
        private Label lblCam;
        private ComboBox cmboxCamera;
        private PictureBox pcbxCamera;
        private System.Windows.Forms.Timer tmrScan;
    }
}