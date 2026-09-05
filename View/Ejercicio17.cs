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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator.View
{
    public partial class Ejercicio17 : Form
    {
        public Ejercicio17()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectOpt.Text = string.Empty;
            amountSales.Text = string.Empty;
            percentageBonification.Text = string.Empty;
            totalBonification.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(selectOpt.Text, out double selectedOpt))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }

            if (!double.TryParse(amountSales.Text, out double amountSalesV))
            {
                MessageBox.Show("Ingrese un valor correcto, solo se aceptan numeros");
                return;
            }

            CalculateOpt(selectedOpt, amountSalesV);
        }

        private void CalculateOpt(double opt, double amountSales)
        {

            switch (opt)
            {
                case 1:

                    if (amountSales >= 0 && amountSales <= 1000)
                    {
                        percentageBonification.Text = "0%";
                        totalBonification.Text = CalculateTotalBonitification(amountSales, 0);
                        return;
                    }
                    MessageBox.Show("el monto no esta ubicado entre 0 y 1000");

                    break;

                case 2:

                    if (amountSales >= 1000 && amountSales <= 5000)
                    {
                        percentageBonification.Text = "3%";
                        totalBonification.Text = CalculateTotalBonitification(amountSales, 0.03);
                        return;
                    }

                    MessageBox.Show("el monto no esta ubicado entre 1000 y 5000");
                    break;

                case 3:

                    if (amountSales >= 5000 && amountSales <= 20000)
                    {
                        percentageBonification.Text = "5%";
                        totalBonification.Text = CalculateTotalBonitification(amountSales, 0.05);
                        return;
                    }
                    MessageBox.Show("el monto no esta ubicado entre 5000 y 20000");
                    break;

                case 4:

                    if (amountSales >= 20000)
                    {
                        percentageBonification.Text = "8%";
                        totalBonification.Text = CalculateTotalBonitification(amountSales, 0.08);
                        return;
                    }
                    MessageBox.Show("el monto no esta ubicado mayor a 20000");
                    break;

                default:
                    MessageBox.Show("Ingrese una opción válida");
                    break;
            }

        }

        private string CalculateTotalBonitification(double amountSales, double percentage)
        {
            return (percentage * amountSales).ToString();
        }
    }
}
