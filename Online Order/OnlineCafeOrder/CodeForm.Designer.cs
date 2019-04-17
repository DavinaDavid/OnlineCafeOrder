namespace VPLProject
{
    partial class CodeForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginMenubtn = new System.Windows.Forms.Button();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(-180, -88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 140;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(271, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 139;
            // 
            // loginMenubtn
            // 
            this.loginMenubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginMenubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMenubtn.Location = new System.Drawing.Point(389, 356);
            this.loginMenubtn.Name = "loginMenubtn";
            this.loginMenubtn.Size = new System.Drawing.Size(93, 34);
            this.loginMenubtn.TabIndex = 137;
            this.loginMenubtn.Text = "Send Code";
            this.loginMenubtn.UseVisualStyleBackColor = true;
            this.loginMenubtn.Click += new System.EventHandler(this.loginMenubtn_Click);
            // 
            // phoneNum
            // 
            this.phoneNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneNum.Location = new System.Drawing.Point(317, 282);
            this.phoneNum.MaxLength = 3276987;
            this.phoneNum.Multiline = true;
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(224, 32);
            this.phoneNum.TabIndex = 135;
            this.phoneNum.Text = "Phone Number to have Code";
            this.phoneNum.Leave += new System.EventHandler(this.Check_Leave);
            this.phoneNum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phoneNum_MouseUp);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNameTxt.Location = new System.Drawing.Point(317, 218);
            this.UserNameTxt.Multiline = true;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(224, 32);
            this.UserNameTxt.TabIndex = 134;
            this.UserNameTxt.Text = "UserName";
            this.UserNameTxt.Leave += new System.EventHandler(this.Check_Leave);
            this.UserNameTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserNameTxt_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VPLProject.Properties.Resources.username;
            this.pictureBox1.Location = new System.Drawing.Point(377, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 141;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPLProject.Properties.Resources.hotCoffee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginMenubtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.UserNameTxt);
            this.Name = "CodeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Cafe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginMenubtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider error1;
    }
}