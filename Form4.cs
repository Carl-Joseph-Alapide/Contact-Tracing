using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formLog : Form
    {
        public formLog()
        {
            InitializeComponent();

            btnSearch.Enabled = false;
            cmbxDaySearch.Enabled = false;
            cmbxYearSearch.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string month = cmbxMonthSearch.Text;
            string day = cmbxDaySearch.Text;
            string year = cmbxYearSearch.Text;
            try
            {
                StreamReader Visitors = new StreamReader(@"C:\Users\Carl Joseph\source\repos\Contact Tracing App\Responses\" + (month) + " " + (day) + ", " + (year) + " responses.txt");
                MessageBox.Show(Visitors.ReadToEnd());
                Visitors.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There's no visitor on this date");
            }
        }

        private void cmbxMonthSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMonthSearch.Text == "search month")
            {
                cmbxDaySearch.Enabled = false;
            }
            else
            {
                cmbxDaySearch.Enabled = true;
            }
        }

        private void cmbxDaySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxDaySearch.Text == "Day")
            {
                cmbxYearSearch.Enabled = false;
            }
            else
            {
                cmbxYearSearch.Enabled = true;
            }
        }

        private void cmbxYearSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxYearSearch.Text == "Year")
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
    }
}
