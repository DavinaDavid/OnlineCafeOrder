using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VPLProject
{
    public partial class ForgetPassForm : Form
    {
        public ForgetPassForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            if (SetPassTxt.Text == ConfrmPassTxt.Text)
            {
                //log.Show();
                //this.Hide();

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=VplProject;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "Update ProjDB set Password ='"+SetPassTxt.Text+"' where UserName='"+UserNameTxt.Text+"'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                //  log.Show();
                //  this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();



            }
            else
            {
                this.Show();
                log.Hide();
            }
            

        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void empty_Leave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (c.Text == String.Empty)
            {
                error1.SetError(c, "Fill the required field");
                c.Focus();

            }
            else
            {
                error1.Clear();
            }

        }

        private void User_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Code_MouseEnter(object sender, EventArgs e)
        {
          
        }


        private void ConfrmPass_MouseEnter(object sender, EventArgs e)
        {
        }

        private void UserNameTxt_MouseUp(object sender, MouseEventArgs e)
        {
            UserNameTxt.Text = "";
            UserNameTxt.ForeColor = Color.Black;
        }

        private void CodeTxt_MouseUp(object sender, MouseEventArgs e)
        {
            CodeTxt.Text = "";
            CodeTxt.ForeColor = Color.Black;
        }

        private void SetPassTxt_MouseUp(object sender, MouseEventArgs e)
        {
            SetPassTxt.Text = "";
            SetPassTxt.ForeColor = Color.Black;
        }

        private void ConfrmPassTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConfrmPassTxt_MouseUp(object sender, MouseEventArgs e)
        {
            ConfrmPassTxt.Text = "";
            ConfrmPassTxt.ForeColor = Color.Black;
        }

        private void SetPassTxt_TextChanged(object sender, EventArgs e)
        {
            if (SetPassTxt.Text != "") {
                var str = SetPassTxt.Text;
                if (!str.Any(Char.IsLetter) || !str.Any(Char.IsDigit))
                {
                    label1.Text = "Enter both numbers and letters!";
                   
                }
                else {
                    label1.Visible = false;
                }

            }
         
        }

        private void ConfrmPassTxt_TextChanged_1(object sender, EventArgs e)
        {
            
            if (ConfrmPassTxt.Text != "") {
                if (ConfrmPassTxt.Text != SetPassTxt.Text)
                {
                    label2.Text = "Password Mis-Matches!";
                }

                else
                {
                    label2.Visible = false;
                }

            }
      

        }

        private void button2_Click(object sender, EventArgs e)
        {

          LoginForm log= new LoginForm();
            log.Show();
            this.Hide();
        }
    }
}
