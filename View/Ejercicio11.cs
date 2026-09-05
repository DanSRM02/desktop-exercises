using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.View
{
    public partial class Ejercicio11 : Form
    {
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (!int.TryParse(textBox1.Text, out int firstValue) ||
                !int.TryParse(textBox2.Text, out int secondValue))
            {
                MessageBox.Show("Por favor, ingrese años válidos en números enteros.");
                return;
            }
            
            int age = secondValue - firstValue;
            
            if (age > 17)
            {
                textBox3.Text = "Debe de Inscribirse en el SMO.";
            }
            else
            {
                textBox3.Text = "No debe de Inscribirse en el SMO.";
            }
        }
    }
}
