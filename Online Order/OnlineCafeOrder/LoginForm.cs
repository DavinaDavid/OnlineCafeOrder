using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.Sql;
using System.Data.SqlClient;


namespace VPLProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();


         //   SignUpForm sign = new SignUpForm();
            //// sending mail

            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.EnableSsl = true;
            //smtp.Credentials = new System.Net.NetworkCredential("RoyalCafe@gmail.com", "Royals12345");
            //MailMessage msg = new MailMessage();
            //msg.Subject = "Hello " + UserNameTxt.Text + "Login Found";
            //msg.Body = "Hi, Thankyou for becoming our customer,now We will Provide You The Latest Update. Thanks";
            //string toaddress = textBox1.Text;
            //msg.To.Add(toaddress);
            //string fromaddress = "RoyalCafe <RoyalCafe@gmail.com>";
            //msg.From = new MailAddress(fromaddress);
            //try
            //{
            //    smtp.Send(msg);

            //}
            //catch
            //{
            //    throw;
            //    MessageBox.Show("exception");// + exp);
            //}

           // SqlConnection con = new SqlConnection("Data Source = DESKTOP - S2LG294\\SQLEXPRESS; Initial Catalog = VplProject; Integrated Security = True");
   
           //SqlCommand cmd = new SqlCommand("select * from LoginDB where UserName='" + UserNameTxt.Text + "' and Password='" + passwordtxt.Text + "'", con);
           // cmd.Parameters.AddWithValue("UserName", UserNameTxt.Text);
           // cmd.Parameters.AddWithValue("Password", passwordtxt.Text);
           // SqlDataAdapter sda = new SqlDataAdapter(cmd);
           // DataTable dt = new DataTable();
           // sda.Fill(dt);
           // con.Open();
           // int i = cmd.ExecuteNonQuery();
           // con.Close();
           // if (dt.Rows.Count > 0)
           // {
           //     //  Session["id"] = TextBox1.Text;
           //     //   Response.Redirect("Redirectform.aspx");
           //     // Session.RemoveAll();
           //     MenuForm menu = new MenuForm();
           //     menu.Show();
           //     this.Hide();
           // }
           // else
           // {
           //     MenuForm menu = new MenuForm();
           //     this.Show();
           //     menu.Hide();
           //     //Label1.Text = "You're username and word is incorrect";
           //     //Label1.ForeColor = System.Drawing.Color.Red;

           // }
        
        
    }

        //public void Display() {

        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=VplProject;Integrated Security=True");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "select (UserName,Password) from  ProjDB where UserName='" + UserNameTxt.Text + "' and Password='" + passwordtxt.Text + "'";
        //    cmd.ExecuteNonQuery();
        //    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    //  adpt = new SqlDataAdapter();
        //    //    ds = new DataTable();
        //    adpt.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();




        //}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ForgetPassForm forget = new ForgetPassForm();
            CodeForm codeF = new CodeForm();
           codeF.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void passwordtxt_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtxt.BackColor = Color.Black;
            passwordtxt.ForeColor = Color.White;

        }

   
        private void UserNameTxt_Enter_1(object sender, EventArgs e)
        {
            UserNameTxt.Text = "";
        }

        private void passwordtxt_Enter_1(object sender, EventArgs e)
        {
            passwordtxt.Text = "";
        }
        

        private void UserNameTxt_MouseDown(object sender, MouseEventArgs e)
        {
            UserNameTxt.BackColor = Color.Black;
            UserNameTxt.ForeColor = Color.White;
        }

        private void UserNameTxt_MouseLeave(object sender, EventArgs e)
        {
            UserNameTxt.BackColor = Color.White;
            UserNameTxt.ForeColor = Color.Black;
        }

        private void passwordtxt_MouseLeave(object sender, EventArgs e)
        {
            passwordtxt.BackColor = Color.White;
            passwordtxt.ForeColor = Color.Black;
        }

        private void passwordtxt_MouseEnter(object sender, EventArgs e)
        {
          //  passwordtxt.Text = "*";
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                //  MessageBox.Show("The Caps Lock key is ON.");
                label1.Text = "CapsLock is ON";
            }
            else {

                label1.Text = "";
            }
        }

        private void Empty_Leave(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "") {
                UserNameTxt.Focus();
                MessageBox.Show("NO username provided");
            }
            if (passwordtxt.Text == "") {
                passwordtxt.Focus();
                MessageBox.Show("NO password provided");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CAFE Form1 = new CAFE();
            Form1.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
