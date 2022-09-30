using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcostudio_sql
{
    internal class ClsMateria
    {
        private SqlConnection conexion = new SqlConnection("Data Source= DESKTOP-GD5MVN2\\BARCO; Initial Catalog= bdregistroesc; Integrated Security = true");
        private DataSet ds;

        public DataTable mostrardatos()
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from materias", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable buscardatos(string Des)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from materias where Descripcion like '%{0}%'", Des), conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public bool insertar(string des)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into materias values('{0}')", new string[] {des}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool eliminar(string des)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from materias where Descripcion = '{0}'", des), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool actualizar(string des, string des1)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update materias set Descripcion ='{0}' where Descripcion='{1}'", new string[] {des, des1}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
    }
}
