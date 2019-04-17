using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace VPLProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
      

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you Sure to Confirm this Order?", "ORDER CONFIRMATION", MessageBoxButtons.YesNo);
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
            richTextBox1.Text="asad";
        

        }

        private void Price15_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (item1.Checked == true)
            {
                amount1.Visible = true;
                amount1.Text = (calculate(Price1.Text, Convert.ToInt32(numericUpDown1.Value.ToString()))).ToString();
               // total_amount = Convert.ToInt32(amount1.Text);
            }
            else
            {
                amount1.Visible = false;
                numericUpDown1.Value = 0;
            }
        }

        public int calculate(string price, int value)
        {
            int x = Convert.ToInt32(price);
            int y = value;
            int z = 0;
            if (x != 0 && y != 0)
            {
                z = x * y;
            }
            else
            {
                z = 0;
            }
            return z;
        }

        private void allcheckbox(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (item2.Checked == true)
            {
                amount2.Visible = true;
                amount2.Text = (calculate(Price2.Text, Convert.ToInt32(numericUpDown2.Value.ToString()))).ToString();
            }
            else
            {
                amount2.Visible = false;
                numericUpDown2.Value = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            amount1.Visible = false;
            amount2.Visible = false;
            amount3.Visible = false;
            amount4.Visible = false;
            amount5.Visible = false;
            amount6.Visible = false;
            amount7.Visible = false;
            amount8.Visible = false;
            amount9.Visible = false;
            amount10.Visible = false;
            amount11.Visible = false;
            amount12.Visible = false;
            amount13.Visible = false;
            amount14.Visible = false;
            amount15.Visible = false;
            amount16.Visible = false;
            amount17.Visible = false;
            amount18.Visible = false;
            amount19.Visible = false;
            amount20.Visible = false;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (item3.Checked == true)
            {

                amount3.Visible = true;
                amount3.Text = (calculate(Price3.Text, Convert.ToInt32(numericUpDown3.Value.ToString()))).ToString();
            }
            else
            {
                amount3.Visible = false;
                numericUpDown3.Value = 0;
            }
            
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (item4.Checked == true)
            {

                amount4.Visible = true;
                amount4.Text = (calculate(Price4.Text, Convert.ToInt32(numericUpDown4.Value.ToString()))).ToString();
            }
            else
            {
                amount4.Visible = false;
                numericUpDown4.Value = 0;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (item5.Checked == true)
            {
                amount5.Visible = true;
                amount5.Text = (calculate(Price5.Text, Convert.ToInt32(numericUpDown5.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (item7.Checked == true)
            {

                amount7.Visible = true;
                amount7.Text = (calculate(Price7.Text, Convert.ToInt32(numericUpDown7.Value.ToString()))).ToString();
            }
            else
           {
            //    amount4.Visible = false;
            //    numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (item6.Checked == true)
            {
                amount6.Visible = true;
                amount6.Text = (calculate(Price6.Text, Convert.ToInt32(numericUpDown6.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (item8.Checked == true)
            {
                amount8.Visible = true;
                amount8.Text = (calculate(Price8.Text, Convert.ToInt32(numericUpDown8.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (item9.Checked == true)
            {
                amount9.Visible = true;
                amount9.Text = (calculate(Price9.Text, Convert.ToInt32(numericUpDown9.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (item10.Checked == true)
            {
                amount10.Visible = true;
                amount10.Text = (calculate(Price10.Text, Convert.ToInt32(numericUpDown10.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (item11.Checked == true)
            {
                amount11.Visible = true;
                amount11.Text = (calculate(Price11.Text, Convert.ToInt32(numericUpDown11.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (item12.Checked == true)
            {
                amount12.Visible = true;
                amount12.Text = (calculate(Price12.Text, Convert.ToInt32(numericUpDown12.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (item13.Checked == true)
            {

                amount13.Visible = true;
                amount13.Text = (calculate(Price13.Text, Convert.ToInt32(numericUpDown13.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if (item14.Checked == true)
            {
                amount14.Visible = true;
                amount14.Text = (calculate(Price14.Text, Convert.ToInt32(numericUpDown14.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (item15.Checked == true)
            {
                amount15.Visible = true;
                amount15.Text = (calculate(Price15.Text, Convert.ToInt32(numericUpDown15.Value.ToString()))).ToString();
            }
            else
            {
                //amount4.Visible = false;
                //numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            if (item16.Checked == true)
            {
                amount16.Visible = true;
                amount16.Text = (calculate(Price16.Text, Convert.ToInt32(numericUpDown16.Value.ToString()))).ToString();
            }
            else
            {
            //    amount4.Visible = false;
            //    numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            if (item17.Checked == true)
            {
                amount17.Visible = true;
                amount17.Text = (calculate(Price17.Text, Convert.ToInt32(numericUpDown17.Value.ToString()))).ToString();
            }
            else
            {
            //    amount4.Visible = false;
            //    numericUpDown4.Value = 0;
            }

        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (item18.Checked == true)
            {
                amount18.Visible = true;
                amount18.Text = (calculate(Price18.Text, Convert.ToInt32(numericUpDown18.Value.ToString()))).ToString();
            }
            else
            {
                amount18.Visible = false;
                numericUpDown18.Value = 0;
            }

        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (item19.Checked == true)
            {

                amount19.Visible = true;
                amount19.Text = (calculate(Price19.Text, Convert.ToInt32(numericUpDown19.Value.ToString()))).ToString();
            }
            else
            {
                amount19.Visible = false;
                numericUpDown19.Value = 0;
            }

        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            if (item20.Checked == true)
            {

                amount20.Visible = true;
                amount20.Text = (calculate(Price20.Text, Convert.ToInt32(numericUpDown20.Value.ToString()))).ToString();

            }
            else
            {
                amount20.Visible = false;
                numericUpDown20.Value = 0;
            }

        }

        private void check_Leave(object sender, EventArgs e)
        {
            if (item1.Checked==false){
                amount1.Visible = false;
                numericUpDown1.Value = 0;
            }
            if (item2.Checked == false)
            {
                amount2.Visible = false;
                numericUpDown2.Value = 0;
            }
            if (item3.Checked == false)
            {
                amount3.Visible = false;
                numericUpDown3.Value = 0;
            }
            if (item4.Checked == false)
            {
                amount4.Visible = false;
                numericUpDown4.Value = 0;
            }
            if (item5.Checked == false)
            {
                amount5.Visible = false;
                numericUpDown5.Value = 0;
            }
            if (item6.Checked == false)
            {
                amount6.Visible = false;
                numericUpDown6.Value = 0;
            }
            if (item7.Checked == false)
            {
                amount7.Visible = false;
                numericUpDown7.Value = 0;
            }
            if (item8.Checked == false)
            {
                amount8.Visible = false;
                numericUpDown8.Value = 0;
            }
            if (item9.Checked == false)
            {
                amount9.Visible = false;
                numericUpDown9.Value = 0;
            }
            if (item10.Checked == false)
            {
                amount10.Visible = false;
                numericUpDown10.Value = 0;
            }
            if (item11.Checked == false)
            {
                amount11.Visible = false;
                numericUpDown11.Value = 0;
            }
            if (item12.Checked == false)
            {
                amount12.Visible = false;
                numericUpDown12.Value = 0;
            }
            if (item13.Checked == false)
            {
                amount13.Visible = false;
                numericUpDown13.Value = 0;
            }
            if (item14.Checked == false)
            {
                amount14.Visible = false;
                numericUpDown14.Value = 0;
            }
            if (item15.Checked == false)
            {
                amount15.Visible = false;
                numericUpDown15.Value = 0;
            }
            if (item16.Checked == false)
            {
                amount16.Visible = false;
                numericUpDown16.Value = 0;
            }
            if (item17.Checked == false)
            {
                amount17.Visible = false;
                numericUpDown17.Value = 0;
            }
            if (item18.Checked == false)
            {
                amount18.Visible = false;
                numericUpDown18.Value = 0;
            }
            if (item19.Checked == false)
            {
                amount19.Visible = false;
                numericUpDown19.Value = 0;
            }
            if (item20.Checked == false)
            {
                amount20.Visible = false;
                numericUpDown20.Value = 0;
            }
          
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (c.Visible == true) {
               // listBox1.Items.Add(c.Text );
                // listBox1.Items.Clear();
              //  c.Text.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to login again?","Login Again?", MessageBoxButtons.YesNo);
           LoginForm log = new LoginForm();
            if (d == DialogResult.Yes)
            {
                log.Show();
                this.Hide();



            }
            if (d == DialogResult.No)
            {
                this.Show();
                log.Hide();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

