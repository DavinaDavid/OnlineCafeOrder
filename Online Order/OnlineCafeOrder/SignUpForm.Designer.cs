namespace VPLProject
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.SetPassTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.CellTxt = new System.Windows.Forms.TextBox();
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VPLProject.Properties.Resources.SgnUp;
            this.pictureBox1.Location = new System.Drawing.Point(368, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNameTxt.Location = new System.Drawing.Point(328, 188);
            this.UserNameTxt.Multiline = true;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(211, 32);
            this.UserNameTxt.TabIndex = 1;
            this.UserNameTxt.Text = "UserName";
            this.UserNameTxt.Leave += new System.EventHandler(this.check_Leave);
            this.UserNameTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserNameTxt_MouseUp);
            // 
            // SetPassTxt
            // 
            this.SetPassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SetPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPassTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SetPassTxt.Location = new System.Drawing.Point(328, 239);
            this.SetPassTxt.Multiline = true;
            this.SetPassTxt.Name = "SetPassTxt";
            this.SetPassTxt.Size = new System.Drawing.Size(211, 32);
            this.SetPassTxt.TabIndex = 2;
            this.SetPassTxt.Text = "Set Password";
            this.SetPassTxt.TextChanged += new System.EventHandler(this.SetPassTxt_TextChanged);
            this.SetPassTxt.Leave += new System.EventHandler(this.check_Leave);
            this.SetPassTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetPassTxt_MouseUp);
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddressTxt.Location = new System.Drawing.Point(328, 292);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(211, 32);
            this.AddressTxt.TabIndex = 3;
            this.AddressTxt.Text = "Address";
            this.AddressTxt.Leave += new System.EventHandler(this.check_Leave);
            this.AddressTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddressTxt_MouseUp);
            // 
            // EmailTxt
            // 
            this.EmailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EmailTxt.Location = new System.Drawing.Point(328, 349);
            this.EmailTxt.Multiline = true;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(211, 32);
            this.EmailTxt.TabIndex = 4;
            this.EmailTxt.Text = "Email";
            this.EmailTxt.Click += new System.EventHandler(this.EmailText_Click);
            this.EmailTxt.TextChanged += new System.EventHandler(this.EmailTxt_TextChanged);
            this.EmailTxt.Leave += new System.EventHandler(this.check_Leave);
            this.EmailTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmailTxt_MouseDown);
            this.EmailTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmailTxt_MouseUp);
            // 
            // loginbtn
            // 
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(380, 448);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(93, 34);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "SignUp";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // CellTxt
            // 
            this.CellTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CellTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CellTxt.Location = new System.Drawing.Point(328, 397);
            this.CellTxt.Multiline = true;
            this.CellTxt.Name = "CellTxt";
            this.CellTxt.Size = new System.Drawing.Size(211, 32);
            this.CellTxt.TabIndex = 7;
            this.CellTxt.Text = "Cell No";
            this.CellTxt.Leave += new System.EventHandler(this.check_Leave);
            this.CellTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CellTxt_MouseUp);
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(578, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(578, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 131;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPLProject.Properties.Resources.hotCoffee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CellTxt);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.SetPassTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Cafe";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox SetPassTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox CellTxt;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}