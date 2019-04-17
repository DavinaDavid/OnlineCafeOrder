using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace VPLProject
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();
        }

        private void loginMenubtn_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int value = random.Next(1001, 9999);
            //string destinationaddr = "91" + phoneNum.Text;
            //string message = "Your OTP Number is " + value + " ( Sent By : Royal Cafe )";
            ////Label3.Text = message;
            //String message1 = HttpUtility.UrlEncode(message);
            //using (var wb = new WebClient())
            //{
            //    byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
            //    {
            //    {"apikey" , "FammnpFW0Ks-gRKkiQvnke2nG940NkDbbl4jUV4elK"},
            //    {"numbers" , destinationaddr},
            //    {"message" , message1},
            //    {"sender" , "TXTLCL"}
            //    });
            //    string result = System.Text.Encoding.UTF8.GetString(response);
            //    Session["otp"] = value;

            ForgetPassForm forget = new ForgetPassForm();
            forget.Show();
            this.Hide();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void UserNameTxt_MouseUp(object sender, MouseEventArgs e)
        {
            UserNameTxt.Text = "";
            UserNameTxt.ForeColor = Color.Black;
        }

        private void phoneNum_MouseUp(object sender, MouseEventArgs e)
        {
            phoneNum.Text = "";
            phoneNum.ForeColor = Color.Black;
        }

        private void Check_Leave(object sender, EventArgs e)
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
    }
}
