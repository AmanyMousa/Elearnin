namespace Elearnin.Properties
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            txt_pass = new TextBox();
            label2 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txt_name = new TextBox();
            label5 = new Label();
            txt_age = new TextBox();
            label6 = new Label();
            txt_phone = new TextBox();
            label7 = new Label();
            txtconf = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 660);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9F);
            linkLabel1.ForeColor = Color.FromArgb(0, 67, 76);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(638, 629);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 22);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(108, 108, 108);
            label4.Location = new Point(402, 629);
            label4.Name = "label4";
            label4.Size = new Size(230, 22);
            label4.TabIndex = 18;
            label4.Text = "Already have an  Account? ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 112, 126);
            button1.ForeColor = Color.White;
            button1.Location = new Point(443, 559);
            button1.Name = "button1";
            button1.Size = new Size(198, 66);
            button1.TabIndex = 17;
            button1.Text = "Sing Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(693, 320);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(378, 286);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(343, 31);
            txt_pass.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 67, 76);
            label2.Location = new Point(376, 248);
            label2.Name = "label2";
            label2.Size = new Size(126, 29);
            label2.TabIndex = 14;
            label2.Text = "Password:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(376, 207);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(343, 31);
            txt_email.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 67, 76);
            label3.Location = new Point(378, 170);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 67, 76);
            label1.Location = new Point(465, 39);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 11;
            label1.Text = "SIGN UP";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(376, 133);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(343, 31);
            txt_name.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 67, 76);
            label5.Location = new Point(378, 94);
            label5.Name = "label5";
            label5.Size = new Size(124, 29);
            label5.TabIndex = 20;
            label5.Text = "FullName:";
            // 
            // txt_age
            // 
            txt_age.Location = new Point(378, 513);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(343, 31);
            txt_age.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 67, 76);
            label6.Location = new Point(380, 481);
            label6.Name = "label6";
            label6.Size = new Size(62, 29);
            label6.TabIndex = 22;
            label6.Text = "Age:";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(376, 437);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(343, 31);
            txt_phone.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 67, 76);
            label7.Location = new Point(378, 398);
            label7.Name = "label7";
            label7.Size = new Size(89, 29);
            label7.TabIndex = 24;
            label7.Text = "Phone:";
            // 
            // txtconf
            // 
            txtconf.Location = new Point(376, 357);
            txtconf.Name = "txtconf";
            txtconf.PasswordChar = '*';
            txtconf.Size = new Size(343, 31);
            txtconf.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 67, 76);
            label8.Location = new Point(378, 325);
            label8.Name = "label8";
            label8.Size = new Size(189, 29);
            label8.TabIndex = 26;
            label8.Text = "Conf_Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(483, 156);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(519, 248);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(465, 471);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 30;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 660);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtconf);
            Controls.Add(label8);
            Controls.Add(txt_phone);
            Controls.Add(label7);
            Controls.Add(txt_age);
            Controls.Add(label6);
            Controls.Add(txt_name);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox2;
        private TextBox txt_pass;
        private Label label2;
        private TextBox txt_email;
        private Label label3;
        private Label label1;
        private TextBox txt_name;
        private Label label5;
        private TextBox txt_age;
        private Label label6;
        private TextBox txt_phone;
        private Label label7;
        private TextBox txtconf;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}