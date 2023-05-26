namespace KeyboardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (this.buttonA.Text == "a")
                this.textBox.Text += "a";
            else
                this.textBox.Text += "A";    
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            if (this.buttonA.Text == "a")
                this.buttonA.Text = "A";
            else
                this.buttonA.Text = "a";

            if (this.buttonZ.Text == "z")
                this.buttonZ.Text = "Z";
            else
                this.buttonZ.Text = "z";



            if (this.buttonQ.Text == "q")
                this.buttonQ.Text = "Q";
            else
                this.buttonQ.Text = "q";

        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (this.buttonZ.Text == "z")
                this.textBox.Text += "z";
            else
                this.textBox.Text += "Z";
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (this.buttonQ.Text == "q")
                this.textBox.Text += "q";
            else
                this.textBox.Text += "Q";
        }
    }
}