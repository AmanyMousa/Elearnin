namespace Elearnin.Forms
{
    partial class AllCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCourse));
            dataGridView1 = new DataGridView();
            com_cat = new ComboBox();
            label2 = new Label();
            labage = new Label();
            label4 = new Label();
            labemail = new Label();
            labname = new Label();
            txtdesc = new TextBox();
            txtTitel = new TextBox();
            comboBox1 = new ComboBox();
            txtdura = new TextBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(178, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(385, 219);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // com_cat
            // 
            com_cat.FormattingEnabled = true;
            com_cat.Location = new Point(353, 87);
            com_cat.Name = "com_cat";
            com_cat.Size = new Size(193, 33);
            com_cat.TabIndex = 17;
            com_cat.SelectedIndexChanged += com_cat_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 67, 76);
            label2.Location = new Point(156, 81);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 16;
            label2.Text = "Categories:";
            // 
            // labage
            // 
            labage.AutoSize = true;
            labage.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labage.ForeColor = Color.FromArgb(0, 67, 76);
            labage.Location = new Point(65, 516);
            labage.Name = "labage";
            labage.Size = new Size(116, 25);
            labage.TabIndex = 32;
            labage.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 67, 76);
            label4.Location = new Point(397, 516);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 31;
            label4.Text = "Instructor_Name";
            // 
            // labemail
            // 
            labemail.AutoSize = true;
            labemail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labemail.ForeColor = Color.FromArgb(0, 67, 76);
            labemail.Location = new Point(397, 448);
            labemail.Name = "labemail";
            labemail.Size = new Size(91, 25);
            labemail.TabIndex = 30;
            labemail.Text = "Duration";
            labemail.Click += labemail_Click;
            // 
            // labname
            // 
            labname.AutoSize = true;
            labname.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labname.ForeColor = Color.FromArgb(0, 67, 76);
            labname.Location = new Point(65, 448);
            labname.Name = "labname";
            labname.Size = new Size(53, 25);
            labname.TabIndex = 29;
            labname.Text = "Titel";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(211, 495);
            txtdesc.Multiline = true;
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(178, 70);
            txtdesc.TabIndex = 27;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(211, 445);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(178, 31);
            txtTitel.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(563, 513);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 33);
            comboBox1.TabIndex = 33;
            // 
            // txtdura
            // 
            txtdura.Location = new Point(558, 448);
            txtdura.Name = "txtdura";
            txtdura.Size = new Size(158, 31);
            txtdura.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 112, 126);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(1, 585);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 70);
            panel2.TabIndex = 35;
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
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(658, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 81);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(314, 161);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(65, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 44;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(247, 161);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 43;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(179, 161);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // AllCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 660);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(txtdura);
            Controls.Add(comboBox1);
            Controls.Add(labage);
            Controls.Add(label4);
            Controls.Add(labemail);
            Controls.Add(labname);
            Controls.Add(txtdesc);
            Controls.Add(txtTitel);
            Controls.Add(dataGridView1);
            Controls.Add(com_cat);
            Controls.Add(label2);
            Name = "AllCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllCourse";
            Load += AllCourse_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        protected internal ComboBox com_cat;
        private Label label2;
        private Label labage;
        private Label label4;
        private Label labemail;
        private Label labname;
        private TextBox txtdesc;
        private TextBox txtTitel;
        private ComboBox comboBox1;
        private TextBox txtdura;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
    }
}