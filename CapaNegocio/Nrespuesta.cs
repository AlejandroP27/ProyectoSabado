using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public   class Nrespuesta
    {
        public static string insertar(int idrespuesta, string res1, string res2, string res3, string res4, string res5, string res6,int id_pregunta)
        {
            Drespuesta obj = new Drespuesta();
            obj.Id_respuesta = idrespuesta;
            obj.Respuesta_1 = res1;
            obj.Respuesta_2 = res2;
            obj.Respuesta_3 = res3;
            obj.Respuesta_4 = res4;
            obj.Respuesta_5 = res5;
            obj.Respuesta_6 = res6;
            obj.Id_pregunta = id_pregunta;

            return obj.insertar(obj);

        }

        public static DataTable mostrar()
        {
            return new Drespuesta().mostrar();
        }


        public static DataTable mostrarpregunta()
        {
            return new Drespuesta().mostrarpregunta();
        }

        public static DataTable mostrarsincronizar()
        {
            return new Drespuesta().mostrarsincronizar();
        }

        public static DataTable mostrarsincronizar2()
        {
            return new Drespuesta().mostrarsincronizar2();
        }

        public static DataTable mostrarsincronizar3()
        {
            return new Drespuesta().mostrarsincronizar3();
        }
    }
}
