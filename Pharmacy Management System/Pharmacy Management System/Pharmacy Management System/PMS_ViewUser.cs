using Dataaccess;
using Dataaccess.Entities;
using Dataaccess.Operation;
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
    public partial class PMS_ViewUser : Form
    {
        public PMS_ViewUser()
        {
            InitializeComponent();
            /* List<string> data = new List<string>();
             data.Add("Mahabub");
             data.Add("Morshed");
             dtUsers.DataSource = data;*/
            Database db = new Database();
            List<Admin_User> data = db.Admin_Users.GetAllAdmin_Users();
            dtUsers.DataSource = data;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string Username = pmsusername.Text;
            Database db = new Database();
           Admin_User ad = db.Admin_Users.Search(Username);
            if(ad == null)
            {
                MessageBox.Show("Sorry,Username not found");
            }
            else
            {
                pmsname.Text = ad.Name;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string UpdatedName = pmsname.Text;
            Admin_User ad = new Admin_User();
            ad.Username = pmsusername.Text;
            ad.Name = pmsname.Text;

            Database db = new Database();
            bool i = db.Admin_Users.Update(ad);
            if(i)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not updated");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string username = pmsname.Text;
            Database db = new Database();
            bool ab = db.Admin_Users.Delete(username);
            if (ab)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

        }
    }
}
