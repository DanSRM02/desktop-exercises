using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator.View
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox3.Text, out double firstValue))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }

            double Gigabytes = firstValue * 1024;
            double megabytes = Gigabytes / 1.44;

            textBox4.Text = megabytes.ToString();
        }
    }
}
