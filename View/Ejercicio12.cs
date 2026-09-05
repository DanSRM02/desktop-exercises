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
    public partial class Ejercicio12 : Form
    {
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (!int.TryParse(textBox3.Text, out int e1) || !int.TryParse(textBox5.Text, out int e2))
            {
                MessageBox.Show("Por favor, ingrese edades válidas en números enteros.");
                return;
            }

            int de; 

            if (e1 > e2)
            {
                de = e1 - e2;
                textBox4.Text = $"El Primer Hermano es el Mayor, por {de} años";
            }
            else if (e2 > e1)
            {
                de = e2 - e1;
                textBox4.Text = $"El segundo Hermano es el Mayor por {de} años";
            }
            else
            {
                textBox4.Text = "Ambos hermanos tienen la misma edad.";
            }
        }
    }
}
