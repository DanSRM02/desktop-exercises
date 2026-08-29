using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double prevNumber = 0;
        double currentNumber = 0;
        string pendingOperation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void numbers_button(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;

            textBox1.Text += selectedButton.Text;
            currentNumber = double.Parse(textBox1.Text);
        }

        private void Operator_Clicks(object sender, EventArgs e)
        {
            Button selectedOperator = (Button)sender;
            string botonTexto = selectedOperator.Text;            

            if (botonTexto == "C")
            {
                textBox1.Clear();
                currentNumber = 0;
                prevNumber = 0;
                pendingOperation = "";
                label1.Text = "";
                return;
            }

            if (botonTexto == "CE")
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    if (textBox1.Text.Length > 0)
                    {
                        currentNumber = double.Parse(textBox1.Text);
                    }
                    else
                    {
                        currentNumber = 0;
                    }
                }
                return;
            }

            if (botonTexto == "=")
            {
                CalculateOption( prevNumber, currentNumber, pendingOperation);
                label1.Text = "";
                textBox1.Clear();
            }
            else
            {
                pendingOperation = botonTexto;
                prevNumber = currentNumber;
                currentNumber = 0;
                label1.Text = $"Operación: {botonTexto}";
                textBox1.Clear();
            }
        }

        private void CalculateOption(double firstNumber, double secondNumber, string option)
        {
            double result = 0;
            switch (option)
            {
                case "+":
                    result = Operator.Add(firstNumber, secondNumber);
                    MessageBox.Show($"Ey tu suma es esto: {result}");
                    break;
                case "-":
                    result = Operator.Subtract(firstNumber, secondNumber);
                    MessageBox.Show($"Ey tu resta es esto: {result}");
                    break;
                case "/":
                    try
                    {
                        result = Operator.Divide(firstNumber, secondNumber);
                        MessageBox.Show($"Ey tu divicion es esto: {result}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede dividir por cero");
                    }
                    break;
                case "X":
                    result = Operator.Multiply(firstNumber, secondNumber);
                    MessageBox.Show($"Ey tu multiplicacion es esto: {result}");
                    break;
                default:
                    MessageBox.Show("Enter a valid operator");
                    break;
            }
        }
    }
}
