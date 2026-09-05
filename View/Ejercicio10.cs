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
    public partial class Ejercicio10 : Form
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double firstValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }
            if (!double.TryParse(textBox2.Text, out double secondValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }

            if (!double.TryParse(textBox3.Text, out double thirdValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }
            if (!double.TryParse(textBox5.Text, out double fourthValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }
            
            double distance = Math.Sqrt(Math.Pow(secondValue - firstValue, 2) + Math.Pow(fourthValue - thirdValue, 2));

            textBox4.Text = distance.ToString();

        }
    }
}
