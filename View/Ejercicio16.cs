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
    public partial class Ejercicio16 : Form
    {
        public Ejercicio16()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (!int.TryParse(textBox1.Text, out int firstValue))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.");
                return;
            }

            string er = ""; 
            switch (firstValue)
            {
                case 1:
                    er = "I";
                    break;
                case 2:
                    er = "II";
                    break;
                case 3:
                    er = "III";
                    break;
                case 4:
                    er = "IV";
                    break;
                case 5:
                    er = "V";
                    break;
                case 6:
                    er = "VI";
                    break;
                case 7:
                    er = "VII";
                    break;
                case 8:
                    er = "VIII";
                    break;
                case 9:
                    er = "IX";
                    break;
                case 10:
                    er = "X";
                    break;
                default:
                    MessageBox.Show("Por favor, ingrese un número del 1 al 10.");
                    return;
            }
            
            textBox2.Text = er;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
