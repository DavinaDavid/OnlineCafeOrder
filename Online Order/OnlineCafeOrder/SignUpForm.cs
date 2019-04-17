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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

      

        private void check_Leave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (c.Text == String.Empty)
            {
                error2.SetError(c, "Fill the required field");
                c.Focus();

            }
            else
            {
                error2.Clear();
            }
          
         
        }

   

        private void UserNameTxt_MouseUp(object sender, MouseEventArgs e)
        {

            UserNameTxt.Text = "";
            UserNameTxt.ForeColor = Color.Black;

        }

        private void EmailTxt_MouseUp(object sender, MouseEventArgs e)
        {
            EmailTxt.Text = "";
            EmailTxt.ForeColor = Color.Black;

        }

        private void CellTxt_MouseUp(object sender, MouseEventArgs e)
        {
            CellTxt.Text = "";
            CellTxt.ForeColor = Color.Black;

        }

        private void SetPassTxt_MouseUp(object sender, MouseEventArgs e)
        {
            SetPassTxt.Text = "";
            SetPassTxt.ForeColor = Color.Black;

        }

        private void AddressTxt_MouseUp(object sender, MouseEventArgs e)
        {
            AddressTxt.Text = "";
            AddressTxt.ForeColor = Color.Black;

        }

        private void EmailText_Click(object sender, EventArgs e)
        {
           

        }

        private void email_Leave(object sender, EventArgs e)
        {

        }

        private void EmailTxt_MouseLeave(object sender, EventArgs e)
        {
          //  label1.Text = "Enter Valid Email Format";
        }

        private void EmailTxt_MouseDown(object sender, MouseEventArgs e)
        {
           // label1.Text = "Enter Valid Email Format";

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void EmailTxt_MouseClick(object sender, MouseEventArgs e)
        {

        }

      
        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
             if (EmailTxt.Text != "") {
          
                if (EmailTxt.Text != "@" && EmailTxt.Text != ".com")
                {
                     label1.Text = "Invalid Email Format";
                }
                else
                {
                    label1.Visible = false;
                }

            }
          
        }

        private void SetPassTxt_TextChanged(object sender, EventArgs e)
        {
            if (SetPassTxt.Text != "")
            {
                var str = SetPassTxt.Text;
                if (!str.Any(Char.IsLetter) || !str.Any(Char.IsDigit))
                {
                    label2.Text = "Set Both Numbers and letters!";

                }
                else
                {
                    label2.Visible = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //  Form1 log = new LoginForm();
            //  Form1 form = new Form1();
            CAFE Form1 = new CAFE();
            Form1.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=VplProject;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            //con.Open();
            //cmd.CommandText = "Insert into ProjDB values ('" + UserNameTxt.Text + "','" + SetPassTxt.Text + "','" + AddressTxt.Text + "','" + EmailTxt.Text + "','" + CellTxt.Text + "')";
            //cmd.Connection = con;
            //cmd.ExecuteNonQuery();
            //con.Close();

            SqlCommand cmd = new SqlCommand();

            con.Open();

            cmd.Connection = con;
           cmd.CommandText = "Insert into SignUpDb values ('" + UserNameTxt.Text + "','" + SetPassTxt.Text + "','" + AddressTxt.Text + "','" + EmailTxt.Text + "','" + CellTxt.Text + "')";
           cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cmd.Connection = con;
            cmd.CommandText = "Insert into LoginDB (UserName,Password) values ('" + UserNameTxt.Text + "','" + SetPassTxt.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
         //   Button2.Visible = true;
          //  Label1.Text = "Successfully Registered";

            UserNameTxt.Text = SetPassTxt.Text = AddressTxt.Text = EmailTxt.Text = CellTxt.Text = "";

            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }
    }
}
