namespace WindowsFormsApp2
{
    partial class formLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLog));
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbxYearSearch = new System.Windows.Forms.ComboBox();
            this.cmbxDaySearch = new System.Windows.Forms.ComboBox();
            this.cmbxMonthSearch = new System.Windows.Forms.ComboBox();
            this.lblListofVisitors = new System.Windows.Forms.Label();
            this.lblCases = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(203, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 32);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbxYearSearch
            // 
            this.cmbxYearSearch.FormattingEnabled = true;
            this.cmbxYearSearch.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbxYearSearch.Location = new System.Drawing.Point(362, 101);
            this.cmbxYearSearch.Name = "cmbxYearSearch";
            this.cmbxYearSearch.Size = new System.Drawing.Size(95, 21);
            this.cmbxYearSearch.TabIndex = 52;
            this.cmbxYearSearch.Text = "Year";
            this.cmbxYearSearch.SelectedIndexChanged += new System.EventHandler(this.cmbxYearSearch_SelectedIndexChanged);
            // 
            // cmbxDaySearch
            // 
            this.cmbxDaySearch.FormattingEnabled = true;
            this.cmbxDaySearch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbxDaySearch.Location = new System.Drawing.Point(266, 100);
            this.cmbxDaySearch.Name = "cmbxDaySearch";
            this.cmbxDaySearch.Size = new System.Drawing.Size(90, 21);
            this.cmbxDaySearch.TabIndex = 51;
            this.cmbxDaySearch.Text = "Day";
            this.cmbxDaySearch.SelectedIndexChanged += new System.EventHandler(this.cmbxDaySearch_SelectedIndexChanged);
            // 
            // cmbxMonthSearch
            // 
            this.cmbxMonthSearch.FormattingEnabled = true;
            this.cmbxMonthSearch.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbxMonthSearch.Location = new System.Drawing.Point(108, 101);
            this.cmbxMonthSearch.Name = "cmbxMonthSearch";
            this.cmbxMonthSearch.Size = new System.Drawing.Size(152, 21);
            this.cmbxMonthSearch.TabIndex = 50;
            this.cmbxMonthSearch.Text = "Month";
            this.cmbxMonthSearch.SelectedIndexChanged += new System.EventHandler(this.cmbxMonthSearch_SelectedIndexChanged);
            // 
            // lblListofVisitors
            // 
            this.lblListofVisitors.AutoSize = true;
            this.lblListofVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListofVisitors.Location = new System.Drawing.Point(40, 67);
            this.lblListofVisitors.Name = "lblListofVisitors";
            this.lblListofVisitors.Size = new System.Drawing.Size(465, 30);
            this.lblListofVisitors.TabIndex = 49;
            this.lblListofVisitors.Text = "Select the date when you wish to see the list of people who visited the establish" +
    "ment.\r\n\r\n";
            this.lblListofVisitors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCases.Location = new System.Drawing.Point(40, 37);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(361, 30);
            this.lblCases.TabIndex = 48;
            this.lblCases.Text = "In case a COVID-19 positive person has visited the establishment:\r\n\r\n";
            this.lblCases.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 204);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbxYearSearch);
            this.Controls.Add(this.cmbxDaySearch);
            this.Controls.Add(this.cmbxMonthSearch);
            this.Controls.Add(this.lblListofVisitors);
            this.Controls.Add(this.lblCases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLog";
            this.Text = "Log History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbxYearSearch;
        private System.Windows.Forms.ComboBox cmbxDaySearch;
        private System.Windows.Forms.ComboBox cmbxMonthSearch;
        private System.Windows.Forms.Label lblListofVisitors;
        private System.Windows.Forms.Label lblCases;
    }
}