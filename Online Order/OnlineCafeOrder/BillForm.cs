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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("You have already ordered,Continue for more Orders?", "Order More", MessageBoxButtons.YesNo);
            BillForm billF = new BillForm();
            if (d == DialogResult.Yes)
            {
                billF.Show();
                this.Hide();



            }
            if (d == DialogResult.No)
            {
                this.Show();
                billF.Hide();
            }
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
