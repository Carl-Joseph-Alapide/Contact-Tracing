namespace Contact_Tracing_App
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
            btnsubmit.Enabled = false;
        }

        private void ContactTracing_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Trace it","Welcome");
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
            else if (string.IsNullOrEmpty(txtbxcontactno.Text) || txtbxcontactno.Text.Length != 11)
            {
                all = false;
                MessageBox.Show("Contact number should be 11 Digits");
            }
            else if (string.IsNullOrEmpty(txtbxaddress.Text))
                all = false;
            else if (string.IsNullOrEmpty(txtbxAge.Text))
                all = false; 
            if (all)           
            {
                MessageBox.Show("Remember to Always stay safe", "Thank you");
            }
            else
                MessageBox.Show("Please Fill in All the Details Completely", "We want to Keep you safe");
            //making a copy of responses
            //Personal Information Part
            StreamWriter responses = new StreamWriter(@"C:\Users\Carl Joseph\source\repos\Contact Tracing App\Responses\Responses.txt");
            responses.WriteLine("Respondent 1");
            responses.WriteLine("Name: " + txtbxFirstName.Text + " " + txtbxMiddleName.Text + " " + txtbxLastName.Text);
            responses.WriteLine("Age: " + txtbxAge.Text);
            responses.WriteLine("Contact no.: " + txtbxcontactno.Text);
            responses.WriteLine("Email Address: " + txtbxEmail.Text);
            responses.WriteLine("Address: " + txtbxaddress.Text);
            responses.WriteLine("Time of Visit; " + txtbxtime.Text);
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
            responses.Close();
            //reset
            if (all)
            {
                txtbxLastName.Clear();
                txtbxFirstName.Clear();
                txtbxMiddleName.Clear();
                txtbxaddress.Clear();
                txtbxcontactno.Clear();
                txtbxtime.Clear();
                txtbxEmail.Clear();
                txtbxAge.Clear();
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
    }
}