namespace WinFormsApp1
{
    partial class LoginAndRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAndRegisterForm));
            signUp = new Button();
            label1 = new Label();
            signIn = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            panel1_SignIn = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox10 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            panel2_SignUp = new Panel();
            label5 = new Label();
            label4 = new Label();
            textBox13 = new TextBox();
            textBox15 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            panel1_SignIn.SuspendLayout();
            panel2_SignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signUp
            // 
            signUp.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUp.Location = new Point(469, 21);
            signUp.Margin = new Padding(2);
            signUp.Name = "signUp";
            signUp.Size = new Size(98, 36);
            signUp.TabIndex = 0;
            signUp.Text = "Sign Up";
            signUp.UseVisualStyleBackColor = true;
            signUp.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(189, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 26);
            label1.TabIndex = 1;
            label1.Text = "Engineering Student Project";
            label1.Click += label1_Click;
            // 
            // signIn
            // 
            signIn.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signIn.Location = new Point(394, 21);
            signIn.Margin = new Padding(2);
            signIn.Name = "signIn";
            signIn.Size = new Size(71, 36);
            signIn.TabIndex = 2;
            signIn.Text = "Sign In";
            signIn.UseVisualStyleBackColor = true;
            signIn.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 502);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 3;
            label2.Text = "@copyrights reseved";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 8);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(342, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 50);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(342, 27);
            textBox4.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(130, 216);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(410, 44);
            button3.TabIndex = 8;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1_SignIn
            // 
            panel1_SignIn.BackColor = Color.Transparent;
            panel1_SignIn.Controls.Add(label10);
            panel1_SignIn.Controls.Add(label9);
            panel1_SignIn.Controls.Add(label8);
            panel1_SignIn.Controls.Add(label7);
            panel1_SignIn.Controls.Add(label6);
            panel1_SignIn.Controls.Add(textBox10);
            panel1_SignIn.Controls.Add(textBox8);
            panel1_SignIn.Controls.Add(textBox4);
            panel1_SignIn.Controls.Add(textBox7);
            panel1_SignIn.Controls.Add(textBox3);
            panel1_SignIn.Controls.Add(button3);
            panel1_SignIn.Location = new Point(0, 212);
            panel1_SignIn.Margin = new Padding(2);
            panel1_SignIn.Name = "panel1_SignIn";
            panel1_SignIn.Size = new Size(681, 262);
            panel1_SignIn.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.ForeColor = Color.White;
            label10.Location = new Point(51, 176);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 14;
            label10.Text = "ConfirmPassword";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.ForeColor = Color.White;
            label9.Location = new Point(51, 133);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 13;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.ForeColor = Color.White;
            label8.Location = new Point(51, 92);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 12;
            label8.Text = "UserName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 50);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 11;
            label7.Text = "LastName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 8);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 10;
            label6.Text = "FirstName";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(259, 176);
            textBox10.Margin = new Padding(2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(342, 27);
            textBox10.TabIndex = 7;
            textBox10.UseSystemPasswordChar = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(259, 134);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(342, 27);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(259, 92);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(342, 27);
            textBox7.TabIndex = 6;
            // 
            // panel2_SignUp
            // 
            panel2_SignUp.BackColor = Color.Transparent;
            panel2_SignUp.Controls.Add(label5);
            panel2_SignUp.Controls.Add(label4);
            panel2_SignUp.Controls.Add(textBox13);
            panel2_SignUp.Controls.Add(textBox15);
            panel2_SignUp.Controls.Add(button4);
            panel2_SignUp.Location = new Point(-11, 163);
            panel2_SignUp.Margin = new Padding(2);
            panel2_SignUp.Name = "panel2_SignUp";
            panel2_SignUp.Size = new Size(690, 311);
            panel2_SignUp.TabIndex = 10;
            panel2_SignUp.Paint += panel2_SignUp_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 134);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 92);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(259, 134);
            textBox13.Margin = new Padding(2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(342, 27);
            textBox13.TabIndex = 7;
            textBox13.UseSystemPasswordChar = true;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(259, 92);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(342, 27);
            textBox15.TabIndex = 6;
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(130, 204);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(410, 44);
            button4.TabIndex = 8;
            button4.Text = "Sign In";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label3.Location = new Point(259, 122);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 26);
            label3.TabIndex = 11;
            label3.Text = "Management";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(583, 21);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 26);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(380, 482);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(106, 27);
            button1.TabIndex = 9;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(143, 482);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginAndRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(626, 520);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(signIn);
            Controls.Add(label1);
            Controls.Add(signUp);
            Controls.Add(panel2_SignUp);
            Controls.Add(panel1_SignIn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginAndRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1_SignIn.ResumeLayout(false);
            panel1_SignIn.PerformLayout();
            panel2_SignUp.ResumeLayout(false);
            panel2_SignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUp;
        private Label label1;
        private Button signIn;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Panel panel1_SignIn;
        private TextBox textBox10;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label3;
        private Panel panel2_SignUp;
        private TextBox textBox13;
        private TextBox textBox15;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button1;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
