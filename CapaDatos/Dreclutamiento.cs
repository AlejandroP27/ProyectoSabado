using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class Dreclutamiento
    {
        private int _codi;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _ci;
        private DateTime _fecha_naci;
        private string _nivel_acade;
        private int _celular;
        private DateTime _fecha_crea;
        private string _estado;

        public int Codi { get => _codi; set => _codi = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Ci { get => _ci; set => _ci = value; }
        public DateTime Fecha_naci { get => _fecha_naci; set => _fecha_naci = value; }
        public string Nivel_acade { get => _nivel_acade; set => _nivel_acade = value; }
        public int Celular { get => _celular; set => _celular = value; }
        public DateTime Fecha_crea { get => _fecha_crea; set => _fecha_crea = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public Dreclutamiento(int idreclu, string nombre, string apellido, string direccion, int ci, DateTime fecha_naci, string nivel_acade, int celular, DateTime fecha_crea, string estado)
        {
            this.Codi = idreclu;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Ci = ci;
            this.Fecha_naci = fecha_naci;
            this.Nivel_acade = nivel_acade;
            this.Celular = celular;
            this.Fecha_crea = fecha_crea;
            this.Estado = estado;
        }

        public Dreclutamiento()
        {

        }


        public string insertar(Dreclutamiento objreclutamiento)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spinsertar_reclutamiento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_actor = new SqlParameter();
                parci_actor.ParameterName = "@id_reclu";
                parci_actor.SqlDbType = SqlDbType.Int;
                parci_actor.Value = objreclutamiento.Codi;
                sqlcmd.Parameters.Add(parci_actor);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = objreclutamiento.Nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parapellido = new SqlParameter();
                parapellido.ParameterName = "@apellido";
                parapellido.SqlDbType = SqlDbType.VarChar;
                parapellido.Size = 50;
                parapellido.Value = objreclutamiento.Apellido;
                sqlcmd.Parameters.Add(parapellido);

                SqlParameter pardirec = new SqlParameter();
                pardirec.ParameterName = "@direccion";
                pardirec.SqlDbType = SqlDbType.VarChar;
                pardirec.Size = 50;
                pardirec.Value = objreclutamiento.Direccion;
                sqlcmd.Parameters.Add(pardirec);

                SqlParameter parci_ci = new SqlParameter();
                parci_ci.ParameterName = "@ci";
                parci_ci.SqlDbType = SqlDbType.Int;
                parci_ci.Value = objreclutamiento.Ci;
                sqlcmd.Parameters.Add(parci_ci);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_naci";
                ParFecha.SqlDbType = SqlDbType.DateTime;
                ParFecha.Value = objreclutamiento.Fecha_naci;
                sqlcmd.Parameters.Add(ParFecha);

                SqlParameter parnivel = new SqlParameter();
                parnivel.ParameterName = "@nivel_acade";
                parnivel.SqlDbType = SqlDbType.VarChar;
                parnivel.Size = 50;
                parnivel.Value = objreclutamiento.Nivel_acade;
                sqlcmd.Parameters.Add(parnivel);

                SqlParameter parcelular = new SqlParameter();
                parcelular.ParameterName = "@celular";
                parcelular.SqlDbType = SqlDbType.Int;
                parcelular.Value = objreclutamiento.Celular;
                sqlcmd.Parameters.Add(parcelular);


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



        public string editar(Dreclutamiento objreclutamiento)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speditar_reclutamiento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_actor = new SqlParameter();
                parci_actor.ParameterName = "@id_reclu";
                parci_actor.SqlDbType = SqlDbType.Int;
                parci_actor.Value = objreclutamiento.Codi;
                sqlcmd.Parameters.Add(parci_actor);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = objreclutamiento.Nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parapellido = new SqlParameter();
                parapellido.ParameterName = "@apellido";
                parapellido.SqlDbType = SqlDbType.VarChar;
                parapellido.Size = 50;
                parapellido.Value = objreclutamiento.Apellido;
                sqlcmd.Parameters.Add(parapellido);

                SqlParameter pardirec = new SqlParameter();
                pardirec.ParameterName = "@direccion";
                pardirec.SqlDbType = SqlDbType.VarChar;
                pardirec.Size = 50;
                pardirec.Value = objreclutamiento.Direccion;
                sqlcmd.Parameters.Add(pardirec);

                SqlParameter parci_ci = new SqlParameter();
                parci_ci.ParameterName = "@ci";
                parci_ci.SqlDbType = SqlDbType.Int;
                parci_ci.Value = objreclutamiento.Ci;
                sqlcmd.Parameters.Add(parci_ci);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_naci";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = objreclutamiento.Fecha_naci;
                sqlcmd.Parameters.Add(ParFecha);

                SqlParameter parnivel = new SqlParameter();
                parnivel.ParameterName = "@nivel_acade";
                parnivel.SqlDbType = SqlDbType.VarChar;
                parnivel.Size = 50;
                parnivel.Value = objreclutamiento.Nivel_acade;
                sqlcmd.Parameters.Add(parnivel);

                SqlParameter parcelular = new SqlParameter();
                parcelular.ParameterName = "@celular";
                parcelular.SqlDbType = SqlDbType.Int;
                parcelular.Value = objreclutamiento.Celular;
                sqlcmd.Parameters.Add(parcelular);

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

        public string estado(Dreclutamiento objactor)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spestado_reclutamiento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod = new SqlParameter();
                parcod.ParameterName = "id_reclu";
                parcod.SqlDbType = SqlDbType.Int;
                parcod.Value = objactor.Codi;
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


        public string eliminar(Dreclutamiento objactor)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speliminar_reclutamiento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parciactor = new SqlParameter();
                parciactor.ParameterName = "@id_reclu";
                parciactor.SqlDbType = SqlDbType.Int;
                parciactor.Value = objactor.Codi;
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
            DataTable dataresul = new DataTable("reclutamiento");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_reclutamiento";
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

        public int codiduplicado(Dreclutamiento objactor)
        {
            int rpta = 0;

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spcodiduplicado_reclutamiento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parduplicado = new SqlParameter();
                parduplicado.ParameterName = "id_reclu";
                parduplicado.SqlDbType = SqlDbType.Int;
                parduplicado.Value = objactor.Codi;
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


        public DataTable estadostodos(Dreclutamiento objactor)
        {
            DataTable datoscategoria = new DataTable("reclutamiento");

            SqlConnection sqlcone = new SqlConnection();

            try
            {
                sqlcone.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcone;
                sqlcmd.CommandText = "spestadostodos_reclutamiento";
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
