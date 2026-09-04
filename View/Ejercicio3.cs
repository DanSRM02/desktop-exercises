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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double firstValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }

            if (!double.TryParse(textBox3.Text, out double secondValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }

            textBox2.Text = (Operator.Multiply(firstValue,secondValue)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
