namespace WinFormsApp1
{
    public partial class LoginAndRegisterForm : Form
    {
        public LoginAndRegisterForm()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Color select_color = Color.FromArgb(49, 46, 49);
        private void button1_Click(object sender, EventArgs e)
        {
            panel1_SignIn.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2_SignUp.BringToFront();
            //button2_Click.BackColor=select_color;



        }

        private void panel2_SignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";

            textBox15.Text = "";
            textBox13.Text = "";

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.UseSystemPasswordChar = !checkBox1.Checked;
            textBox10.UseSystemPasswordChar = !checkBox1.Checked;


        }
    }
}
