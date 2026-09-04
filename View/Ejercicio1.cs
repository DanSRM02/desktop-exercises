using CalculatorScope;
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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double firstNumber))
            {
                MessageBox.Show("Ingrese un valor válido para el primer párametro, se aceptan unicamente números");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double secondNumber))
            {
                MessageBox.Show("Ingrese un valor válido para el segundo párametro, se aceptan unicamente números");
                return;
            }

            double result = Operator.Multiply(firstNumber, secondNumber);

            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
