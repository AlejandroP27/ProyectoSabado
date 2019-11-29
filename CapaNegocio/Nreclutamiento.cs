using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nreclutamiento
    {

        public static string insertar(int id_reclu, string nombre, string apellido, string direccion, int ci, DateTime fecha_naci, string nivel_acade, int celular)
        {
            Dreclutamiento obj = new Dreclutamiento();
            obj.Id_reclu = id_reclu;
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Direccion = direccion;
            obj.Ci = ci;
            obj.Fecha_naci = fecha_naci;
            obj.Nivel_acade = nivel_acade;
            obj.Celular = celular;

            return obj.insertar(obj);

        }

        public static string editar(int id_reclu, string nombre, string apellido, string direccion, int ci, DateTime fecha_naci, string nivel_acade, int celular)
        {
            Dreclutamiento obj = new Dreclutamiento();
            obj.Id_reclu = id_reclu;
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Direccion = direccion;
            obj.Ci = ci;
            obj.Fecha_naci = fecha_naci;
            obj.Nivel_acade = nivel_acade;
            obj.Celular = celular;

            return obj.editar(obj);

        }

        public static string eliminar(int id_reclu)
        {

            Dreclutamiento obj = new Dreclutamiento();
            obj.Id_reclu = id_reclu;
            return obj.eliminar(obj);

        }

        public static string estado(int id_reclu, string estado)
        {
            Dreclutamiento obj = new Dreclutamiento();

            obj.Id_reclu = id_reclu;
            obj.Estado = estado;

            return obj.estado(obj);
        }


        public static DataTable mostrar()
        {
            return new Dreclutamiento().mostrar();
        }


        //public static DataTable buscarnombre(string txtbuscar)
        //{
        //    Dcliente obj = new Dcliente();

        //    obj.Txtbuscar = txtbuscar;
        //    return obj.buscarnombre(obj);
        //}

        public static int duplicado(int id_reclu)
        {
            Dreclutamiento obj = new Dreclutamiento();

            obj.Id_reclu = id_reclu;
            return obj.codiduplicado(obj);
        }

        public static DataTable estadotodos(string estado)
        {
            Dreclutamiento obj = new Dreclutamiento();
            obj.Estado = estado;
            return obj.estadostodos(obj);
        }
    }
}
