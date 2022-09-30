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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }
        
        ClsAlumno sql= new ClsAlumno();

        private void dgvMosAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            dgvMosAlumno.DataSource = sql.mostrardatos(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (sql.insertar(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, nudEdad.Text, cmbSexo.Text)==true)
            {
                MessageBox.Show("Datos insertados");
                txtNombre.Clear();
                txtApPaterno.Clear();
                txtApMaterno.Clear();
                nudEdad.Value = 0;
                cmbSexo.SelectedIndex = 0;
                dgvMosAlumno.DataSource=sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos no insertados");

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != " ")
            {
                dgvMosAlumno.DataSource = sql.buscardatos(txtBuscar.Text);
            }
            else
            {
                dgvMosAlumno.DataSource = sql.mostrardatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (sql.actualizar(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, nudEdad.Text, cmbSexo.Text) == true)
            {

                MessageBox.Show("Datos actualizados");
                txtNombre.Clear();
                txtApPaterno.Clear();
                txtApMaterno.Clear();
                nudEdad.Value = 0;
                cmbSexo.SelectedIndex = 0;
                txtBuscar.Clear();
                dgvMosAlumno.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos NO actualizados");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sql.eliminar(txtBuscar.Text) == true)
            {
                MessageBox.Show("Datos eliminados");
                txtBuscar.Clear();
                dgvMosAlumno.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos no eliminados");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

           txtNombre.Text = dgvMosAlumno[1, 0].Value.ToString();
           txtApPaterno.Text = dgvMosAlumno[2, 0].Value.ToString();
           txtApMaterno.Text = dgvMosAlumno[3, 0].Value.ToString();
           nudEdad.Text = dgvMosAlumno[4, 0].Value.ToString();
           cmbSexo.Text = dgvMosAlumno[5, 0].Value.ToString();
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
