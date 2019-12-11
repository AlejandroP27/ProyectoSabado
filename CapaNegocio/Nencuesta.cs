using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nencuesta
    {


        public static string insertar(int id_encuesta, int idcliente, string nombre, string descripcion, DateTime fecha_ini, DateTime fecha_fin)
        {
            Dencuesta obj = new Dencuesta();

            obj.Id_encuesta = id_encuesta;
            obj.Idcliente = idcliente;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.Fecha_ini = fecha_ini;
            obj.Fecha_fin = fecha_fin;
            
        

            return obj.Insertar(obj);

        }

        public static string editar(int id_encuesta, int id_cliente, string nombre, string descripcion, DateTime fecha_ini, DateTime fecha_fin)
        {
            Dencuesta obj = new Dencuesta();
            obj.Id_encuesta = id_encuesta;
            obj.Idcliente = id_cliente;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.Fecha_ini = fecha_ini;
            obj.Fecha_fin = fecha_fin;


            return obj.editar(obj);

        }

        public static string eliminar(int id_encuesta)
        {

            Dencuesta obj = new Dencuesta();
            obj.Id_encuesta = id_encuesta;
            return obj.eliminar(obj);

        }

        public static string estado(int idencuesta, string estado)
        {
            Dencuesta obj = new Dencuesta();

            obj.Id_encuesta = idencuesta;
            obj.Estado = estado;

            return obj.estadoencuesta(obj);
        }


        public static DataTable mostrar()
        {
            return new Dencuesta().mostrar();
        }


        //public static DataTable buscarnombre(string txtbuscar)
        //{
        //    Dencuesta obj = new Dencuesta();

        //    obj.Txtbuscar = txtbuscar;
        //    return obj.buscarnombre(obj);
        //}

        public static int duplicado(int idencuesta)
        {
            Dencuesta obj = new Dencuesta();

            obj.Id_encuesta = idencuesta;
            return obj.codiduplicado(obj);
        }

        public static DataTable estadotodos(string estado)
        {
            Dencuesta obj = new Dencuesta();
            obj.Estado = estado;
            return obj.estadostodos(obj);
        }
    }
}
