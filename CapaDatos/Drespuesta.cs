using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Drespuesta
    {
        private int _id_respuesta;
        private string _respuesta_1;
        private string _respuesta_2;
        private string _respuesta_3;
        private string _respuesta_4;
        private string _respuesta_5;
        private string _respuesta_6;
        private int _id_pregunta;
        private DateTime _fecha_crea;
        private string _estado;

        public int Id_respuesta { get => _id_respuesta; set => _id_respuesta = value; }
        public string Respuesta_1 { get => _respuesta_1; set => _respuesta_1 = value; }
        public string Respuesta_2 { get => _respuesta_2; set => _respuesta_2 = value; }
        public string Respuesta_3 { get => _respuesta_3; set => _respuesta_3 = value; }
        public string Respuesta_4 { get => _respuesta_4; set => _respuesta_4 = value; }
        public string Respuesta_5 { get => _respuesta_5; set => _respuesta_5 = value; }
        public string Respuesta_6 { get => _respuesta_6; set => _respuesta_6 = value; }
        public int Id_pregunta { get => _id_pregunta; set => _id_pregunta = value; }
        public DateTime Fecha_crea { get => _fecha_crea; set => _fecha_crea = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public Drespuesta(int id_respuesta,
         string respuesta_1,
         string respuesta_2,
         string respuesta_3,
         string respuesta_4,
         string respuesta_5,
         string respuesta_6,
         DateTime fecha_crea,
         int id_pregunta,
         string estado)
        {

            this.Id_respuesta = id_respuesta;
            this.Respuesta_1 = respuesta_1;
            this.Respuesta_2 = respuesta_2;
            this.Respuesta_3 = respuesta_3;
            this.Respuesta_4 = respuesta_4;
            this.Respuesta_5 = respuesta_5;
            this.Respuesta_6 = respuesta_6;
            this.Fecha_crea = fecha_crea;
            this.Id_pregunta = id_pregunta;
            this.Estado = estado;



        }

        public Drespuesta()
        {

        }


        public string insertar(Drespuesta objreclutamiento)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spinsertar_respuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_actor = new SqlParameter();
                parci_actor.ParameterName = "@id_respuesta";
                parci_actor.SqlDbType = SqlDbType.Int;
                parci_actor.Value = objreclutamiento.Id_respuesta;
                sqlcmd.Parameters.Add(parci_actor);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@respuesta1";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = objreclutamiento.Respuesta_1;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parapellido = new SqlParameter();
                parapellido.ParameterName = "@respuesta2";
                parapellido.SqlDbType = SqlDbType.VarChar;
                parapellido.Size = 50;
                parapellido.Value = objreclutamiento.Respuesta_2;
                sqlcmd.Parameters.Add(parapellido);

                SqlParameter pardirec = new SqlParameter();
                pardirec.ParameterName = "@respuesta3";
                pardirec.SqlDbType = SqlDbType.VarChar;
                pardirec.Size = 50;
                pardirec.Value = objreclutamiento.Respuesta_3;
                sqlcmd.Parameters.Add(pardirec);

                SqlParameter parci_ci = new SqlParameter();
                parci_ci.ParameterName = "@respuesta4";
                parci_ci.SqlDbType = SqlDbType.VarChar;
                parci_ci.Size = 50;
                parci_ci.Value = objreclutamiento.Respuesta_4;
                sqlcmd.Parameters.Add(parci_ci);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@respuesta5";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 50;
                ParFecha.Value = objreclutamiento.Respuesta_5;
                sqlcmd.Parameters.Add(ParFecha);

                SqlParameter parnivel = new SqlParameter();
                parnivel.ParameterName = "@respuesta6";
                parnivel.SqlDbType = SqlDbType.VarChar;
                parnivel.Size = 50;
                parnivel.Value = objreclutamiento.Respuesta_6;
                sqlcmd.Parameters.Add(parnivel);

                SqlParameter parnivel2 = new SqlParameter();
                parnivel2.ParameterName = "@_id_pregunta";
                parnivel2.SqlDbType = SqlDbType.VarChar;
                parnivel2.Size = 50;
                parnivel2.Value = objreclutamiento.Id_pregunta;
                sqlcmd.Parameters.Add(parnivel2);




                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se inserto nada";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


            return rpta;

        }

        public DataTable mostrar()
        {
            DataTable dataresul = new DataTable("respuesta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_respuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter datatabla = new SqlDataAdapter(sqlcmd);
                datatabla.Fill(dataresul);


            }
            catch (Exception ex)
            {

                dataresul = null;
            }

            return dataresul;

        }

        public DataTable mostrarpregunta()
        {
            DataTable dataresul = new DataTable("pregunta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_pregunta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter datatabla = new SqlDataAdapter(sqlcmd);
                datatabla.Fill(dataresul);


            }
            catch (Exception ex)
            {

                dataresul = null;
            }

            return dataresul;

        }

        public DataTable mostrarsincronizar()
        {
            DataTable dataresul = new DataTable("pregunta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "act_pro12";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter datatabla = new SqlDataAdapter(sqlcmd);
                datatabla.Fill(dataresul);


            }
            catch (Exception ex)
            {

                dataresul = null;
            }

            return dataresul;

        }

        public DataTable mostrarsincronizar2()
        {
            DataTable dataresul = new DataTable("respuesta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_respuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter datatabla = new SqlDataAdapter(sqlcmd);
                datatabla.Fill(dataresul);


            }
            catch (Exception ex)
            {

                dataresul = null;
            }

            return dataresul;

        }

        public DataTable mostrarsincronizar3()
        {
            DataTable dataresul = new DataTable("respuesta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "act_pro";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter datatabla = new SqlDataAdapter(sqlcmd);
                datatabla.Fill(dataresul);


            }
            catch (Exception ex)
            {

                dataresul = null;
            }

            return dataresul;

        }




    }
}
