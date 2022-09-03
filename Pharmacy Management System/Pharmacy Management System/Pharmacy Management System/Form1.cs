using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            
                if (pmsusername.Text == "ijaz" && pmspassword.Text == "20434341")
                {
                    Admin a = new Admin();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please try again", "Error");
                }
        }
    }
}

