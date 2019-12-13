using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Dencuesta
    {
        private int _id_encuesta;
        private int _idcliente;
        private string _nombre;
        private string descripcion;
        private DateTime _fecha_ini;
        private DateTime _fecha_fin;
        private DateTime _fecha_crea;
        private string _estado;

        public int Id_encuesta { get => _id_encuesta; set => _id_encuesta = value; }
        public int Idcliente { get => _idcliente; set => _idcliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_ini { get => _fecha_ini; set => _fecha_ini = value; }
        public DateTime Fecha_fin { get => _fecha_fin; set => _fecha_fin = value; }
        public DateTime Fecha_crea { get => _fecha_crea; set => _fecha_crea = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public Dencuesta(int id_encuesta, int idcliente, string nombre, string descripcion, DateTime fecha_ini, DateTime fecha_fin, DateTime fecha_crea, DateTime fecha_sinc, string estado)
        {
            this.Id_encuesta = id_encuesta;
            this.Idcliente = idcliente;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Fecha_ini = fecha_ini;
            this.Fecha_fin = fecha_fin;
            this.Fecha_crea = fecha_crea;
            this.Estado = estado;
        }

        public Dencuesta()
        {

        }
        public string Insertar(Dencuesta objencuesta)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spinsertar_encuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_encuesta = new SqlParameter();
                parci_encuesta.ParameterName = "@id_encuesta";
                parci_encuesta.SqlDbType = SqlDbType.Int;
                parci_encuesta.Value = objencuesta.Id_encuesta;
                sqlcmd.Parameters.Add(parci_encuesta);

                SqlParameter parci_encuestaa = new SqlParameter();
                parci_encuestaa.ParameterName = "@idcliente";
                parci_encuestaa.SqlDbType = SqlDbType.Int;
                parci_encuestaa.Value = objencuesta.Idcliente;
                sqlcmd.Parameters.Add(parci_encuestaa);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = objencuesta.Nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter pardes = new SqlParameter();
                pardes.ParameterName = "@descripcion";
                pardes.SqlDbType = SqlDbType.VarChar;
                pardes.Size = 50;
                pardes.Value = objencuesta.Descripcion;
                sqlcmd.Parameters.Add(pardes);

                SqlParameter ParFechac = new SqlParameter();
                ParFechac.ParameterName = "@fecha_ini";
                ParFechac.SqlDbType = SqlDbType.DateTime;
                ParFechac.Value = objencuesta.Fecha_ini;
                sqlcmd.Parameters.Add(ParFechac);

                SqlParameter ParFechacfin = new SqlParameter();
                ParFechacfin.ParameterName = "@fecha_fin";
                ParFechacfin.SqlDbType = SqlDbType.DateTime;
                ParFechacfin.Value = objencuesta.Fecha_fin;
                sqlcmd.Parameters.Add(ParFechacfin);

          


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



        public string editar(Dencuesta objencuesta)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speditar_encuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_encuesta = new SqlParameter();
                parci_encuesta.ParameterName = "@id_encuesta";
                parci_encuesta.SqlDbType = SqlDbType.Int;
                parci_encuesta.Value = objencuesta.Id_encuesta;
                sqlcmd.Parameters.Add(parci_encuesta);

                SqlParameter parci_encuestaa = new SqlParameter();
                parci_encuestaa.ParameterName = "@id_cliente";
                parci_encuestaa.SqlDbType = SqlDbType.Int;
                parci_encuestaa.Value = objencuesta.Idcliente;
                sqlcmd.Parameters.Add(parci_encuestaa);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = objencuesta.Nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@descripcion";
                partelefono.SqlDbType = SqlDbType.VarChar;
                partelefono.Size = 150;
                partelefono.Value = objencuesta.descripcion;
                sqlcmd.Parameters.Add(partelefono);

                SqlParameter ParFechac = new SqlParameter();
                ParFechac.ParameterName = "@fecha_ini";
                ParFechac.SqlDbType = SqlDbType.Date;
                ParFechac.Value = objencuesta.Fecha_ini;
                sqlcmd.Parameters.Add(ParFechac);

                SqlParameter ParFechacfin = new SqlParameter();
                ParFechac.ParameterName = "@fecha_fin";
                ParFechac.SqlDbType = SqlDbType.Date;
                ParFechac.Value = objencuesta.Fecha_fin;
                sqlcmd.Parameters.Add(ParFechac);

        




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

        public string estadoencuesta(Dencuesta objencuesta)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spestado_encuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod = new SqlParameter();
                parcod.ParameterName = "id_encuesta";
                parcod.SqlDbType = SqlDbType.Int;
                parcod.Value = objencuesta._id_encuesta;
                sqlcmd.Parameters.Add(parcod);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = 50;
                parestado.Value = objencuesta._estado;
                sqlcmd.Parameters.Add(parestado);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se edito";



            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return rpta;

        }


        public string eliminar(Dencuesta objencuesta)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speliminar_encuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parciactor = new SqlParameter();
                parciactor.ParameterName = "@id_encuesta";
                parciactor.SqlDbType = SqlDbType.Int;
                parciactor.Value = objencuesta.Id_encuesta;
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
            DataTable dataresul = new DataTable("encuesta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_encuesta";
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

        public int codiduplicado(Dencuesta objencuesta)
        {
            int rpta = 0;

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spcodiduplicado_encuesta";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parduplicado = new SqlParameter();
                parduplicado.ParameterName = "id_encuesta";
                parduplicado.SqlDbType = SqlDbType.Int;
                parduplicado.Value = objencuesta.Id_encuesta;
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


        public DataTable estadostodos(Dencuesta objencuesta)
        {
            DataTable datoscategoria = new DataTable("encuesta");

            SqlConnection sqlcone = new SqlConnection();

            try
            {
                sqlcone.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcone;
                sqlcmd.CommandText = "spestadostodos_encuesta";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parbuscar = new SqlParameter();
                parbuscar.ParameterName = "@estado";
                parbuscar.SqlDbType = SqlDbType.VarChar;
                parbuscar.Value = objencuesta.Estado;
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
