using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

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
        public int operationCount = 0;
        


        public Form1()
        {
            InitializeComponent();
            this.operationBox.Enabled = false;
            buttonNumberList.AddRange(new[]
            {
                this.button0, this.button1, this.button2, this.button3, this.button4, this.button5, this.button6, this.button7, this.button8, this.button9
            });

            
            this.inputBox.Enabled = false;

            foreach (var item in this.buttonNumberList)
                item.MouseClick += buttonClick;


            this.buttonAC.Click += (sender, e) =>
            {
                this.inputBox.Text = string.Empty;
                this.operationBox.Text = string.Empty;
                
            };

            this.buttonPlusMinus.Click += (sender, e) =>
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

            this.buttonDot.Click += (sender, e) =>
            {
                if (this.inputBox.Text.Contains(".") == false)
                {
                    this.inputBox.Text += ".";
                }
            };

            this.buttonPercent.Click += (sender, e) =>
            {
                bool chekIsnum = double.TryParse(this.inputBox.Text, out double result);
                result = result / 100;
                this.inputBox.Text = Convert.ToString(result);
            };

            this.buttonMinus.Click += buttonOperation;
            this.buttonPlus.Click += buttonOperation;
            this.buttonDivide.Click += buttonOperation;
            this.buttonMultiply.Click += buttonOperation;


            this.buttonEquals.Click += (sender, e) =>
            {

                double num2 = double.Parse(this.inputBox.Text);
                this.inputBox.Text = string.Empty;
                if (this.operationMinus == true)
                {
                    double result = this.num1 - num2;
                    this.operationBox.Text = $"{this.num1} - {num2} = {result}";
                    this.operationMinus = false;
                }
                if (this.operationDevide == true)
                {
                    double result = this.num1 / num2;
                    this.operationBox.Text = $"{this.num1} / {num2} = {result}";
                    this.operationDevide = false;
                }
                if (this.operationMultiple == true)
                {
                    double result = this.num1 * num2;
                    this.operationBox.Text = $"{this.num1} * {num2} = {result}";
                    this.operationMultiple = false;
                }
                if (this.operationPlus)
                {
                    double result = this.num1 + num2;
                    this.operationBox.Text = $"{this.num1} + {num2} = {result}";
                    this.operationPlus = false;
                }
                this.historyBox.Items.Add(this.operationBox.Text);
                Valuess.SavetoList(this.operationBox.Text);
                Valuess.SaveJson();
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
        public void buttonOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.num1 = Convert.ToDouble(this.inputBox.Text);
            if (button.Text == "-")
            {               
                this.operationBox.Text = $"{this.num1} - ";
                this.inputBox.Text = string.Empty;
                this.operationMinus = true;
            }
            if (button.Text == "/")
            {
                this.operationBox.Text = $"{this.num1} / ";
                this.inputBox.Text = string.Empty;
                this.operationDevide = true;
            }
            if (button.Text == "+")
            {
                this.operationBox.Text = $"{this.num1} + ";
                this.inputBox.Text = string.Empty;
                this.operationPlus = true;
            }
            if (button.Text == "*")
            {
                this.operationBox.Text = $"{this.num1} * ";
                this.inputBox.Text = string.Empty;
                this.operationMultiple = true;
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var loadedjson = Valuess.LoadJson("historyBox.json");
            foreach (var item in loadedjson)
            {
                this.historyBox.Items.Add(item);
            }
        }
    }
}