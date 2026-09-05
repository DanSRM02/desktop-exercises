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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
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

            double totalCorrectAnswer = Operator.Multiply(firstValue, 3);
            double totalIncorrectAnswers = Operator.Multiply(secondValue, 1);

            double finalTotal = Operator.Add(totalCorrectAnswer, totalIncorrectAnswers);

            textBox4.Text = finalTotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
