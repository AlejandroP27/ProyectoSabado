using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Nencuestador
    {
        public static string insertar(int idencuestador, int idencuesta, int idrecluta, string instancia, string basede)
        {
            Dencuestador obj = new Dencuestador();
            obj.Idencuestador = idencuestador;
            obj.Idencuesta = idencuesta;
            obj.Idreclutamiento = idrecluta;
            obj.Instancia = instancia;
            obj.Basededatos = basede;

            return obj.insertar(obj);

        }

        public static string editar(int idencuestador, int idencuesta, int idrecluta, string instancia, string basede, DateTime fecha_crea)
        {
            Dencuestador obj = new Dencuestador();
            obj.Idencuestador = idencuestador;
            obj.Idencuesta = idencuesta;
            obj.Idreclutamiento = idrecluta;
            obj.Instancia = instancia;
            obj.Basededatos = basede;
            obj.Fecha_crea = fecha_crea;

            return obj.editar(obj);

        }

        public static string eliminar(int id_reclu)
        {

            Dencuestador obj = new Dencuestador();
            obj.Idencuestador = id_reclu;
            return obj.eliminar(obj);

        }

        public static string estado(int id_reclu, string estado)
        {
            Dencuestador obj = new Dencuestador();

            obj.Idencuestador = id_reclu;
            obj.Estado = estado;

            return obj.estado(obj);
        }


        public static DataTable mostrar()
        {
            return new Dencuestador().mostrar();
        }


        //public static DataTable buscarnombre(string txtbuscar)
        //{
        //    Dcliente obj = new Dcliente();

        //    obj.Txtbuscar = txtbuscar;
        //    return obj.buscarnombre(obj);
        //}

        public static int duplicado(int id_reclu)
        {
            Dencuestador obj = new Dencuestador();

            obj.Idencuestador = id_reclu;
            return obj.codiduplicado(obj);
        }

        //public static DataTable estadotodos(string estado)
        //{
        //    Dencuestador obj = new Dencuestador();
        //    obj.Estado = estado;
        //    return obj.estadostodos(obj);
        //}
    }
}
