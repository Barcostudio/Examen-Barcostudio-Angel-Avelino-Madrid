using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Barcostudio_sql
{
    internal class ClsAlumno
    {

        private SqlConnection conexion = new SqlConnection("Data Source= DESKTOP-GD5MVN2\\BARCO; Initial Catalog= bdregistroesc; Integrated Security = true");
        private DataSet ds;

        public DataTable mostrardatos()
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from alumno", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable buscardatos(string Nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from alumno where Nombre like '%{0}%'", Nombre), conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public bool insertar(string Nombre, string Ap, string Am, string edad, string sexo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into alumno values('{0}','{1}','{2}',{3},'{4}')", new string[] { Nombre, Ap, Am, edad, sexo }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool eliminar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from alumno where Nombre = '{0}'", nombre), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool actualizar(string Nombre, string Ap, string Am, string edad, string sexo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update alumno set Nombre='{0}',Apellido_Pa='{1}',Apellido_Ma='{2}', Edad={3},Sexo='{4}' where Nombre='{0}' or Apellido_Pa='{1}' or apellido_MA='{2}'", new string[] { Nombre, Ap, Am, edad, sexo}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }




    }
}

