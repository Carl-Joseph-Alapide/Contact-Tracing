using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formADMIN : Form
    {
        public formADMIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtbxUsername.Text == "ADMIN" && txtbxPass.Text == "linkin0527")
            {
                formLog Log = new formLog();
                this.Hide();
                Log.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials","Log in failed");
            }
        }
    }
}
