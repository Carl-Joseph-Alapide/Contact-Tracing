namespace Contact_Tracing_App
{
    partial class FormQRcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQRcode));
            this.pcbxScan = new System.Windows.Forms.PictureBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cmboxCamera = new System.Windows.Forms.ComboBox();
            this.btnScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxScan)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxScan
            // 
            this.pcbxScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbxScan.Location = new System.Drawing.Point(54, 55);
            this.pcbxScan.Name = "pcbxScan";
            this.pcbxScan.Size = new System.Drawing.Size(341, 299);
            this.pcbxScan.TabIndex = 0;
            this.pcbxScan.TabStop = false;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(54, 26);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(51, 15);
            this.lblCamera.TabIndex = 1;
            this.lblCamera.Text = "Camera:";
            // 
            // cmboxCamera
            // 
            this.cmboxCamera.FormattingEnabled = true;
            this.cmboxCamera.Location = new System.Drawing.Point(111, 23);
            this.cmboxCamera.Name = "cmboxCamera";
            this.cmboxCamera.Size = new System.Drawing.Size(284, 23);
            this.cmboxCamera.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(184, 385);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // FormQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 453);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmboxCamera);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.pcbxScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQRcode";
            this.Text = "Trace It";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbxScan;
        private Label lblCamera;
        private ComboBox cmboxCamera;
        private Button btnScan;
    }
}