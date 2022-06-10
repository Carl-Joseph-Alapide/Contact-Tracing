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