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
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonA.Location = new System.Drawing.Point(12, 247);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(29, 27);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonA;
    }
}