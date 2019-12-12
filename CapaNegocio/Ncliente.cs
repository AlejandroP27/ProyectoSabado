using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Ncliente
    {


        public static string insertar(int id_clien, string nombre, string telefono, string direccion)
        {
            Dcliente obj = new Dcliente();
            obj.id_clien = id_clien;
            obj.nombre = nombre;
            obj.telefono = telefono;
            obj.direccion = direccion;
 
            return obj.Insertar(obj);

        }

        public static string editar(int id_clien, string nombre, string telefono, string direccion, DateTime fecha_crea, DateTime fecha_sinc)
        {
            Dcliente obj = new Dcliente();
            obj.id_clien = id_clien;
            obj.nombre = nombre;
            obj.telefono = telefono;
            obj.direccion = direccion;
            obj.fecha_crea = fecha_crea;
            obj.fecha_sinc = fecha_sinc;

            return obj.editar(obj);

        }

        public static string eliminar(int id_clien)
        {

            Dcliente obj = new Dcliente();
            obj.id_clien = id_clien;
            return obj.eliminar(obj);

        }

        public static string estado(int id_clien, string estado)
        {
            Dcliente obj = new Dcliente();

            obj.id_clien = id_clien;
            obj.estado = estado;

            return obj.estadocliente(obj);
        }


        public static DataTable mostrar()
        {
            return new Dcliente().mostrar();
        }


        //public static DataTable buscarnombre(string txtbuscar)
        //{
        //    Dcliente obj = new Dcliente();

        //    obj.Txtbuscar = txtbuscar;
        //    return obj.buscarnombre(obj);
        //}

        public static int duplicado(int id_clien)
        {
            Dcliente obj = new Dcliente();

            obj.id_clien = id_clien;
            return obj.codiduplicado(obj);
        }

        public static DataTable estadotodos(string estado)
        {
            Dcliente obj = new Dcliente();
            obj.estado = estado;
            return obj.estadostodos(obj);
        }
    }
}
