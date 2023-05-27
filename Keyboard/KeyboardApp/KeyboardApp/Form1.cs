namespace KeyboardApp
{
    public partial class Form1 : Form
    {
        public bool cap = true;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonShift_Click(object sender, EventArgs e)
        {
            bool capShift = true;
            //A
            

            this.buttonA.Text = (this.buttonA.Text == "a") ? this.buttonA.Text.ToUpper() : this.buttonA.Text.ToLower();


            //B
            this.buttonB.Text = (this.buttonB.Text == "b") ? this.buttonB.Text.ToUpper() : this.buttonB.Text.ToLower();


            //C

            this.buttonC.Text = (this.buttonC.Text == "c") ? this.buttonC.Text.ToUpper() : this.buttonC.Text.ToLower();


            //D

            this.buttonD.Text = (this.buttonD.Text == "d") ? this.buttonD.Text.ToUpper() : this.buttonD.Text.ToLower();


            //E
            this.buttonE.Text = (this.buttonE.Text == "e") ? this.buttonE.Text.ToUpper() : this.buttonE.Text.ToLower();           

            //F

            this.buttonF.Text = (this.buttonF.Text == "f") ? this.buttonF.Text.ToUpper() : this.buttonF.Text.ToLower();

            //G

            this.buttonG.Text = (this.buttonG.Text == "g") ? this.buttonG.Text.ToUpper() : this.buttonG.Text.ToLower();

            //H

            this.buttonH.Text = (this.buttonH.Text == "h") ? this.buttonH.Text.ToUpper() : this.buttonH.Text.ToLower();

            //I

            this.buttonI.Text = (this.buttonI.Text == "i") ? this.buttonI.Text.ToUpper() : this.buttonI.Text.ToLower();

            //J

            this.buttonJ.Text = (this.buttonJ.Text == "j") ? this.buttonJ.Text.ToUpper() : this.buttonJ.Text.ToLower();

            //K

            this.buttonK.Text = (this.buttonK.Text == "k") ? this.buttonK.Text.ToUpper() : this.buttonK.Text.ToLower();

            //L

            this.buttonL.Text = (this.buttonL.Text == "l") ? this.buttonL.Text.ToUpper() : this.buttonL.Text.ToLower();

            //M

            this.buttonM.Text = (this.buttonM.Text == "m") ? this.buttonM.Text.ToUpper() : this.buttonM.Text.ToLower();

            //N

            this.buttonN.Text = (this.buttonN.Text == "n") ? this.buttonN.Text.ToUpper() : this.buttonN.Text.ToLower();

            //O

            this.buttonO.Text = (this.buttonO.Text == "o") ? this.buttonO.Text.ToUpper() : this.buttonO.Text.ToLower();

            //P
            this.buttonP.Text = (this.buttonP.Text == "p") ? this.buttonP.Text.ToUpper() : this.buttonP.Text.ToLower();

            //Q

            this.buttonQ.Text = (this.buttonQ.Text == "q") ? this.buttonQ.Text.ToUpper() : this.buttonQ.Text.ToLower();

            //R

            this.buttonR.Text = (this.buttonR.Text == "r") ? this.buttonR.Text.ToUpper() : this.buttonR.Text.ToLower();

            //S

            this.buttonS.Text = (this.buttonS.Text == "s") ? this.buttonS.Text.ToUpper() : this.buttonS.Text.ToLower();

            //T

            this.buttonT.Text = (this.buttonT.Text == "t") ? this.buttonT.Text.ToUpper() : this.buttonT.Text.ToLower();

            //U

            this.buttonU.Text = (this.buttonU.Text == "u") ? this.buttonU.Text.ToUpper() : this.buttonU.Text.ToLower();

            //V

            this.buttonV.Text = (this.buttonV.Text == "v") ? this.buttonV.Text.ToUpper() : this.buttonV.Text.ToLower();

            //W

            this.buttonW.Text = (this.buttonW.Text == "w") ? this.buttonW.Text.ToUpper() : this.buttonW.Text.ToLower();

            //X

            this.buttonX.Text = (this.buttonX.Text == "x") ? this.buttonX.Text.ToUpper() : this.buttonX.Text.ToLower();

            //Y

            this.buttonY.Text = (this.buttonY.Text == "y") ? this.buttonY.Text.ToUpper() : this.buttonY.Text.ToLower();

            //Z

            this.buttonZ.Text = (this.buttonZ.Text == "z") ? this.buttonZ.Text.ToUpper() : this.buttonZ.Text.ToLower();
           

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