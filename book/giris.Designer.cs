namespace book
{
    partial class giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            panel1 = new Panel();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(485, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 666);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.GreenYellow;
            button2.Location = new Point(385, 526);
            button2.Name = "button2";
            button2.Size = new Size(196, 77);
            button2.TabIndex = 12;
            button2.Text = "Giriş ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "helin ", "lokmna", "rodi" });
            comboBox1.Location = new Point(363, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 40);
            comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(703, -3);
            label7.Name = "label7";
            label7.Size = new Size(64, 77);
            label7.TabIndex = 9;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(422, 606);
            label4.Name = "label4";
            label4.Size = new Size(123, 53);
            label4.TabIndex = 8;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(175, 398);
            label3.Name = "label3";
            label3.Size = new Size(132, 62);
            label3.TabIndex = 6;
            label3.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 285);
            label2.Name = "label2";
            label2.Size = new Size(274, 62);
            label2.TabIndex = 5;
            label2.Text = "Kullanıcı Adı :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Banner", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(319, 398);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 74);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Banner", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(319, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 74);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 39);
            label1.Name = "label1";
            label1.Size = new Size(406, 77);
            label1.TabIndex = 1;
            label1.Text = "Kütüphane Girişi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(119, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 666);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(230, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 100);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1251, 671);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}