using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dataaccess.Entities;
using Dataaccess;

namespace Pharmacy_Management_System
{
    public partial class PMS_AddUser : Form
    {
        public PMS_AddUser()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            var Category = typecategory.Text;
            var Name = typename.Text;
            var Gender = typegender.Text;
            var DOB = typedob.Text;
            var Contact = typecontact.Text;
            var Username = typeusername.Text;
            var Password = typepassword.Text;

            Admin_User ad = new Admin_User();

            ad.Category = Category;
            ad.Name = Name;
            ad.Gender = Gender;
            ad.DOB = DOB;
            ad.Contact = Contact;
            ad.Username = Username;
            ad.Password = Password;

            Database db = new Database();
            var r = db.Admin_Users.Insert(ad);
            
            if ( r)
                {
                MessageBox.Show("Inserted");
                }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            typecategory.SelectedIndex = -1;
            typename.Clear();
            typegender.SelectedIndex = -1;
            typedob.Clear();
            typecontact.Clear();
            typeusername.Clear();
            typepassword.Clear();
        }
    }
}
