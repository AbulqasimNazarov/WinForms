namespace KeyboardApp
{
    partial class Form1
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
            this.buttonA = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.buttonShift = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonA.Location = new System.Drawing.Point(32, 310);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(48, 47);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "a";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 36);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(776, 167);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // buttonShift
            // 
            this.buttonShift.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShift.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShift.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonShift.Location = new System.Drawing.Point(4, 353);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(76, 47);
            this.buttonShift.TabIndex = 2;
            this.buttonShift.Text = "⬆";
            this.buttonShift.UseVisualStyleBackColor = false;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZ.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonZ.Location = new System.Drawing.Point(77, 353);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(48, 47);
            this.buttonZ.TabIndex = 3;
            this.buttonZ.Text = "z";
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQ.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonQ.Location = new System.Drawing.Point(4, 267);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(48, 47);
            this.buttonQ.TabIndex = 4;
            this.buttonQ.Text = "q";
            this.buttonQ.UseVisualStyleBackColor = false;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonA;
        private RichTextBox textBox;
        private Button buttonShift;
        private Button buttonZ;
        private Button buttonQ;
    }
}