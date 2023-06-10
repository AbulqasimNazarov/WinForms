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
        public int clickDivideCount = 0;
        public int clickMultiplyCount = 0;
        public int clickPlusCount = 0;
        public int clickMinusCount = 0;

        public int Num1 { get; set; }
        public int Num2 { get; set; }


        public double res = 0;

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
                this.num1 = 0;
                this.num2 = 0;
                this.res = 0;
                this.clickDivideCount = 0;
                this.clickMultiplyCount = 0;
                this.clickPlusCount = 0;
                this.clickMinusCount = 0;
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

            this.buttonPercent.Click += (sender, e) =>
            {
                bool chekIsnum = double.TryParse(this.inputBox.Text, out double result);
                result = result / 100;
                this.inputBox.Text = Convert.ToString(result);
            };

            this.buttonDivide.Click += (sender, e) => {
                
                if (this.inputBox.Text != string.Empty && this.clickDivideCount == 0)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " / ";
                    this.operationDevide = true;
                    this.inputBox.Text = string.Empty;
                    this.clickDivideCount++;
                }
                else if(this.inputBox.Text != string.Empty && this.clickDivideCount > 0)
                {
                    bool chekIsnum2 = double.TryParse(this.inputBox.Text, out this.num2);
                    this.num1 /= num2;
                    this.operationBox.Text = $@"{this.num1} / ";
                    this.inputBox.Text = string.Empty;
                    this.clickDivideCount++;
                }
                else
                {
                    this.num1 /= this.num2;
                    this.operationBox.Text = $@"{this.num1} * ";
                    this.inputBox.Text = string.Empty;
                    this.clickDivideCount++;
                }
            };

            this.buttonMultiply.Click += (sender, e) =>
            {
                if (this.operationBox.Text == string.Empty && this.clickMultiplyCount == 0)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " * ";
                    this.operationMultiple = true;
                    this.inputBox.Text = string.Empty;
                    this.clickMultiplyCount++;
                }
                else if (this.inputBox.Text != string.Empty && this.clickMultiplyCount > 0)
                {
                    bool chekIsnum2 = double.TryParse(this.inputBox.Text, out this.num2);
                    this.num1 *= num2;
                    this.operationBox.Text = $@"{this.num1} * ";
                    this.inputBox.Text = string.Empty;
                    this.clickMultiplyCount++;
                }
                else
                {
                    this.num1 *= this.num2;
                    this.operationBox.Text = $@"{this.res} * ";
                    this.inputBox.Text = string.Empty;
                    this.clickMultiplyCount++;
                }
            };

            this.buttonPlus.Click += (sender, e) =>
            {


                if (this.operationBox.Text == string.Empty && this.clickPlusCount == 0)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " + ";
                    this.operationPlus = true;
                    this.inputBox.Text = string.Empty;
                    this.clickPlusCount++;
                }
                else if (this.inputBox.Text != string.Empty && this.clickPlusCount > 0)
                {
                    bool chekIsnum2 = double.TryParse(this.inputBox.Text, out this.num2);
                    this.num1 += num2;
                    this.operationBox.Text = $@"{this.num1} + ";
                    this.inputBox.Text = string.Empty;
                    this.clickPlusCount++;
                }
                else
                {
                    this.num1 += this.num2;
                    this.operationBox.Text = $@"{this.res} + ";
                    this.inputBox.Text = string.Empty;
                    this.clickPlusCount++;
                }
            };

            this.buttonMinus.Click += (sender, e) =>
            {
                if (this.operationBox.Text == string.Empty && this.clickMinusCount == 0)
                {
                    bool chekIsnum1 = double.TryParse(this.inputBox.Text, out this.num1);
                    this.operationBox.Text = this.inputBox.Text + " - ";
                    this.operationMinus = true;
                    this.inputBox.Text = string.Empty;
                    this.clickMinusCount++;
                }
                else if (this.inputBox.Text != string.Empty && this.clickMinusCount > 0)
                {
                    bool chekIsnum2 = double.TryParse(this.inputBox.Text, out this.num2);
                    this.num1 -= num2;
                    this.operationBox.Text = $@"{this.num1} - ";
                    this.inputBox.Text = string.Empty;
                    this.clickMinusCount++;
                }
            };

            this.buttonDot.Click += (sender, e) =>
            {
                if (this.inputBox.Text.Contains(".") == false)
                {
                    this.inputBox.Text += ".";
                }
            };


            this.buttonEquals.Click += (sender, e) =>
            {
                this.clickDivideCount = 0;
                this.clickPlusCount = 0;
                this.clickMultiplyCount = 0;
                bool chekIsnum2 = double.TryParse(this.inputBox.Text, out this.num2);
                this.inputBox.Text = string.Empty;
                this.operationBox.Text += $@"{num2}";
                //this.num1 = this.res;
                if (this.operationDevide == true)
                {
                    this.res = num1 / num2;
                    this.operationDevide = false;
                }
                if (this.operationMultiple == true)
                {
                    this.res = num1 * num2;
                    this.operationMultiple = false;
                }
                if (this.operationPlus == true)
                {
                    this.res = num1 + num2;
                    this.operationPlus = false;
                }
                if (this.operationMinus == true)
                {
                    this.res = num1 - num2;
                    this.operationMinus = false;
                }
                if (this.operationBox.Text.Contains('=') == false)
                {
                    this.operationBox.Text += $" = ";
                    this.inputBox.Text += Convert.ToString(res);

                }
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