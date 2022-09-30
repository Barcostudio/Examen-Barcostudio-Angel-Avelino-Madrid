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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        ClsMateria sql = new ClsMateria();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNomMateria.Text = dgvMosMateria[1, 0].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sql.eliminar(txtBuscar.Text) == true)
            {
                MessageBox.Show("Datos eliminados");
                txtBuscar.Clear();
                dgvMosMateria.DataSource = sql.mostrardatos();
            }
            else
            {
                MessageBox.Show("Datos no eliminados");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string des1 = dgvMosMateria[1,0].Value.ToString();
            sql.actualizar(txtNomMateria.Text,des1);

            MessageBox.Show("Datos actualizados");
            txtNomMateria.Clear();
            txtBuscar.Clear();
            dgvMosMateria.DataSource = sql.mostrardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (sql.insertar(txtNomMateria.Text) == true)
            {
                MessageBox.Show("Datos insertados");
                txtNomMateria.Clear();
                dgvMosMateria.DataSource = sql.mostrardatos();
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
                dgvMosMateria.DataSource = sql.buscardatos(txtBuscar.Text);
            }
            else
            {
                dgvMosMateria.DataSource = sql.mostrardatos();
            }
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            dgvMosMateria.DataSource = sql.mostrardatos();
        }
    }
}
