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
    public partial class Ejercicio14 : Form
    {
        public Ejercicio14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (!double.TryParse(textBox1.Text, out double firstValue) ||
                !double.TryParse(textBox2.Text, out double secondValue) ||
                !double.TryParse(textBox3.Text, out double thirdValue))
            {
                MessageBox.Show("Por favor, ingrese números enteros válidos en todos los campos.");
                return;
            }

            double nm; 
            
            if (firstValue > secondValue && firstValue > thirdValue)
            {
                nm = firstValue;
            }
            else
            {
                if (secondValue > thirdValue)
                {
                    nm = secondValue;
                }
                else
                {
                    nm = thirdValue;
                }
            }
            
            textBox4.Text = $"El número mayor es: {nm}";
        }
    }
}
