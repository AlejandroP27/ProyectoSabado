using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dencuestador
    {
        private int _idencuestador;
        private int _idencuesta;
        private int _idreclutamiento;
        private string _instancia;
        private string _basededatos;
        private DateTime _fecha_crea;
        private string _estado;

        public int Idencuestador { get => _idencuestador; set => _idencuestador = value; }
        public int Idencuesta { get => _idencuesta; set => _idencuesta = value; }
        public int Idreclutamiento { get => _idreclutamiento; set => _idreclutamiento = value; }
        public DateTime Fecha_crea { get => _fecha_crea; set => _fecha_crea = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Instancia { get => _instancia; set => _instancia = value; }
        public string Basededatos { get => _basededatos; set => _basededatos = value; }

        public Dencuestador(int idencuestador, int idencuesta, int idreclutamiento,string instancia,string basededatos, DateTime fecha_crea, string estado)
        {
            this.Idencuestador = idencuestador;
            this.Idencuesta = idencuesta;
            this.Idreclutamiento = idreclutamiento;
            this.Instancia = instancia;
            this.Basededatos = basededatos;
            this.Fecha_crea = fecha_crea;
            this.Estado = estado;
        }

        public Dencuestador()
        {

        }


        public string insertar(Dencuestador objencuestador)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spinsertar_encuestador";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_actor = new SqlParameter();
                parci_actor.ParameterName = "@id_encuestador";
                parci_actor.SqlDbType = SqlDbType.Int;
                parci_actor.Value = objencuestador.Idencuestador;
                sqlcmd.Parameters.Add(parci_actor);

                SqlParameter parencuesta = new SqlParameter();
                parencuesta.ParameterName = "@id_encuesta";
                parencuesta.SqlDbType = SqlDbType.Int;
                parencuesta.Value = objencuestador.Idencuesta;
                sqlcmd.Parameters.Add(parencuesta);

                SqlParameter parecluta = new SqlParameter();
                parecluta.ParameterName = "@id_reclutamiento";
                parecluta.SqlDbType = SqlDbType.Int;
                parecluta.Value = objencuestador.Idreclutamiento;
                sqlcmd.Parameters.Add(parecluta);

                SqlParameter parinstancia = new SqlParameter();
                parinstancia.ParameterName = "@instancia";
                parinstancia.SqlDbType = SqlDbType.VarChar;
                parinstancia.Size = 50;
                parinstancia.Value = objencuestador.Instancia;
                sqlcmd.Parameters.Add(parinstancia);

                SqlParameter parbasededatos = new SqlParameter();
                parbasededatos.ParameterName = "@basededatos";
                parbasededatos.SqlDbType = SqlDbType.VarChar;
                parbasededatos.Size = 50;
                parbasededatos.Value = objencuestador.Basededatos;
                sqlcmd.Parameters.Add(parbasededatos);


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



        public string editar(Dencuestador objencuestador)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speditar_encuestador";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parencuesta = new SqlParameter();
                parencuesta.ParameterName = "@id_encuesta";
                parencuesta.SqlDbType = SqlDbType.Int;
                parencuesta.Value = objencuestador.Idencuesta;
                sqlcmd.Parameters.Add(parencuesta);

                SqlParameter parrecluta = new SqlParameter();
                parrecluta.ParameterName = "@id_reclutamiento";
                parrecluta.SqlDbType = SqlDbType.Int;
                parrecluta.Value = objencuestador.Idreclutamiento;
                sqlcmd.Parameters.Add(parrecluta);

                SqlParameter parinstancia = new SqlParameter();
                parinstancia.ParameterName = "@instancia";
                parinstancia.SqlDbType = SqlDbType.VarChar;
                parinstancia.Size = 50;
                parinstancia.Value = objencuestador.Instancia;
                sqlcmd.Parameters.Add(parinstancia);

                SqlParameter parbase = new SqlParameter();
                parbase.ParameterName = "@basededatos";
                parbase.SqlDbType = SqlDbType.VarChar;
                parbase.Size = 50;
                parbase.Value = objencuestador.Basededatos;
                sqlcmd.Parameters.Add(parbase);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se edito nada";


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

        public string estado(Dencuestador objactor)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spestado_encuestador";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod = new SqlParameter();
                parcod.ParameterName = "@id_encuestador";
                parcod.SqlDbType = SqlDbType.Int;
                parcod.Value = objactor.Idencuestador;
                sqlcmd.Parameters.Add(parcod);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = 50;
                parestado.Value = objactor.Estado;
                sqlcmd.Parameters.Add(parestado);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se edito";



            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return rpta;

        }


        public string eliminar(Dencuestador objactor)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speliminar_encuestador";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parciactor = new SqlParameter();
                parciactor.ParameterName = "@id_encuestador";
                parciactor.SqlDbType = SqlDbType.Int;
                parciactor.Value = objactor.Idencuestador;
                sqlcmd.Parameters.Add(parciactor);



                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se elimino nada";


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
            DataTable dataresul = new DataTable("encuestador");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_encuestador";
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

        public int codiduplicado(Dencuestador objactor)
        {
            int rpta = 0;

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spcodiduplicado_encuestador";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parduplicado = new SqlParameter();
                parduplicado.ParameterName = "@id_encuestador";
                parduplicado.SqlDbType = SqlDbType.Int;
                parduplicado.Value = objactor.Idencuestador;
                sqlcmd.Parameters.Add(parduplicado);
                //el parametro executescalar sirve para comparar de todos los registros contados y de vuelve una sola fila
                rpta = Convert.ToInt32(sqlcmd.ExecuteScalar());

            }
            catch (Exception)
            {


            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }


        public DataTable mostrar_solo_pregunta()
        {
            DataTable dataresul = new DataTable("pregunta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_solo_pregunta";
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


        public DataTable estadostodos(Dreclutamiento objactor)
        {
            DataTable datoscategoria = new DataTable("encuestador");

            SqlConnection sqlcone = new SqlConnection();

            try
            {
                sqlcone.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcone;
                sqlcmd.CommandText = "spestadostodos_encuestador";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parbuscar = new SqlParameter();
                parbuscar.ParameterName = "@estado";
                parbuscar.SqlDbType = SqlDbType.VarChar;
                parbuscar.Value = objactor.Estado;
                sqlcmd.Parameters.Add(parbuscar);

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(datoscategoria);


            }
            catch (Exception)
            {

                datoscategoria = null;
            }

            return datoscategoria;

        }
    }
}
