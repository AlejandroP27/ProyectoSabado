using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Dcliente
    {
        private int _id_clien;
        private string _nombre;
        private string _telefono;
        private string _direccion;
        private DateTime _fecha_crea;
        private DateTime _fecha_sinc;
        private string _estado;


        public int id_clien { get => _id_clien; set => _id_clien = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public DateTime fecha_crea { get => _fecha_crea; set => _fecha_crea = value; }
        public DateTime fecha_sinc { get => _fecha_sinc; set => _fecha_sinc = value; }
        public string estado { get => _estado; set => _estado = value; }

        public Dcliente(int id_clien, string nombre, string telefono, string direccion, DateTime fecha_crea, DateTime fecha_sinc, string estado)
        {
            this.id_clien = id_clien;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fecha_crea = fecha_crea;
            this.fecha_sinc = fecha_sinc;
            this.estado = estado;
        }

        public Dcliente()
        {

        }
        public string Insertar(Dcliente objcliente)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spinsertar_cliente";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_cliente = new SqlParameter();
                parci_cliente.ParameterName = "@id_clien";
                parci_cliente.SqlDbType = SqlDbType.Int;
                parci_cliente.Value = objcliente.id_clien;
                sqlcmd.Parameters.Add(parci_cliente);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 500;
                parnombre.Value = objcliente.nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@telefono";
                partelefono.SqlDbType = SqlDbType.Int;
           
                partelefono.Value = objcliente.telefono;
                sqlcmd.Parameters.Add(partelefono);

                SqlParameter pardirec = new SqlParameter();
                pardirec.ParameterName = "@direccion";
                pardirec.SqlDbType = SqlDbType.VarChar;
                pardirec.Size = 50;
                pardirec.Value = objcliente.direccion;
                sqlcmd.Parameters.Add(pardirec);

                SqlParameter ParFechac = new SqlParameter();
                ParFechac.ParameterName = "@fecha_crea";
                ParFechac.SqlDbType = SqlDbType.Date;
                ParFechac.Value = objcliente.fecha_crea;
                sqlcmd.Parameters.Add(ParFechac);

                SqlParameter ParFechas = new SqlParameter();
                ParFechas.ParameterName = "@fecha_sinc";
                ParFechas.SqlDbType = SqlDbType.Date;
                ParFechas.Value = objcliente.fecha_sinc;
                sqlcmd.Parameters.Add(ParFechas);



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



        public string editar(Dcliente objcliente)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speditar_cliente";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parci_cliente = new SqlParameter();
                parci_cliente.ParameterName = "@id_clien";
                parci_cliente.SqlDbType = SqlDbType.Int;
                parci_cliente.Value = objcliente.id_clien;
                sqlcmd.Parameters.Add(parci_cliente);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = objcliente.nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@telefono";
                partelefono.SqlDbType = SqlDbType.VarChar;
                partelefono.Size = 50;
                partelefono.Value = objcliente.telefono;
                sqlcmd.Parameters.Add(partelefono);

                SqlParameter pardirec = new SqlParameter();
                pardirec.ParameterName = "@direccion";
                pardirec.SqlDbType = SqlDbType.VarChar;
                pardirec.Size = 50;
                pardirec.Value = objcliente.direccion;
                sqlcmd.Parameters.Add(pardirec);

                SqlParameter ParFechac = new SqlParameter();
                ParFechac.ParameterName = "@fecha_crea";
                ParFechac.SqlDbType = SqlDbType.Date;
                ParFechac.Value = objcliente.fecha_crea;
                sqlcmd.Parameters.Add(ParFechac);

                SqlParameter ParFechas = new SqlParameter();
                ParFechas.ParameterName = "@fecha_sinc";
                ParFechas.SqlDbType = SqlDbType.Date;
                ParFechas.Value = objcliente.fecha_sinc;
                sqlcmd.Parameters.Add(ParFechas);


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

        public string estadocliente(Dcliente objcliente)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spestado_cliente";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod = new SqlParameter();
                parcod.ParameterName = "id_clien";
                parcod.SqlDbType = SqlDbType.Int;
                parcod.Value = objcliente.id_clien;
                sqlcmd.Parameters.Add(parcod);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = 50;
                parestado.Value = objcliente.estado;
                sqlcmd.Parameters.Add(parestado);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se edito";



            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return rpta;

        }


        public string eliminar(Dcliente objcliente)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speliminar_cliente";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parciactor = new SqlParameter();
                parciactor.ParameterName = "@id_client";
                parciactor.SqlDbType = SqlDbType.Int;
                parciactor.Value = objcliente.id_clien;
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
            DataTable dataresul = new DataTable("cliente");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_cliente";
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

        public int codiduplicado(Dcliente objcliente)
        {
            int rpta = 0;

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spcodiduplicado_cliente";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parduplicado = new SqlParameter();
                parduplicado.ParameterName = "id_clien";
                parduplicado.SqlDbType = SqlDbType.Int;
                parduplicado.Value = objcliente.id_clien;
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


        public DataTable estadostodos(Dcliente objcliente)
        {
            DataTable datoscategoria = new DataTable("cliente");

            SqlConnection sqlcone = new SqlConnection();

            try
            {
                sqlcone.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcone;
                sqlcmd.CommandText = "spestadostodos_cliente";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parbuscar = new SqlParameter();
                parbuscar.ParameterName = "@estado";
                parbuscar.SqlDbType = SqlDbType.VarChar;
                parbuscar.Value = objcliente.estado;
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

