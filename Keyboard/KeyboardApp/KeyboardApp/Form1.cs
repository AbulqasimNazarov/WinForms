namespace KeyboardApp
{
    public partial class Form1 : Form
    {
        public bool cap = true;
        public List<Button> buttonsList = new List<Button>();
        public List<string> emojies = new List<string>();
        public Form1()
        {
            InitializeComponent();
            emojies.Add("☯");
            emojies.Add("✌️");
            emojies.Add("✈");
            emojies.Add("☎");
            emojies.Add("♚");
            emojies.Add("❤️");
            emojies.Add("♓");
            emojies.Add("☠");
            emojies.Add("💯");
            emojies.Add("⌚");
            emojies.Add("⌛");
            emojies.Add("😘");
            emojies.Add("😍");
            emojies.Add("🤠");
            emojies.Add("🦷");
            emojies.Add("🎻");
            emojies.Add("🎼");
            emojies.Add("🥂");
            emojies.Add("🧷️");
            emojies.Add("🌷");
            emojies.Add("⚧️");
            emojies.Add("🍕");
            emojies.Add("🦈");
            emojies.Add("🐴");
            emojies.Add("👐");
            emojies.Add("⛸");
            buttonsList.Add(buttonA); //0
            buttonsList.Add(buttonB);  //1
            buttonsList.Add(buttonC);  //2
            buttonsList.Add(buttonD);  //3
            buttonsList.Add(buttonE);  //4
            buttonsList.Add(buttonF);  //5
            buttonsList.Add(buttonG);  //6
            buttonsList.Add(buttonH);  //7
            buttonsList.Add(buttonI);  //8
            buttonsList.Add(buttonJ);  //9
            buttonsList.Add(buttonK);  //10
            buttonsList.Add(buttonL);  //11
            buttonsList.Add(buttonM);  //12
            buttonsList.Add(buttonN);  //13
            buttonsList.Add(buttonO);  //14
            buttonsList.Add(buttonP);  //15
            buttonsList.Add(buttonQ); //16
            buttonsList.Add(buttonR); //17
            buttonsList.Add(buttonS);  //18
            buttonsList.Add(buttonT);  //19
            buttonsList.Add(buttonU);  //20
            buttonsList.Add(buttonV);  //21
            buttonsList.Add(buttonW);  //22
            buttonsList.Add(buttonX);  //23
            buttonsList.Add(buttonY);  //24
            buttonsList.Add(buttonZ);  //25
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
            else if (this.buttonA.Text == "A")
                this.textBox.Text += "A";
            else
                this.textBox.Text += emojies[0];
        }


        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (this.buttonZ.Text == "z")
                this.textBox.Text += "z";
            else if (this.buttonZ.Text == "Z")
                this.textBox.Text += "Z";
            else
                this.textBox.Text += emojies[25];
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (this.buttonQ.Text == "q")
                this.textBox.Text += "q";
            else if (this.buttonQ.Text == "Q")
                this.textBox.Text += "Q";
            else if (this.buttonQ.Text == "1")
                this.textBox.Text += "1";
            else
                this.textBox.Text += "🎼";
        }
        

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (this.buttonW.Text == "w")
                this.textBox.Text += "w";
            else if (this.buttonW.Text == "W")
                this.textBox.Text += "W";
            else if (this.buttonW.Text == "2")
                this.textBox.Text += "2";
            else
                this.textBox.Text += emojies[22];
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (this.buttonS.Text == "s")
                this.textBox.Text += "s";
            else if (this.buttonS.Text == "S")
                this.textBox.Text += "S";
            else
                this.textBox.Text += emojies[18];
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (this.buttonX.Text == "x")
                this.textBox.Text += "x";
            else if (this.buttonX.Text == "X")
                this.textBox.Text += "X";
            else
                this.textBox.Text += emojies[23];
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (this.buttonE.Text == "e")
                this.textBox.Text += "e";
            else if (this.buttonE.Text == "E")
                this.textBox.Text += "E";
            else if (this.buttonE.Text == "3")
                this.textBox.Text += "3";
            else
                this.textBox.Text += emojies[4];
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (this.buttonD.Text == "d")
                this.textBox.Text += "d";
            else if (this.buttonD.Text == "D")
                this.textBox.Text += "D";
            else
                this.textBox.Text += emojies[3];
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (this.buttonR.Text == "r")
                this.textBox.Text += "r";
            else if(this.buttonR.Text == "R")
                this.textBox.Text += "R";
            else if (this.buttonR.Text == "4")
                this.textBox.Text += "4";
            else
                this.textBox.Text += emojies[17];
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (this.buttonC.Text == "c")
                this.textBox.Text += "c";
            else if (this.buttonC.Text == "C")
                this.textBox.Text += "C";
            else
                this.textBox.Text += emojies[2];
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (this.buttonT.Text == "t")
                this.textBox.Text += "t";
            else if(this.buttonT.Text == "T")
                this.textBox.Text += "T";
            else if (this.buttonT.Text == "5")
                this.textBox.Text += "5";
            else
                this.textBox.Text += emojies[19];
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (this.buttonY.Text == "y")
                this.textBox.Text += "y";
            else if(this.buttonY.Text == "Y")
                this.textBox.Text += "Y";
            else if (this.buttonY.Text == "6")
                this.textBox.Text += "6";
            else
                this.textBox.Text += emojies[24];
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (this.buttonU.Text == "u")
                this.textBox.Text += "u";
            else if (this.buttonU.Text == "U")
                this.textBox.Text += "U";
            else if (this.buttonU.Text == "7")
                this.textBox.Text += "7";
            else
                this.textBox.Text += emojies[20];
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (this.buttonI.Text == "i")
                this.textBox.Text += "i";
            else if (this.buttonI.Text == "I")
                this.textBox.Text += "I";
            else if (this.buttonI.Text == "8")
                this.textBox.Text += "8";
            else
                this.textBox.Text += emojies[8];
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (this.buttonO.Text == "o")
                this.textBox.Text += "o";
            else if (this.buttonO.Text == "O")
                this.textBox.Text += "O";
            else if (this.buttonO.Text == "9")
                this.textBox.Text += "9";
            else
                this.textBox.Text += emojies[14];
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (this.buttonF.Text == "f")
                this.textBox.Text += "f";
            else if (this.buttonF.Text == "F")
                this.textBox.Text += "F";
            else
                this.textBox.Text += emojies[5];
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (this.buttonG.Text == "g")
                this.textBox.Text += "g";
            else if (this.buttonG.Text == "G")
                this.textBox.Text += "G";
            else
                this.textBox.Text += emojies[6];
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (this.buttonH.Text == "h")
                this.textBox.Text += "h";
            else if (this.buttonH.Text == "H")
                this.textBox.Text += "H";
            else
                this.textBox.Text += emojies[7];
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
            else if (this.buttonP.Text == "0")
                this.textBox.Text += "0";
            else
                this.textBox.Text += emojies[15];
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            if (this.buttonJ.Text == "j")
                this.textBox.Text += "j";
            else if (this.buttonJ.Text == "J")
                this.textBox.Text += "J";
            else
                this.textBox.Text += emojies[9];
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (this.buttonK.Text == "k")
                this.textBox.Text += "k";
            else if (this.buttonK.Text == "K")
                this.textBox.Text += "K";
            else
                this.textBox.Text += emojies[10];
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (this.buttonL.Text == "l")
                this.textBox.Text += "l";
            else if (this.buttonL.Text == "L")
                this.textBox.Text += "L";
            else
                this.textBox.Text += emojies[11];
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (this.buttonV.Text == "v")
                this.textBox.Text += "v";
            else if (this.buttonV.Text == "V")
                this.textBox.Text += "V";
            else
                this.textBox.Text += emojies[21];
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (this.buttonB.Text == "b")
                this.textBox.Text += "b";
            else if (this.buttonB.Text == "B")
                this.textBox.Text += "B";
            else
                this.textBox.Text += emojies[1];
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (this.buttonN.Text == "n")
                this.textBox.Text += "n";
            else if (this.buttonN.Text == "N")
                this.textBox.Text += "N";
            else
                this.textBox.Text += emojies[13];
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (this.buttonM.Text == "m")
                this.textBox.Text += "m";
            else if (this.buttonM.Text == "M")
                this.textBox.Text += "M";
            else
                this.textBox.Text += emojies[12];
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
            if (this.buttonsList[16].Text != "1")
            {
                this.buttonsList[16].Text = "1";
                this.buttonsList[22].Text = "2";
                this.buttonsList[4].Text = "3";
                this.buttonsList[17].Text = "4";
                this.buttonsList[19].Text = "5";
                this.buttonsList[24].Text = "6";
                this.buttonsList[20].Text = "7";
                this.buttonsList[8].Text = "8";
                this.buttonsList[14].Text = "9";
                this.buttonsList[15].Text = "0";
            }
            else
            {
                this.buttonsList[16].Text = "q";
                this.buttonsList[22].Text = "w";
                this.buttonsList[4].Text = "e";
                this.buttonsList[17].Text = "r";
                this.buttonsList[19].Text = "t";
                this.buttonsList[24].Text = "y";
                this.buttonsList[20].Text = "u";
                this.buttonsList[8].Text = "i";
                this.buttonsList[14].Text = "o";
                this.buttonsList[15].Text = "p";

                for (int i = 0; i < buttonsList.Count; i++)
                {
                    this.buttonsList[i].Text = this.buttonsList[i].Text.ToUpper();
                }
            }
             
            

        }

        private void buttonSmaylik_Click(object sender, EventArgs e)
        {
            if (buttonsList[0].Text == "A" || buttonsList[0].Text == "a")
            {
                for (int i = 0; i < emojies.Count; i++)
                {
                    this.buttonsList[i].Text = this.emojies[i];
                }
            }
            else
            {
                this.buttonA.Text = "A";
                this.buttonB.Text = "B";
                this.buttonC.Text = "C";
                this.buttonD.Text = "D";
                this.buttonE.Text = "E";
                this.buttonF.Text = "F";
                this.buttonG.Text = "G";
                this.buttonH.Text = "H";
                this.buttonI.Text = "I";
                this.buttonJ.Text = "J";
                this.buttonK.Text = "K";
                this.buttonL.Text = "L";
                this.buttonM.Text = "M";
                this.buttonN.Text = "N";
                this.buttonO.Text = "O";
                this.buttonP.Text = "P";
                this.buttonQ.Text = "Q";
                this.buttonR.Text = "R";
                this.buttonS.Text = "S";
                this.buttonT.Text = "T";
                this.buttonU.Text = "U";
                this.buttonV.Text = "V";
                this.buttonW.Text = "W";
                this.buttonX.Text = "X";
                this.buttonY.Text = "Y";
                this.buttonZ.Text = "Z";
            }   
            
        }
    }
}