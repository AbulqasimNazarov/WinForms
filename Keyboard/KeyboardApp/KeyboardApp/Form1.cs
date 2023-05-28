namespace KeyboardApp
{
    public partial class Form1 : Form
    {
        
        public List<Button> buttonsList = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            buttonsList.Add(buttonA);
            buttonsList.Add(buttonB);
            buttonsList.Add(buttonC);
            buttonsList.Add(buttonD);
            buttonsList.Add(buttonE);
            buttonsList.Add(buttonF);
            buttonsList.Add(buttonG);
            buttonsList.Add(buttonH);
            buttonsList.Add(buttonI);
            buttonsList.Add(buttonJ);
            buttonsList.Add(buttonK);
            buttonsList.Add(buttonL);
            buttonsList.Add(buttonM);
            buttonsList.Add(buttonN);
            buttonsList.Add(buttonO);
            buttonsList.Add(buttonP);
            buttonsList.Add(buttonQ);
            buttonsList.Add(buttonR);
            buttonsList.Add(buttonS);
            buttonsList.Add(buttonT);
            buttonsList.Add(buttonU);
            buttonsList.Add(buttonV);
            buttonsList.Add(buttonW);
            buttonsList.Add(buttonX);
            buttonsList.Add(buttonY);
            buttonsList.Add(buttonZ);
        }

        
        private void buttonShift_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttonsList.Count; i++)
            {
                buttonsList[i].Text = (buttonsList[i].Text == buttonsList[i].Text.ToLower()) ? buttonsList[i].Text.ToUpper() : buttonsList[i].Text.ToLower();
                
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (this.buttonA.Text == "a")
                this.textBox.Text += "a";
            else
                this.textBox.Text += "A";
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
            else if (this.buttonQ.Text == "Q")
                this.textBox.Text += "Q";
            else
                this.textBox.Text += "1";
        }
        

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (this.buttonW.Text == "w")
                this.textBox.Text += "w";
            else if (this.buttonW.Text == "W")
                this.textBox.Text += "W";
            else
                this.textBox.Text += "2";
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (this.buttonS.Text == "s")
                this.textBox.Text += "s";
            else
                this.textBox.Text += "S";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (this.buttonX.Text == "x")
                this.textBox.Text += "x";
            else
                this.textBox.Text += "X";
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (this.buttonE.Text == "e")
                this.textBox.Text += "e";
            else if(this.buttonE.Text == "E")
                this.textBox.Text += "E";
            else
                this.textBox.Text += "3";
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (this.buttonD.Text == "d")
                this.textBox.Text += "d";
            else
                this.textBox.Text += "D";
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (this.buttonR.Text == "r")
                this.textBox.Text += "r";
            else if(this.buttonR.Text == "R")
                this.textBox.Text += "R";
            else
                this.textBox.Text += "4";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (this.buttonC.Text == "c")
                this.textBox.Text += "c";
            else
                this.textBox.Text += "C";
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (this.buttonT.Text == "t")
                this.textBox.Text += "t";
            else if(this.buttonT.Text == "T")
                this.textBox.Text += "T";
            else
                this.textBox.Text += "5";
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (this.buttonY.Text == "y")
                this.textBox.Text += "y";
            else if(this.buttonY.Text == "Y")
                this.textBox.Text += "Y";
            else
                this.textBox.Text += "6";
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (this.buttonU.Text == "u")
                this.textBox.Text += "u";
            else if (this.buttonU.Text == "U")
                this.textBox.Text += "U";
            else
                this.textBox.Text += "7";
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (this.buttonI.Text == "i")
                this.textBox.Text += "i";
            else if (this.buttonI.Text == "I")
                this.textBox.Text += "I";
            else
                this.textBox.Text += "8";
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (this.buttonO.Text == "o")
                this.textBox.Text += "o";
            else if (this.buttonO.Text == "O")
                this.textBox.Text += "O";
            else
                this.textBox.Text += "9";

        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (this.buttonF.Text == "f")
                this.textBox.Text += "f";
            else
                this.textBox.Text += "F";
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (this.buttonG.Text == "g")
                this.textBox.Text += "g";
            else
                this.textBox.Text += "G";
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (this.buttonH.Text == "h")
                this.textBox.Text += "h";
            else
                this.textBox.Text += "H";
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (this.textBox.Text.Length == 0)
            {
                return;
            }
            this.textBox.Text = this.textBox.Text.Substring(0, this.textBox.Text.Length - 1);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (this.buttonP.Text == "p")
                this.textBox.Text += "p";
            else if (this.buttonP.Text == "P")
                this.textBox.Text += "P";
            else
                this.textBox.Text += "0";
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            if (this.buttonJ.Text == "j")
                this.textBox.Text += "j";
            else
                this.textBox.Text += "J";
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (this.buttonK.Text == "k")
                this.textBox.Text += "k";
            else
                this.textBox.Text += "K";
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (this.buttonL.Text == "l")
                this.textBox.Text += "l";
            else
                this.textBox.Text += "L";
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (this.buttonV.Text == "v")
                this.textBox.Text += "v";
            else
                this.textBox.Text += "V";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (this.buttonB.Text == "b")
                this.textBox.Text += "b";
            else
                this.textBox.Text += "B";
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (this.buttonN.Text == "n")
                this.textBox.Text += "n";
            else
                this.textBox.Text += "N";
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (this.buttonM.Text == "m")
                this.textBox.Text += "m";
            else
                this.textBox.Text += "M";
        }

        private void buttonZapataya_Click(object sender, EventArgs e)
        {
            this.textBox.Text += ",";
        }

        private void buttonTochka_Click(object sender, EventArgs e)
        {
            this.textBox.Text += ".";
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "?";
        }

        private void buttonShift2_Click(object sender, EventArgs e)
        {
            this.buttonShift_Click(sender, EventArgs.Empty);
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            this.textBox.Text += " ";
        }

        private void buttonApastrof_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "'";
        }

        private void buttonBolwe_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "<";
        }

        private void buttonMenwe_Click(object sender, EventArgs e)
        {
            this.textBox.Text += ">";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            this.textBox.AppendText(Environment.NewLine);
        }

        private void buttonNumbers_Click(object sender, EventArgs e)
        {

            //Q
            if (this.buttonQ.Text == "q")
            {
                this.buttonQ.Text = "1";
            }
            else if (this.buttonQ.Text == "Q")
            {
                this.buttonQ.Text = "Q";
            }
            else
                this.buttonQ.Text = "q";
            //W
            if (this.buttonW.Text == "w")
            {
                this.buttonW.Text = "2";
            }
            else if (this.buttonW.Text == "W")
            {
                this.buttonW.Text = "W";
            }
            else
                this.buttonW.Text = "w";

            //E
            if (this.buttonE.Text == "e")
            {
                this.buttonE.Text = "3";
            }
            else if (this.buttonE.Text == "E")
            {
                this.buttonE.Text = "E";
            }
            else
                this.buttonE.Text = "e";
            //R
            if (this.buttonR.Text == "r")
            {
                this.buttonR.Text = "4";
            }
            else if (this.buttonR.Text == "R")
            {
                this.buttonR.Text = "R";
            }
            else
                this.buttonR.Text = "r";
            //T
            if (this.buttonT.Text == "t")
            {
                this.buttonT.Text = "5";
            }
            else if (this.buttonT.Text == "T")
            {
                this.buttonT.Text = "T";
            }
            else
                this.buttonT.Text = "t";
            //Y
            if (this.buttonY.Text == "y")
            {
                this.buttonY.Text = "6";
            }
            else if (this.buttonY.Text == "Y")
            {
                this.buttonY.Text = "Y";
            }
            else
                this.buttonY.Text = "y";



        }
    }
}