namespace book
{
    partial class login
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
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 1003);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(67, 268);
            label6.Name = "label6";
            label6.Size = new Size(239, 77);
            label6.TabIndex = 10;
            label6.Text = "Geldiniz..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(18, 191);
            label5.Name = "label5";
            label5.Size = new Size(118, 77);
            label5.TabIndex = 9;
            label5.Text = "Hoş";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(378, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1563, 1003);
            panel1.TabIndex = 2;
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
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(11, 406);
            button1.Name = "button1";
            button1.Size = new Size(349, 58);
            button1.TabIndex = 3;
            button1.Text = "kullanıcılar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1937, 1027);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button button1;
    }
}