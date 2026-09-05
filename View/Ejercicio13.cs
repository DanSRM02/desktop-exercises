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
    public partial class Ejercicio13 : Form
    {
        public Ejercicio13()
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
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double pl) ||
                !double.TryParse(textBox2.Text, out double pma) ||
                !double.TryParse(textBox3.Text, out double pmi) ||
                !double.TryParse(textBox5.Text, out double pj) ||
                !double.TryParse(textBox7.Text, out double pv) ||
                !double.TryParse(textBox6.Text, out double ps))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los campos.");
                return;
            }

            double pt = pl + pma + pmi + pj + pv + ps;
            double pp = pt / 6.0;

            string msg = "";

            if (pp >= 100)
            {
                msg = "Recibirá Incentivos";
            }
            else
            {
                msg = "No Recibirá Incentivos";
            }

            textBox4.Text = msg;
        }
    }
}
