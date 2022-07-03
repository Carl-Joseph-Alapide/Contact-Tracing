namespace Contact_Tracing_App
{
    public partial class ContactTracing : Form
    {
        byte counter = 0;
        public ContactTracing()
        {
            InitializeComponent();
            btnsubmit.Enabled = false;
            btnsearch.Enabled = false;
            cmboxDaysearch.Enabled = false;
            cmboxYearsearch.Enabled = false;
        }

        private void ContactTracing_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Trace it", "Welcome");
        }
        private void btnsubmit_Click(object sender, EventArgs e)
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
            else if (cmboxmonth.Text == "select month")
                all = false;
            else if (cmboxDay.Text == "Day")
                all = false;
            else if (cmboxYear.Text == "Year")
                all = false;
            else if (string.IsNullOrEmpty(txtbxcontactno.Text) || txtbxcontactno.Text.Length != 11)
            {
                all = false;
                MessageBox.Show("Contact number should be 11 Digits");
            }
            else if (string.IsNullOrEmpty(txtbxaddress.Text))
                all = false;
            else if (string.IsNullOrEmpty(txtbxAge.Text))
                all = false;
            else if ((!chkbxyes1.Checked) && (!chkbxNo1.Checked))
                all = false;
            else if ((!chkbxyes2.Checked) && (!chkbxNo2.Checked))
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
                txtbxaddress.Clear();
                txtbxcontactno.Clear();
                txtbxtime.Clear();
                cmboxmonth.Text = "select month";
                cmboxDay.Text = "Day";
                cmboxYear.Text = "Year";
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
                chkbxyes1.Checked = false;
                chkbxyes2.Checked = false;
                chkbxNo1.Checked = false;
                chkbxNo2.Checked = false;
                //confirmation
                chkbxCertification.Checked = false;
            }
        }

        private void chkbxCertification_CheckedChanged(object sender, EventArgs e)
        {
            //must accept the terms before submitting
            if (chkbxCertification.Checked)
                btnsubmit.Enabled = true;
            else
                btnsubmit.Enabled = false;
        }

        private void chkbxyes1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxyes1.Checked)
            {
                chkbxNo1.Checked = false;
            }
            else if (chkbxNo1.Checked)
            {
                chkbxyes1.Checked = false;
            }
        }

        private void chkbxyes2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxyes2.Checked)
            {
                chkbxNo2.Checked = false;
            }
            else if (chkbxNo2.Checked)
            {
                chkbxyes2.Checked = false;
            }
        }

        private void chkbxNo1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxNo1.Checked)
            {
                chkbxyes1.Checked = false;
            }
            else if (chkbxyes1.Checked)
            {
                chkbxNo1.Checked = false;
            }
        }

        private void chkbxNo2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxNo2.Checked)
            {
                chkbxyes2.Checked = false;
            }
            else if (chkbxyes2.Checked)
            {
                chkbxNo2.Checked = false;
            }
        }
        string month = "Months";
        private void File()
        {
            //making a copy of responses
            if (cmboxmonth.Text == "January")
            {
                month = "January";
                File_content();
            }
            else if (cmboxmonth.Text == "February")
            {
                month = "February";
                File_content();
            }
            else if (cmboxmonth.Text == "March")
            {
                month = "March";
                File_content();
            }
            else if (cmboxmonth.Text == "April")
            {
                month = "April";
                File_content();
            }
            else if (cmboxmonth.Text == "May")
            {
                month = "May";
                File_content();
            }
            else if (cmboxmonth.Text == "June")
            {
                month = "June";
                File_content();
            }
            else if (cmboxmonth.Text == "July")
            {
                month = "July";
                File_content();
            }
            else if (cmboxmonth.Text == "August")
            {
                month = "August";
                File_content();
            }
            else if (cmboxmonth.Text == "September")
            {
                month = "September";
                File_content();
            }
            else if (cmboxmonth.Text == "October")
            {
                month = "October";
                File_content();
            }
            else if (cmboxmonth.Text == "November")
            {
                month = "November";
                File_content();
            }
            else if (cmboxmonth.Text == "December")
            {
                month = "December";
                File_content();
            }
        }
        private void File_content ()
        {
            string day = cmboxDay.Text;
            string year = cmboxYear.Text;   
            StreamWriter responses = new StreamWriter(@"C:\Users\Carl Joseph\source\repos\Contact Tracing App\Responses\" + (month) + " " + (day) + ", " + (year) + " responses.txt", true);
            ++counter;
            responses.WriteLine("Respondent " + counter);
            responses.WriteLine(" ");
            //Personal Information Part
            responses.WriteLine("Personal Information");
            responses.WriteLine("Name: " + txtbxFirstName.Text + " " + txtbxMiddleName.Text + " " + txtbxLastName.Text);
            responses.WriteLine("Age: " + txtbxAge.Text);
            responses.WriteLine("Contact no.: " + txtbxcontactno.Text);
            responses.WriteLine("Email Address: " + txtbxEmail.Text);
            responses.WriteLine("Address: " + txtbxaddress.Text);
            responses.WriteLine("Time of Visit: " + txtbxtime.Text);
            responses.WriteLine("Date of Visit: " + cmboxmonth.Text + " " + cmboxDay.Text + ", " + cmboxYear.Text);
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
            if (chkbxyes1.Checked)
            {
                responses.WriteLine("Have been in close contact with a probable or confirmed case of COVID-19");
            }
            else
            {
                responses.WriteLine("Did not have a close contact with a probable or confirmed case of COVID-19");
            }
            //Health Check Question 3
            if (chkbxyes2.Checked)
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
        private void cmboxMonthsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmboxMonthsearch.Text == "search month")
            {
                cmboxDaysearch.Enabled = false;
            }
           else
            {
                cmboxDaysearch.Enabled=true;
            }

        }

        private void cmboxDaysearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxDaysearch.Text == "Day")
            {
                cmboxYearsearch.Enabled = false;
            }
            else
            {
                cmboxYearsearch.Enabled = true;
            }
        }

        private void cmboxYearsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxYearsearch.Text == "Year")
            {
                btnsearch.Enabled = false;
            }
            else
            {
                btnsearch.Enabled = true;
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string month = cmboxMonthsearch.Text;
            string day = cmboxDaysearch.Text;
            string year = cmboxYearsearch.Text;
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

        private void btnQRcode_Click(object sender, EventArgs e)
        {
      
            this.Hide();
            formQRcode QR = new formQRcode();
            QR.Show();
        }
    }
}