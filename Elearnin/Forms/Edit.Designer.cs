namespace Elearnin.Forms
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            txtphone = new TextBox();
            txtage = new TextBox();
            txtemail = new TextBox();
            txtname = new TextBox();
            texold = new TextBox();
            txtnew = new TextBox();
            txtconf = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            button3 = new Button();
            st_button1 = new Button();
            button4 = new Button();
            ad_button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 660);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(658, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 81);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 67, 76);
            label5.Location = new Point(407, 283);
            label5.Name = "label5";
            label5.Size = new Size(84, 30);
            label5.TabIndex = 23;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 67, 76);
            label4.Location = new Point(409, 223);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 22;
            label4.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 67, 76);
            label2.Location = new Point(406, 169);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 21;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 67, 76);
            label1.Location = new Point(404, 111);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 20;
            label1.Text = "FullName:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(0, 67, 76);
            linkLabel1.Location = new Point(463, 330);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(196, 30);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Change Password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(526, 284);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(211, 31);
            txtphone.TabIndex = 26;
            // 
            // txtage
            // 
            txtage.Location = new Point(526, 223);
            txtage.Name = "txtage";
            txtage.Size = new Size(211, 31);
            txtage.TabIndex = 27;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(526, 170);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(211, 31);
            txtemail.TabIndex = 28;
            // 
            // txtname
            // 
            txtname.Location = new Point(526, 112);
            txtname.Name = "txtname";
            txtname.Size = new Size(211, 31);
            txtname.TabIndex = 29;
            // 
            // texold
            // 
            texold.Location = new Point(120, 12);
            texold.Name = "texold";
            texold.PasswordChar = '*';
            texold.Size = new Size(211, 31);
            texold.TabIndex = 35;
            // 
            // txtnew
            // 
            txtnew.Location = new Point(120, 54);
            txtnew.Name = "txtnew";
            txtnew.PasswordChar = '*';
            txtnew.Size = new Size(211, 31);
            txtnew.TabIndex = 34;
            // 
            // txtconf
            // 
            txtconf.Location = new Point(120, 106);
            txtconf.Name = "txtconf";
            txtconf.PasswordChar = '*';
            txtconf.Size = new Size(211, 31);
            txtconf.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 67, 76);
            label3.Location = new Point(3, 105);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 32;
            label3.Text = "confirm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 67, 76);
            label6.Location = new Point(6, 55);
            label6.Name = "label6";
            label6.Size = new Size(66, 30);
            label6.TabIndex = 31;
            label6.Text = "New:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 67, 76);
            label7.Location = new Point(0, 13);
            label7.Name = "label7";
            label7.Size = new Size(56, 30);
            label7.TabIndex = 30;
            label7.Text = "Old:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(texold);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtnew);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtconf);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(403, 363);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 206);
            panel1.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(133, 133, 133);
            label8.Location = new Point(255, 155);
            label8.Name = "label8";
            label8.Size = new Size(69, 30);
            label8.TabIndex = 39;
            label8.Text = "Show";
            label8.Click += label8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 67, 76);
            button3.Location = new Point(111, 143);
            button3.Name = "button3";
            button3.Size = new Size(114, 55);
            button3.TabIndex = 38;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // st_button1
            // 
            st_button1.BackColor = Color.FromArgb(0, 67, 76);
            st_button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            st_button1.ForeColor = Color.White;
            st_button1.Location = new Point(424, 593);
            st_button1.Name = "st_button1";
            st_button1.Size = new Size(114, 55);
            st_button1.TabIndex = 36;
            st_button1.Text = "Back";
            st_button1.UseVisualStyleBackColor = false;
            st_button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 67, 76);
            button4.Location = new Point(605, 593);
            button4.Name = "button4";
            button4.Size = new Size(114, 55);
            button4.TabIndex = 39;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ad_button1
            // 
            ad_button1.BackColor = Color.FromArgb(0, 67, 76);
            ad_button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ad_button1.ForeColor = Color.White;
            ad_button1.Location = new Point(424, 593);
            ad_button1.Name = "ad_button1";
            ad_button1.Size = new Size(114, 55);
            ad_button1.TabIndex = 40;
            ad_button1.Text = "Back";
            ad_button1.UseVisualStyleBackColor = false;
            ad_button1.Click += ad_button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(436, 141);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(436, 199);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 42;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 660);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(ad_button1);
            Controls.Add(button4);
            Controls.Add(st_button1);
            Controls.Add(panel1);
            Controls.Add(txtname);
            Controls.Add(txtemail);
            Controls.Add(txtage);
            Controls.Add(txtphone);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += Edit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txtphone;
        private TextBox txtage;
        private TextBox txtemail;
        private TextBox txtname;
        private TextBox texold;
        private TextBox txtnew;
        private TextBox txtconf;
        private Label label3;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button st_button1;
        private Button button3;
        private Button button4;
        private Label label8;
        private Button ad_button1;
        private Label label9;
        private Label label10;
    }
}