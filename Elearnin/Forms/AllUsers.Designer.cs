namespace Elearnin.Forms
{
    partial class AllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllUsers));
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            com_user = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            texName = new TextBox();
            txtemail = new TextBox();
            txtage = new TextBox();
            txtphone = new TextBox();
            labname = new Label();
            labemail = new Label();
            label4 = new Label();
            labage = new Label();
            panel1 = new Panel();
            label8 = new Label();
            texold = new TextBox();
            button3 = new Button();
            label7 = new Label();
            txtnew = new TextBox();
            label6 = new Label();
            txtconf = new TextBox();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            pass = new TextBox();
            conf = new TextBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(656, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 81);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 112, 126);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, 593);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 70);
            panel2.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-2, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(647, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // com_user
            // 
            com_user.FormattingEnabled = true;
            com_user.Location = new Point(228, 74);
            com_user.Name = "com_user";
            com_user.Size = new Size(194, 33);
            com_user.TabIndex = 15;
            com_user.SelectedIndexChanged += com_user_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 67, 76);
            label2.Location = new Point(115, 74);
            label2.Name = "label2";
            label2.Size = new Size(98, 37);
            label2.TabIndex = 14;
            label2.Text = "User:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(522, 215);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // texName
            // 
            texName.Location = new Point(228, 378);
            texName.Name = "texName";
            texName.Size = new Size(161, 31);
            texName.TabIndex = 17;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(225, 486);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(164, 31);
            txtemail.TabIndex = 18;
            // 
            // txtage
            // 
            txtage.Location = new Point(228, 434);
            txtage.Name = "txtage";
            txtage.Size = new Size(161, 31);
            txtage.TabIndex = 19;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(225, 531);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(164, 31);
            txtphone.TabIndex = 20;
            // 
            // labname
            // 
            labname.AutoSize = true;
            labname.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labname.ForeColor = Color.FromArgb(0, 67, 76);
            labname.Location = new Point(125, 384);
            labname.Name = "labname";
            labname.Size = new Size(97, 25);
            labname.TabIndex = 21;
            labname.Text = "FullName";
            // 
            // labemail
            // 
            labemail.AutoSize = true;
            labemail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labemail.ForeColor = Color.FromArgb(0, 67, 76);
            labemail.Location = new Point(131, 492);
            labemail.Name = "labemail";
            labemail.Size = new Size(61, 25);
            labemail.TabIndex = 22;
            labemail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 67, 76);
            label4.Location = new Point(131, 534);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 23;
            label4.Text = "Phone";
            // 
            // labage
            // 
            labage.AutoSize = true;
            labage.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labage.ForeColor = Color.FromArgb(0, 67, 76);
            labage.Location = new Point(131, 437);
            labage.Name = "labage";
            labage.Size = new Size(48, 25);
            labage.TabIndex = 24;
            labage.Text = "Age";
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
            panel1.Location = new Point(395, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 180);
            panel1.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(133, 133, 133);
            label8.Location = new Point(235, 136);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 39;
            label8.Text = "Show";
            label8.Click += label8_Click;
            // 
            // texold
            // 
            texold.Location = new Point(109, 6);
            texold.Name = "texold";
            texold.PasswordChar = '*';
            texold.Size = new Size(211, 31);
            texold.TabIndex = 35;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 67, 76);
            button3.Location = new Point(76, 124);
            button3.Name = "button3";
            button3.Size = new Size(114, 48);
            button3.TabIndex = 38;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 67, 76);
            label7.Location = new Point(15, 9);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 30;
            label7.Text = "Old:";
            // 
            // txtnew
            // 
            txtnew.Location = new Point(109, 43);
            txtnew.Name = "txtnew";
            txtnew.PasswordChar = '*';
            txtnew.Size = new Size(211, 31);
            txtnew.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 67, 76);
            label6.Location = new Point(15, 46);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 31;
            label6.Text = "New:";
            // 
            // txtconf
            // 
            txtconf.Location = new Point(109, 82);
            txtconf.Name = "txtconf";
            txtconf.PasswordChar = '*';
            txtconf.Size = new Size(211, 31);
            txtconf.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 67, 76);
            label3.Location = new Point(15, 88);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 32;
            label3.Text = "confirm:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(0, 67, 76);
            linkLabel2.Location = new Point(458, 378);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(168, 25);
            linkLabel2.TabIndex = 37;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Change Password";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(480, 108);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(65, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(548, 108);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(615, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(pass);
            panel3.Controls.Add(conf);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(401, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 150);
            panel3.TabIndex = 42;
            panel3.Paint += panel3_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(133, 133, 133);
            label9.Location = new Point(147, 111);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 40;
            label9.Text = "Show";
            label9.Click += label9_Click;
            // 
            // pass
            // 
            pass.Location = new Point(150, 13);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(169, 31);
            pass.TabIndex = 43;
            // 
            // conf
            // 
            conf.Location = new Point(150, 63);
            conf.Name = "conf";
            conf.PasswordChar = '*';
            conf.Size = new Size(169, 31);
            conf.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 67, 76);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 43;
            label1.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 67, 76);
            label5.Location = new Point(5, 63);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 44;
            label5.Text = "ConfPassword";
            // 
            // AllUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 660);
            Controls.Add(panel3);
            Controls.Add(pictureBox7);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(labage);
            Controls.Add(label4);
            Controls.Add(labemail);
            Controls.Add(labname);
            Controls.Add(txtphone);
            Controls.Add(txtage);
            Controls.Add(txtemail);
            Controls.Add(texName);
            Controls.Add(dataGridView1);
            Controls.Add(com_user);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Name = "AllUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllUsers";
            Load += AllUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private ComboBox com_user;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox texName;
        private TextBox txtemail;
        private TextBox txtage;
        private TextBox txtphone;
        private Label labname;
        private Label labemail;
        private Label label4;
        private Label labage;
        private Panel panel1;
        private Label label8;
        private LinkLabel linkLabel2;
        private TextBox texold;
        private Button button3;
        private Label label7;
        private TextBox txtnew;
        private Label label6;
        private TextBox txtconf;
        private Label label3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private Panel panel3;
        private TextBox pass;
        private TextBox conf;
        private Label label1;
        private Label label5;
        private Label label9;
    }
}