using Calculator.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorScope
{
    public partial class Menu : Form
    {
        
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

        private void numero2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio2>();
        }

        private void numero3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio3>();
        }

        private void numero4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio4>();
        }

        private void numero5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio5>();
        }

        private void numero6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio6>();
        }

        private void numero7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio7>();
        }
        private void numero8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio8>();
        }

        private void numero17ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio17>();
        }

        private void numero9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio9>();
        }

        private void numero10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio10>();
        }

        private void numero12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExercises<Ejercicio12>();
        }
    }
}
