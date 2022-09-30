using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcostudio_sql
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Alumno = new Alumno();
            Alumno.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Materias = new Materias();
            Materias.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Calificaciones = new Calificaciones();
            Calificaciones.Show();    
        }
    }
}
