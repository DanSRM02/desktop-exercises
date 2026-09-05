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
    public partial class Ejercicio15 : Form
    {
        public Ejercicio15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double firstValue) ||
                !double.TryParse(textBox2.Text, out double secondValue) ||
                !double.TryParse(textBox3.Text, out double thirdValue))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los campos.");
                return;
            }

            string tt = "";

            if (firstValue != secondValue && secondValue != thirdValue && thirdValue != firstValue)
            {
                tt = "Escaleno";
            }
            else
            {
                if (firstValue == secondValue && secondValue == thirdValue)
                {
                    tt = "Equilátero";
                }
                else
                {
                    tt = "Isósceles";
                }
            }

            textBox4.Text = $"El tipo de triángulo es: {tt}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
