namespace Calculator.View
{
    partial class Ejercicio17
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio17));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectOpt = new System.Windows.Forms.TextBox();
            this.amountSales = new System.Windows.Forms.TextBox();
            this.percentageBonification = new System.Windows.Forms.TextBox();
            this.totalBonification = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELECCIONE SU OPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE EL MONTO DE VENTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "El total de Bonificación en S/. es:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "La opción seleccionada corresponde a un porcentaje de Bonificación en %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // selectOpt
            // 
            this.selectOpt.Location = new System.Drawing.Point(198, 172);
            this.selectOpt.Name = "selectOpt";
            this.selectOpt.Size = new System.Drawing.Size(100, 20);
            this.selectOpt.TabIndex = 5;
            // 
            // amountSales
            // 
            this.amountSales.Location = new System.Drawing.Point(240, 198);
            this.amountSales.Name = "amountSales";
            this.amountSales.Size = new System.Drawing.Size(100, 20);
            this.amountSales.TabIndex = 6;
            // 
            // percentageBonification
            // 
            this.percentageBonification.Enabled = false;
            this.percentageBonification.Location = new System.Drawing.Point(423, 227);
            this.percentageBonification.Name = "percentageBonification";
            this.percentageBonification.Size = new System.Drawing.Size(100, 20);
            this.percentageBonification.TabIndex = 7;
            // 
            // totalBonification
            // 
            this.totalBonification.Enabled = false;
            this.totalBonification.Location = new System.Drawing.Point(227, 251);
            this.totalBonification.Name = "totalBonification";
            this.totalBonification.Size = new System.Drawing.Size(100, 20);
            this.totalBonification.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ejercicio17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalBonification);
            this.Controls.Add(this.percentageBonification);
            this.Controls.Add(this.amountSales);
            this.Controls.Add(this.selectOpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio17";
            this.Text = "Ejercicio17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectOpt;
        private System.Windows.Forms.TextBox amountSales;
        private System.Windows.Forms.TextBox percentageBonification;
        private System.Windows.Forms.TextBox totalBonification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}