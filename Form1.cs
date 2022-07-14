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
    public partial class formTraceIt : Form
    {
        public static formTraceIt Infos;
        public TextBox Lastname;
        public TextBox Firstname;
        public TextBox Middlename;
        public TextBox Age;
        public TextBox Mobile;
        public TextBox Email;
        public TextBox Address;
        public TextBox Zip;
        public TextBox Time;
        public ComboBox Month;
        public ComboBox Day;
        public ComboBox Year;
        public Button Scanner;
        byte counter = 0;
        public formTraceIt()
        {
            InitializeComponent();
            Infos = this;
            //for transfering tools to another form
            Lastname = txtbxLastName;
            Firstname = txtbxFirstName;
            Middlename = txtbxMiddleName;
            Age = txtbxAge;
            Mobile = txtbxContact;
            Email = txtbxEmail;
            Address = txtbxAddress;
            Zip = txtbxZip;
            Time = txtbxtime;
            Month = cmbxMonth;
            Day = cmbxDay;
            Year = cmbxYear;
            Scanner = btnQr;

            //Startup
            btnSubmit.Enabled = false;
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            
            formQR QR = new formQR();
            QR.Show();
            btnQr.Enabled = false;
        }

        private void formTraceIt_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Trace It", "Greetings");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            bool all = true;
            //must complete the info before submitting
            if (string.IsNullOrEmpty(txtbxFirstName.Text))
                all = false;
            else if (string.IsNullOrEmpty(txtbxLastName.Text))
                all = false;
            else if (string.IsNullOrEmpty(txtbxMiddleName.Text))
                all = false;
            else if (string.IsNullOrEmpty(txtbxtime.Text))
                all = false;
            else if (cmbxMonth.Text == "select month")
                all = false;
            else if (cmbxDay.Text == "Day")
                all = false;
            else if (cmbxYear.Text == "Year")
                all = false;
            else if (string.IsNullOrEmpty(txtbxContact.Text) || txtbxContact.Text.Length != 11)
            {
                all = false;
                MessageBox.Show("Contact number should be 11 Digits");
            }
            else if (string.IsNullOrEmpty(txtbxAddress.Text))
                all = false;
            else if (string.IsNullOrEmpty(txtbxZip.Text) || txtbxZip.Text.Length != 4)
            {
                all = false;
                MessageBox.Show("The Zip Code you entered is incorrect");
            }
            else if (string.IsNullOrEmpty(txtbxAge.Text))
                all = false;
            else if ((!chkbxYes1.Checked) && (!chkbxNo1.Checked))
                all = false;
            else if ((!chkbxYes2.Checked) && (!chkbxNo2.Checked))
                all = false;
            if (all)
            {
                MessageBox.Show("Remember to Always stay safe", "Thank you");
            }
            else
                MessageBox.Show("Please Fill in All the Details Completely", "We want to Keep you safe");
            if (all)
            {
                File();
            }
            //reset
            if (all)
            {
                txtbxLastName.Clear();
                txtbxFirstName.Clear();
                txtbxMiddleName.Clear();
                txtbxAddress.Clear();
                txtbxZip.Clear();
                txtbxContact.Clear();
                txtbxtime.Clear();
                cmbxMonth.Text = "select month";
                cmbxDay.Text = "Day";
                cmbxYear.Text = "Year";
                txtbxEmail.Clear();
                txtbxAge.Clear();
                //Q1
                chkbxSymptom1.Checked = false;
                chkbxSymptom2.Checked = false;
                chkbxSymptom3.Checked = false;
                chkbxSymptom4.Checked = false;
                chkbxSymptom5.Checked = false;
                chkbxSymptom6.Checked = false;
                chkbxSymptom7.Checked = false;
                chkbxSymptom8.Checked = false;
                chkbxSymptom9.Checked = false;
                //Q2 and 3
                chkbxYes1.Checked = false;
                chkbxYes2.Checked = false;
                chkbxNo1.Checked = false;
                chkbxNo2.Checked = false;
                //confirmation
                chkbxConfirmation.Checked = false;
            }

        }

        private void chkbxConfirmation_CheckedChanged(object sender, EventArgs e)
        {
            //must accept the terms before submitting
            if (chkbxConfirmation.Checked)
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }

        private void chkbxYes1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxYes1.Checked)
            {
                chkbxNo1.Checked = false;
            }
            else if (chkbxNo1.Checked)
            {
                chkbxYes1.Checked = false;
            }
        }

        private void chkbxYes2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxYes2.Checked)
            {
                chkbxNo2.Checked = false;
            }
            else if (chkbxNo2.Checked)
            {
                chkbxYes2.Checked = false;
            }
        }

        private void chkbxNo1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxNo1.Checked)
            {
                chkbxYes1.Checked = false;
            }
            else if (chkbxYes1.Checked)
            {
                chkbxNo1.Checked = false;
            }
        }

        private void chkbxNo2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxNo2.Checked)
            {
                chkbxYes2.Checked = false;
            }
            else if (chkbxYes2.Checked)
            {
                chkbxNo2.Checked = false;
            }
        }
        string month = "Months";
        private void File()
        {
            //making a copy of responses
            if (cmbxMonth.Text == "January")
            {
                month = "January";
                File_content();
            }
            else if (cmbxMonth.Text == "February")
            {
                month = "February";
                File_content();
            }
            else if (cmbxMonth.Text == "March")
            {
                month = "March";
                File_content();
            }
            else if (cmbxMonth.Text == "April")
            {
                month = "April";
                File_content();
            }
            else if (cmbxMonth.Text == "May")
            {
                month = "May";
                File_content();
            }
            else if (cmbxMonth.Text == "June")
            {
                month = "June";
                File_content();
            }
            else if (cmbxMonth.Text == "July")
            {
                month = "July";
                File_content();
            }
            else if (cmbxMonth.Text == "August")
            {
                month = "August";
                File_content();
            }
            else if (cmbxMonth.Text == "September")
            {
                month = "September";
                File_content();
            }
            else if (cmbxMonth.Text == "October")
            {
                month = "October";
                File_content();
            }
            else if (cmbxMonth.Text == "November")
            {
                month = "November";
                File_content();
            }
            else if (cmbxMonth.Text == "December")
            {
                month = "December";
                File_content();
            }
        }
        private void File_content()
        {
            string day = cmbxDay.Text;
            string year = cmbxYear.Text;
            StreamWriter responses = new StreamWriter(@"C:\Users\Carl Joseph\source\repos\Contact Tracing App\Responses\" + (month) + " " + (day) + ", " + (year) + " responses.txt", true);
            ++counter;
            responses.WriteLine("Respondent " + counter);
            responses.WriteLine(" ");
            //Personal Information Part
            responses.WriteLine("Personal Information");
            responses.WriteLine("Name: " + txtbxFirstName.Text + " " + txtbxMiddleName.Text + " " + txtbxLastName.Text);
            responses.WriteLine("Age: " + txtbxAge.Text);
            responses.WriteLine("Contact no.: " + txtbxContact.Text);
            responses.WriteLine("Email Address: " + txtbxEmail.Text);
            responses.WriteLine("Address: " + txtbxAddress.Text);
            responses.WriteLine("Zip Code: " + txtbxZip.Text);
            responses.WriteLine("Time of Visit: " + txtbxtime.Text);
            responses.WriteLine("Date of Visit: " + cmbxMonth.Text + " " + cmbxDay.Text + ", " + cmbxYear.Text);
            responses.WriteLine(" ");
            responses.WriteLine("Health Check");
            //Health Check question 1
            if (chkbxSymptom1.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom1.Text);
            }
            if (chkbxSymptom2.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom2.Text);
            }
            if (chkbxSymptom3.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom3.Text);
            }
            if (chkbxSymptom4.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom4.Text);
            }
            if (chkbxSymptom5.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom5.Text);
            }
            if (chkbxSymptom6.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom6.Text);
            }
            if (chkbxSymptom7.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom7.Text);
            }
            if (chkbxSymptom8.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom8.Text);
            }
            if (chkbxSymptom9.Checked)
            {
                responses.WriteLine("Experienced: " + chkbxSymptom9.Text);
            }
            //Health Check Question 2
            if (chkbxYes1.Checked)
            {
                responses.WriteLine("Have been in close contact with a probable or confirmed case of COVID-19");
            }
            else
            {
                responses.WriteLine("Did not have a close contact with a probable or confirmed case of COVID-19");
            }
            //Health Check Question 3
            if (chkbxYes2.Checked)
            {
                responses.WriteLine("Fully Vaccinated");
            }
            else
            {
                responses.WriteLine("Not Fully Vaccinated");
            }
            responses.WriteLine(" ");
            responses.WriteLine("------------------");
            responses.WriteLine(" ");
            responses.Close();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            formADMIN ADMIN = new formADMIN();
            ADMIN.Show();
        }
    }
}
