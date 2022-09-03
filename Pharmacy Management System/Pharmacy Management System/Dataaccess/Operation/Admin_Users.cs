using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dataaccess.Entities;
using System.Data.SqlClient;

namespace Dataaccess.Operation
{
    public class Admin_Users
    {
        /*  public void Insert() { }
          public void Edit() { }
          public void Delete() { }
          public void Get() { }
          public void Search() { } */

        SqlConnection conn;
        

        public Admin_Users()
        {
            string connStr = @"Server = DESKTOP-1JT0TF2\SQLEXPRESS; Database = Pharmacy Management; Integrated Security = True ";
            conn = new SqlConnection(connStr);
        }
        public List<Admin_User> GetAllAdmin_Users()
        {
            string query = "select * from Admin_User";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Admin_User> data = new List<Admin_User>();

            while (reader.Read())
            {
                Admin_User ad = new Admin_User();
                ad.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                ad.Category = reader.GetString(reader.GetOrdinal("Category"));
                ad.Name = reader.GetString(reader.GetOrdinal("Name"));
                ad.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                ad.DOB = reader.GetString(reader.GetOrdinal("DOB"));
                ad.Contact = reader.GetString(reader.GetOrdinal("Contact"));
                ad.Username = reader.GetString(reader.GetOrdinal("Username"));
                ad.Password = reader.GetString(reader.GetOrdinal("Password"));
                data.Add(ad);
            }
            conn.Close();
            return data;
        }
        public Admin_User GetAdmin_User(int id)
        {
            string query = "select * from Admin_User where ID = " +id;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin_User ad = null;
            while (reader.Read())
            {
                ad = new Admin_User();
                ad.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                ad.Category = reader.GetString(reader.GetOrdinal("Category"));
                ad.Name = reader.GetString(reader.GetOrdinal("Name"));
                ad.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                ad.DOB = reader.GetString(reader.GetOrdinal("DOB"));
                ad.Contact = reader.GetString(reader.GetOrdinal("Contact"));
                ad.Username = reader.GetString(reader.GetOrdinal("Username"));
                ad.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return ad;
        }
        public bool Insert(Admin_User ad)
        {
            string query = String.Format("Insert into Admin_User values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", ad.Category, ad.Name, ad.Gender, ad.DOB, ad.Contact, ad.Username, ad.Password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
           if (r > 0) return true;
            return false;
        }

        public Admin_User Search(string Username)
        {
            string query = string.Format("select * from Admin_User where username ='{0}'",Username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin_User ad = null;


            while (reader.Read())
            {
                 ad = new Admin_User();
                ad.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                ad.Category = reader.GetString(reader.GetOrdinal("Category"));
                ad.Name = reader.GetString(reader.GetOrdinal("Name"));
                ad.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                ad.DOB = reader.GetString(reader.GetOrdinal("DOB"));
                ad.Contact = reader.GetString(reader.GetOrdinal("Contact"));
                ad.Username = reader.GetString(reader.GetOrdinal("Username"));
                ad.Password = reader.GetString(reader.GetOrdinal("Password"));
                
            }
            conn.Close();
            return ad;
        }

        public bool Update(Admin_User ad)
        {
            string query = string.Format("Update Admin_User set Name = '{0}' where username ='{1}'", ad.Name ,ad.Username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            { return true; }
            return false;

        }

        public bool Delete(string username)
        {
            string query = string.Format("Delete from Admin_User where Username ='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int ab = cmd.ExecuteNonQuery();
            conn.Close();
            if (ab > 0)
            { return true; }
            return false;
        }
    }

}

