using System.Drawing.Drawing2D;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private List<Button> buttonNumberList = new List<Button>();
        private bool operationDivide = false;
        private bool operationMultiply = false;
        private bool operationPlus = false;
        private bool operationMinus = false;
        private double num1 = 0;
        private double num2 = 0;
        private double res = 0;

        public Form1()
        {
            InitializeComponent();
            this.operationBox.Enabled = false;
            buttonNumberList.AddRange(new[]
            {
                button0, button1, button2, button3, button4, button5, button6, button7, button8, button9
            });

            this.inputBox.Enabled = false;

            foreach (var item in this.buttonNumberList)
            {
                item.MouseClick += buttonClick;
            }

            this.buttonAC.Click += (sender, e) =>
            {
                this.inputBox.Text = string.Empty;
                this.operationBox.Text = string.Empty;
            };

            this.buttonPlusMinus.Click += (sender, e) =>
            {
                if (this.inputBox.Text.StartsWith("-"))
                {
                    this.inputBox.Text = this.inputBox.Text.Substring(1);
                }
                else
                {
                    this.inputBox.Text = "-" + this.inputBox.Text;
                }
            };

            this.buttonPercent.Click += (sender, e) =>
            {
                if (double.TryParse(this.inputBox.Text, out double result))
                {
                    result = result / 100;
                    this.inputBox.Text = result.ToString();
                }
            };

            this.buttonDivide.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(this.inputBox.Text))
                {
                    if (double.TryParse(this.inputBox.Text, out this.num1))
                    {
                        if (this.operationBox.Text == string.Empty)
                        {
                            this.operationBox.Text = this.inputBox.Text + " / ";
                            //this.operationDivide = true;
                            this.inputBox.Text = string.Empty;
                            this.res = this.num1;
                        }
                        else
                        {
                            if (double.TryParse(this.inputBox.Text, out this.num2))
                            {
                                if (this.num2 != 0)
                                {
                                    this.res /= this.num2;
                                    this.operationBox.Text = $"{this.res} / ";
                                    this.inputBox.Text = string.Empty;
                                }
                                else
                                {
                                    MessageBox.Show("Division by zero is not allowed.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid number format.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid number format.");
                    }
                }
            };

            this.buttonMultiply.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(this.inputBox.Text))
                {
                    if (double.TryParse(this.inputBox.Text, out this.num1))
                    {
                        if (this.operationBox.Text == string.Empty)
                        {
                            this.operationBox.Text = this.inputBox.Text + " * ";
                            this.operationMultiply = true;
                            this.inputBox.Text = string.Empty;
                            this.res = this.num1;
                        }
                        else
                        {
                            if (double.TryParse(this.inputBox.Text, out this.num2))
                            {
                                this.res *= this.num2;
                                this.operationBox.Text = $"{this.res} * ";
                                this.inputBox.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Invalid number format.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid number format.");
                    }
                }
            };

            this.buttonPlus.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(this.inputBox.Text))
                {
                    if (double.TryParse(this.inputBox.Text, out this.num1))
                    {
                        if (this.operationBox.Text == string.Empty)
                        {
                            this.operationBox.Text = this.inputBox.Text + " + ";
                            this.operationPlus = true;
                            this.inputBox.Text = string.Empty;
                            this.res = this.num1;
                        }
                        else
                        {
                            if (double.TryParse(this.inputBox.Text, out this.num2))
                            {
                                this.res += this.num2;
                                this.operationBox.Text = $"{this.res} + ";
                                this.inputBox.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Invalid number format.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid number format.");
                    }
                }
            };

            this.buttonMinus.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(this.inputBox.Text))
                {
                    if (double.TryParse(this.inputBox.Text, out this.num1))
                    {
                        if (this.operationBox.Text == string.Empty)
                        {
                            this.operationBox.Text = this.inputBox.Text + " - ";
                            this.operationMinus = true;
                            this.inputBox.Text = string.Empty;
                            this.res = this.num1;
                        }
                        else
                        {
                            if (double.TryParse(this.inputBox.Text, out this.num2))
                            {
                                this.res -= this.num2;
                                this.operationBox.Text = $"{this.res} - ";
                                this.inputBox.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Invalid number format.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid number format.");
                    }
                }
            };

            this.buttonDot.Click += (sender, e) =>
            {
                if (!this.inputBox.Text.Contains("."))
                {
                    this.inputBox.Text += ".";
                }
            };

            int equalsClickCount = 0;

            this.buttonEquals.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(this.inputBox.Text))
                {
                    if (double.TryParse(this.inputBox.Text, out this.num2))
                    {
                        this.inputBox.Text = string.Empty;
                        this.operationBox.Text += this.num2;
                        this.num1 = this.res;

                        if (this.operationDivide)
                        {
                            if (this.num2 != 0)
                            {
                                this.res /= this.num2;
                                this.operationDivide = false;
                            }
                            else
                            {
                                MessageBox.Show("Division by zero is not allowed.");
                                return;
                            }
                        }

                        if (this.operationMultiply)
                        {
                            this.res *= this.num2;
                            this.operationMultiply = false;
                        }

                        if (this.operationPlus)
                        {
                            this.res += this.num2;
                            this.operationPlus = false;
                        }

                        if (this.operationMinus)
                        {
                            this.res -= this.num2;
                            this.operationMinus = false;
                        }

                        if (equalsClickCount >= 2)
                        {
                            this.operationBox.Text = this.res.ToString();
                        }
                        else
                        {
                            this.operationBox.Text = string.Empty;
                            this.operationBox.Text += this.res.ToString();
                            this.operationBox.Text += $" - {this.num2} = ";
                        }

                        this.inputBox.Text = this.res.ToString();
                        equalsClickCount++;
                    }
                    else
                    {
                        MessageBox.Show("Invalid number format.");
                    }
                }
            };
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (this.inputBox.Text.Length <= 10)
            {
                this.inputBox.Text += button.Text;
            }
            else
            {
                MessageBox.Show("Max size!");
            }
        }
    }
}