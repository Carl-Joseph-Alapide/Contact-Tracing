namespace Contact_Tracing_App
{
    partial class ContactTracing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracing));
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxcontactno = new System.Windows.Forms.TextBox();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtbxtime = new System.Windows.Forms.TextBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMidName = new System.Windows.Forms.Label();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtbxaddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(12, 31);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(144, 23);
            this.txtbxFirstName.TabIndex = 0;
            // 
            // txtbxcontactno
            // 
            this.txtbxcontactno.Location = new System.Drawing.Point(12, 85);
            this.txtbxcontactno.Name = "txtbxcontactno";
            this.txtbxcontactno.Size = new System.Drawing.Size(144, 23);
            this.txtbxcontactno.TabIndex = 2;
            // 
            // lblcontactno
            // 
            this.lblcontactno.AutoSize = true;
            this.lblcontactno.Location = new System.Drawing.Point(10, 67);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(69, 15);
            this.lblcontactno.TabIndex = 5;
            this.lblcontactno.Text = "Contact no.";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(41, 240);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtbxtime
            // 
            this.txtbxtime.Location = new System.Drawing.Point(8, 192);
            this.txtbxtime.Name = "txtbxtime";
            this.txtbxtime.Size = new System.Drawing.Size(144, 23);
            this.txtbxtime.TabIndex = 8;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(8, 174);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(71, 15);
            this.lbltime.TabIndex = 9;
            this.lbltime.Text = "Time of visit";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(160, 31);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(144, 23);
            this.txtbxLastName.TabIndex = 11;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(12, 13);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(67, 15);
            this.lblfirstname.TabIndex = 10;
            this.lblfirstname.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(161, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblMidName
            // 
            this.lblMidName.AutoSize = true;
            this.lblMidName.Location = new System.Drawing.Point(310, 13);
            this.lblMidName.Name = "lblMidName";
            this.lblMidName.Size = new System.Drawing.Size(82, 15);
            this.lblMidName.TabIndex = 13;
            this.lblMidName.Text = "Middle Name:";
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Location = new System.Drawing.Point(310, 31);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(144, 23);
            this.txtbxMiddleName.TabIndex = 14;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(10, 121);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(71, 15);
            this.lbladdress.TabIndex = 15;
            this.lbladdress.Text = "Full Address";
            // 
            // txtbxaddress
            // 
            this.txtbxaddress.Location = new System.Drawing.Point(10, 139);
            this.txtbxaddress.Name = "txtbxaddress";
            this.txtbxaddress.Size = new System.Drawing.Size(144, 23);
            this.txtbxaddress.TabIndex = 16;
            // 
            // ContactTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 348);
            this.Controls.Add(this.txtbxaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtbxMiddleName);
            this.Controls.Add(this.lblMidName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.txtbxtime);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblcontactno);
            this.Controls.Add(this.txtbxcontactno);
            this.Controls.Add(this.txtbxFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracing";
            this.Text = "Trace It";
            this.Load += new System.EventHandler(this.ContactTracing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbxFirstName;
        private TextBox txtbxcontactno;
        private Label lblcontactno;
        private Button btnsubmit;
        private TextBox txtbxtime;
        private Label lbltime;
        private TextBox txtbxLastName;
        private Label lblfirstname;
        private Label lblLastName;
        private Label lblMidName;
        private TextBox txtbxMiddleName;
        private Label lbladdress;
        private TextBox txtbxaddress;
    }
}