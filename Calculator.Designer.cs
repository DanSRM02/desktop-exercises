namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(32, 183);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(80, 59);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(118, 183);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(80, 59);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(204, 183);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(80, 59);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(204, 248);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(80, 59);
            this.buttonSix.TabIndex = 5;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(118, 248);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(80, 59);
            this.buttonFive.TabIndex = 4;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(32, 248);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(80, 59);
            this.buttonFour.TabIndex = 3;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(204, 313);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(80, 59);
            this.buttonThree.TabIndex = 8;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(118, 313);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(80, 59);
            this.buttonTwo.TabIndex = 7;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.numbers_button);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(32, 313);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(80, 59);
            this.buttonOne.TabIndex = 6;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.numbers_button);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(290, 248);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 59);
            this.button10.TabIndex = 11;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(290, 183);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(80, 59);
            this.buttonSubstract.TabIndex = 10;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(290, 118);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(80, 59);
            this.buttonMultiply.TabIndex = 9;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(204, 118);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(80, 59);
            this.buttonDivision.TabIndex = 14;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(118, 118);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(80, 59);
            this.buttonC.TabIndex = 13;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(32, 118);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(80, 59);
            this.buttonCE.TabIndex = 12;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(290, 313);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 59);
            this.button16.TabIndex = 15;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Operator_Clicks);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 59);
            this.button1.TabIndex = 17;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numbers_button);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

