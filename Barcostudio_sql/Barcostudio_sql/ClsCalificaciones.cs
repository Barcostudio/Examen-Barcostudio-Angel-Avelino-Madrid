using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace Barcostudio_sql
{
    internal class ClsCalificaciones
    {
        private SqlConnection conexion = new SqlConnection("Data Source= DESKTOP-GD5MVN2\\BARCO; Initial Catalog= bdregistroesc; Integrated Security = true");
        private DataSet ds;
 
       
        public DataTable mostrardatos()
        {
             
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select alumno.Nombre, alumno.Apellido_Pa, alumno.Apellido_Ma, materias.Descripcion, calificaciones.Pparcial, calificaciones.Sparcial, calificaciones.Tparcial, calificaciones.calificaciones from calificaciones inner join alumno on calificaciones.idAlumno = alumno.idAlumno inner join materias on calificaciones.idMateria = materias.idMateria ", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable buscardatos(string Nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select alumno.idAlumno, alumno.Nombre, alumno.Apellido_Pa, alumno.Apellido_Ma, materias.idMateria, materias.Descripcion, calificaciones.Pparcial, calificaciones.Sparcial, calificaciones.Tparcial, calificaciones.calificaciones from calificaciones inner join alumno on calificaciones.idAlumno = alumno.idAlumno and alumno.Nombre = '{0}' inner join materias on calificaciones.idMateria = materias.idMateria ", Nombre), conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public bool insertar(string idalu, string idmat, string p1, string p2, string p3)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into calificaciones(idAlumno,idMateria,Pparcial,Sparcial,Tparcial,calificaciones) values ({0},{1},{2},{3},{4},0);", new string[] { idalu, idmat, p1, p2,p3 }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool eliminar(string alu, string mat)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from calificaciones where calificaciones.idAlumno = '{0}' AND  calificaciones.idMateria = '{1}'", new string[] {alu, mat}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool actualizar(string P1, string P2, string P3, string alu, string mat)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update calificaciones set Pparcial = {0}, Sparcial = {1}, Tparcial = {2} where calificaciones.idAlumno = {3} and calificaciones.idMateria = {4}", new string[] { P1, P2, P3, alu, mat}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
    }
}
