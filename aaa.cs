using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    internal class aaa
    {
        static private List<Evaluacion> l_evaluacion;
        static private List<Asignatura> l_Asignatura;
        
        public static void CargarHistoria()
        {
            var ruta = "C:\\Users\\oveor\\Desktop\\TAREASSSSS\\TEORIA DE LA COMPUTACION\\Codde\\Clases\\recursos\\TextFile2.txt";

            StreamReader archivo = new StreamReader(ruta);
            StreamWriter archivo2 = new StreamWriter(ruta);

            string[] v_historia;
            string[] v_evaluacion;
            Historia historia;
            Evaluacion evaluacion;

            string linea;

            linea = archivo.ReadLine();

            l_evaluacion.Clear();

            if(linea != null)
            {
                v_historia = linea.Split('|');

                historia = new Historia(uint.Parse(v_historia[0]), ushort.Parse(v_historia[1]));

                linea = archivo.ReadLine();

                while (linea != null)
                {
                    v_evaluacion = linea.Split('|');

                    evaluacion = new Evaluacion(v_evaluacion[0], v_evaluacion[1], double.Parse(v_evaluacion[2]));

                    historia.L_evaluacion.Add(evaluacion);

                    linea = archivo.ReadLine();
                }
            }

            

        }

        public static string RecorrerHistoria()
        {
            string recorrido = "";
            foreach(Asignatura element in l_Asignatura)
            {
                

            }



            return recorrido;
        }

        
    }
}
