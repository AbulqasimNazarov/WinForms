using System.Drawing.Drawing2D;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public List<Button> buttonNumberList = new List<Button>();
        public bool operationDevide = false;
        public bool operationMultiple = false;
        public bool operationPlus = false;
        public bool operationMinus = false;
        public double num1 = 0;
        public double num2 = 0;
        
        public Form1()
        {
            InitializeComponent();
            this.operationBox.Enabled = false;
            buttonNumberList.Add(this.button0);
            buttonNumberList.Add(this.button1);
            buttonNumberList.Add(this.button2);
            buttonNumberList.Add(this.button3);
            buttonNumberList.Add(this.button4);
            buttonNumberList.Add(this.button5);
            buttonNumberList.Add(this.button6);
            buttonNumberList.Add(this.button7);
            buttonNumberList.Add(this.button8);
            buttonNumberList.Add(this.button9);

            this.inputBox.Enabled = false;
            //this.inputBox.Visible = true;

            foreach (var item in this.buttonNumberList)            
                item.MouseClick += buttonClick;
            

            this.buttonAC.Click += (sender, e) =>
            {
                this.inputBox.Text = string.Empty;
                this.operationBox.Text = string.Empty;  
            };

            this.buttonplyuMinus.Click += (sender, e) =>
            {
                if (this.inputBox.Text[0] != '-')
                {
                    string addMinus = "-";
                    addMinus += this.inputBox.Text;
                    this.inputBox.Text = addMinus;
                }
                else
                    this.inputBox.Text = this.inputBox.Text[1..this.inputBox.Text.Length];               
            };

            this.buttonProcent.Click += (sender, e) =>
            {
                bool chekIsnum = double.TryParse(this.inputBox.Text, out double result);
                result = result / 100;
                this.inputBox.Text = Convert.ToString(result);
            };

            this.buttonDevide.Click += (sender, e) => {
                if (this.inputBox.Text != string.Empty)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " / ";
                    this.operationDevide = true;
                    this.inputBox.Text = string.Empty;
                }
            };

            this.buttonMultiple.Click += (sender, e) => 
            {
                if (this.inputBox.Text != string.Empty)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " * ";
                    this.operationMultiple = true;
                    this.inputBox.Text = string.Empty;
                }
            };

            this.buttonPlus.Click += (sender, e) =>
            {
                if (this.inputBox.Text != string.Empty)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " + ";
                    this.operationPlus = true;
                    this.inputBox.Text = string.Empty;
                }
            };

            this.buttonMinus.Click += (sender, e) =>
            {
                if (this.inputBox.Text != string.Empty)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " - ";
                    this.operationMinus = true;
                    this.inputBox.Text = string.Empty;
                }
            };


            this.buttonRavno.Click += (sender, e) =>
            {
                double res = 0;
                bool chekIsnum2 = double.TryParse(this.inputBox.Text, out this.num2);
                this.inputBox.Text = string.Empty;
                this.operationBox.Text += Convert.ToString(num2);
                if (this.operationDevide == true)
                {
                    res = num1 / num2;
                    this.operationDevide = false;
                }
                if (this.operationMultiple == true)
                {
                    res = num1 * num2;
                    this.operationMultiple = false;
                }
                if (this.operationPlus == true)
                {
                    res = num1 + num2;
                    this.operationPlus = false;
                }
                if (this.operationMinus == true)
                {
                    res = num1 - num2;
                    this.operationMinus = false;
                }
                this.operationBox.Text = string.Empty;
                this.inputBox.Text += Convert.ToString(res);
            };

        }



        public void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (this.inputBox.Text.Length <= 10)
                this.inputBox.Text += button.Text;
            else
                MessageBox.Show("Max size!");
            
        }       

    }
}