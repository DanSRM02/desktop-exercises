namespace CalculatorScope
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosDel110ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numero1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosDel1117ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosDel110ToolStripMenuItem,
            this.ejerciciosDel1117ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosDel110ToolStripMenuItem
            // 
            this.ejerciciosDel110ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numero1ToolStripMenuItem});
            this.ejerciciosDel110ToolStripMenuItem.Name = "ejerciciosDel110ToolStripMenuItem";
            this.ejerciciosDel110ToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ejerciciosDel110ToolStripMenuItem.Text = "Ejercicios del 1 - 10";
            // 
            // numero1ToolStripMenuItem
            // 
            this.numero1ToolStripMenuItem.Name = "numero1ToolStripMenuItem";
            this.numero1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.numero1ToolStripMenuItem.Text = "Numero1";
            this.numero1ToolStripMenuItem.Click += new System.EventHandler(this.numero1ToolStripMenuItem_Click);
            // 
            // ejerciciosDel1117ToolStripMenuItem
            // 
            this.ejerciciosDel1117ToolStripMenuItem.Name = "ejerciciosDel1117ToolStripMenuItem";
            this.ejerciciosDel1117ToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.ejerciciosDel1117ToolStripMenuItem.Text = "Ejercicios del 11 - 17";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 519);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosDel110ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosDel1117ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numero1ToolStripMenuItem;
    }
}

