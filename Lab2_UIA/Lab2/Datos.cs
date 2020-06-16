using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab2
{
    public class Datos
    {
        private String vname="Maikel Zamora Morera";
        public String vnombre { get { return vname; } }

        private String vusuario = "Zamora12";
        public String vuser {get { return vusuario; } }

        private String vpassx = "123456789";
        public String vpassword {get { return vpassx; } }

        public static double multiplicacion(double a)
        {
            return a * 2;
        }


        public static void escribirBitacora(string textoGuardar)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\Lab2 PrograIV\bitacoraSistema.txt", true))
            {
                objStrem.WriteLine(textoGuardar);
                objStrem.Flush(); //Guardar en el archivo bitacoraSistema.txt
            }
            //    //El recurso llamado objStrem en esta linea ya no existe en memoria
        }
    }
}