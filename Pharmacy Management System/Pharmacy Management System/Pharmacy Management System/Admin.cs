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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            new PMS_Dashbord().Show();
           // MessageBox.Show("ok");
            
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            new PMS_AddUser().Show();
            //MessageBox.Show("Ok");
        }

        private void btnviewuser_Click(object sender, EventArgs e)
        {
            new PMS_ViewUser().Show();
            //MessageBox.Show("ok");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logout");
            this.Hide();
        }
    }
}
