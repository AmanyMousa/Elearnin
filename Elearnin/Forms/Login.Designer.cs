namespace Elearnin.Properties
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            label2 = new Label();
            txt_Password = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
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
            pictureBox1.Size = new Size(332, 660);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 67, 76);
            label1.Location = new Point(469, 89);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 1;
            label1.Text = "SIGN IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 67, 76);
            label3.Location = new Point(386, 182);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(386, 230);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(343, 31);
            txt_email.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 67, 76);
            label2.Location = new Point(386, 303);
            label2.Name = "label2";
            label2.Size = new Size(126, 29);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(386, 356);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(343, 31);
            txt_Password.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(690, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 112, 126);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(450, 457);
            button1.Name = "button1";
            button1.Size = new Size(198, 66);
            button1.TabIndex = 8;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(108, 108, 108);
            label4.Location = new Point(401, 575);
            label4.Name = "label4";
            label4.Size = new Size(211, 22);
            label4.TabIndex = 9;
            label4.Text = "Don’t have an  Account? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9F);
            linkLabel1.ForeColor = Color.FromArgb(0, 67, 76);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(604, 575);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 22);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(386, 264);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(386, 390);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 660);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(txt_Password);
            Controls.Add(label2);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(0, 67, 76);
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGN IN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_Password;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label6;
    }
}