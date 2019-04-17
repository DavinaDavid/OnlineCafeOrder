namespace VPLProject
{
    partial class ForgetPassForm
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
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.SetPassTxt = new System.Windows.Forms.TextBox();
            this.ConfrmPassTxt = new System.Windows.Forms.TextBox();
            this.Changebtn = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VPLProject.Properties.Resources.username;
            this.pictureBox1.Location = new System.Drawing.Point(374, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNameTxt.Location = new System.Drawing.Point(333, 215);
            this.UserNameTxt.Multiline = true;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(211, 32);
            this.UserNameTxt.TabIndex = 6;
            this.UserNameTxt.Text = "UserName";
            this.UserNameTxt.TextChanged += new System.EventHandler(this.UserNameTxt_TextChanged);
            this.UserNameTxt.Leave += new System.EventHandler(this.empty_Leave);
            this.UserNameTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserNameTxt_MouseUp);
            // 
            // CodeTxt
            // 
            this.CodeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CodeTxt.Location = new System.Drawing.Point(333, 262);
            this.CodeTxt.Multiline = true;
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.Size = new System.Drawing.Size(211, 32);
            this.CodeTxt.TabIndex = 7;
            this.CodeTxt.Text = "Code Received";
            this.CodeTxt.Leave += new System.EventHandler(this.empty_Leave);
            this.CodeTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CodeTxt_MouseUp);
            // 
            // SetPassTxt
            // 
            this.SetPassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SetPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPassTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SetPassTxt.Location = new System.Drawing.Point(333, 314);
            this.SetPassTxt.Multiline = true;
            this.SetPassTxt.Name = "SetPassTxt";
            this.SetPassTxt.Size = new System.Drawing.Size(211, 32);
            this.SetPassTxt.TabIndex = 8;
            this.SetPassTxt.Text = "Set Password";
            this.SetPassTxt.TextChanged += new System.EventHandler(this.SetPassTxt_TextChanged);
            this.SetPassTxt.Leave += new System.EventHandler(this.empty_Leave);
            this.SetPassTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetPassTxt_MouseUp);
            // 
            // ConfrmPassTxt
            // 
            this.ConfrmPassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConfrmPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfrmPassTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ConfrmPassTxt.Location = new System.Drawing.Point(333, 361);
            this.ConfrmPassTxt.Multiline = true;
            this.ConfrmPassTxt.Name = "ConfrmPassTxt";
            this.ConfrmPassTxt.Size = new System.Drawing.Size(211, 32);
            this.ConfrmPassTxt.TabIndex = 9;
            this.ConfrmPassTxt.Text = "Re-write Password";
            this.ConfrmPassTxt.TextChanged += new System.EventHandler(this.ConfrmPassTxt_TextChanged_1);
            this.ConfrmPassTxt.Leave += new System.EventHandler(this.empty_Leave);
            this.ConfrmPassTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfrmPassTxt_MouseUp);
            // 
            // Changebtn
            // 
            this.Changebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changebtn.Location = new System.Drawing.Point(354, 419);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(153, 34);
            this.Changebtn.TabIndex = 10;
            this.Changebtn.Text = "Change";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(568, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(587, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(1, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 131;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ForgetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPLProject.Properties.Resources.hotCoffee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.ConfrmPassTxt);
            this.Controls.Add(this.SetPassTxt);
            this.Controls.Add(this.CodeTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "ForgetPassForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Cafe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox CodeTxt;
        private System.Windows.Forms.TextBox SetPassTxt;
        private System.Windows.Forms.TextBox ConfrmPassTxt;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}