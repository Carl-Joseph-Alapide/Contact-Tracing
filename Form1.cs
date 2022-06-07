namespace Contact_Tracing_App
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
        }

        private void ContactTracing_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Trace it","Welcome");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remember to Always stay safe", "Thank you");
        }
    }
}