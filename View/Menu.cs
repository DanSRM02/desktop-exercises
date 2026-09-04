using Calculator.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorScope
{
    public partial class Menu : Form
    {
        Form frmAbierto;
        public Menu()
        {
            InitializeComponent();
        }

        private void OpenExercises<T>() where T : Form, new()
        {
            Form openExercise = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (openExercise != null)
            {
                openExercise.BringToFront();
                openExercise.WindowState = FormWindowState.Normal;
            }
            else
            {
                T newExercise = new T();
                newExercise.MdiParent = this;
                newExercise.StartPosition = FormStartPosition.CenterScreen;
                newExercise.Show();
            }
        }

        private void numero1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio1>();
        }
    }
}
