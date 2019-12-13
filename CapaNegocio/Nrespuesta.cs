using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public   class Nrespuesta
    {
        public static string insertar(int idrespuesta, string res1, string res2, string res3, string res4, string res5, string res6)
        {
            Drespuesta obj = new Drespuesta();
            obj.Id_respuesta = idrespuesta;
            obj.Respuesta_1 = res1;
            obj.Respuesta_2 = res2;
            obj.Respuesta_3 = res3;
            obj.Respuesta_4 = res4;
            obj.Respuesta_5 = res5;
            obj.Respuesta_6 = res6;

            return obj.insertar(obj);

        }
    }
}
