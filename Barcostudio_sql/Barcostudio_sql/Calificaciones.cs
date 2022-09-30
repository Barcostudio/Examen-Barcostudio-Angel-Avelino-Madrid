using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcostudio_sql
{
    public partial class Calificaciones : Form
    {
        public Calificaciones()
        {
            InitializeComponent();
        }

        ClsCalificaciones sql = new ClsCalificaciones();

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdregistroescDataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.bdregistroescDataSet.materias);
            // TODO: esta línea de código carga datos en la tabla 'bdregistroescDataSet.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.bdregistroescDataSet.alumno);


            dgvCal.DataSource = sql.mostrardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != " ")
            {
                dgvCal.DataSource = sql.buscardatos(txtBuscar.Text);
            }
            else
            {
                dgvCal.DataSource = sql.mostrardatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sql.eliminar(txtAluID.Text, textMatID.Text) == true)
            {
                MessageBox.Show("Datos eliminados");
                txtBuscar.Clear();
                dgvCal.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos no eliminados");

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
  

            if (sql.insertar(txtAluID.Text, textMatID.Text, nud1.Text, nud2.Text, nud3.Text) == true)
            {
                MessageBox.Show("Datos insertados");
                cmbAlumno.SelectedIndex = 0;
                cmbMateria.SelectedIndex = 0;
                nud1.Value = 0;
                nud2.Value = 0;
                nud3.Value = 0;
                dgvCal.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos no insertados");

            }
        }

        private void txtAluID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (sql.actualizar(nud1.Text, nud2.Text, nud3.Text, txtAluID.Text, textMatID.Text) == true)
            {

                MessageBox.Show("Datos actualizados");
                nud1.Value = 0;
                nud2.Value = 0;
                nud3.Value = 0;
                cmbAlumno.SelectedIndex = 0;
                cmbMateria.SelectedIndex = 0; 
                dgvCal.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos NO actualizados");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            nud1.Text = dgvCal[6, 0].Value.ToString();
            nud2.Text = dgvCal[7, 0].Value.ToString();
            nud3.Text = dgvCal[8, 0].Value.ToString();
            txtAluID.Text = dgvCal[0, 0].Value.ToString();
            textMatID.Text= dgvCal[4, 0].Value.ToString();
        }
    }


} 