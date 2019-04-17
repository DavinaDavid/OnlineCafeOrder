using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLProject
{
    public partial class CAFE : Form
    {
        public CAFE()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();

        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            SignUpForm sign = new SignUpForm();
            sign.Show();
            this.Hide();
        }

        private void CAFE_Load(object sender, EventArgs e)
        {

        }
    }
}
