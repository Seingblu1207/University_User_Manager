using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    internal class Historia
    {

        private uint año;
        private ushort periodo;
        static private List<Evaluacion> l_evaluacion;


        public Historia(uint año, ushort periodo)
        {
            this.año = año;
            this.periodo = periodo;
        }

        public uint Año { get => año; set => año = value; }
        public List<Evaluacion> L_evaluacion { get => l_evaluacion; }
        public ushort Periodo { get => periodo; set => periodo = value; }

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

            if (linea != null)
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
            uint contadorGana = 0, contadorPierde = 0;
            Asignatura elem_asignatura;
            string n_asignatura;
            Evaluacion elem_evaluacion;
            string n_evaluacion = "";
            double nota = 0;
            uint ganaAsignatura = 0;
            uint pierdeAsignatura = 0;
            uint asig_gan = 0;
            uint asig_pier = 0;
            string mas_gan = "";
            string mas_per = "";
            uint estudiante_gan = 0;
            uint estudiante_pier = 0;
            foreach (Asignatura element in Institucion.l_Asignatura)
            {
                elem_asignatura = element;
                n_asignatura = elem_asignatura.Nombre;

                foreach (Evaluacion elemento in l_evaluacion)
                {

                    elem_evaluacion = elemento;
                    n_evaluacion = elem_evaluacion.Asignatura;
                    nota = elem_evaluacion.Nota_final;

                    if (n_asignatura == n_evaluacion)
                    {


                        if (nota < 3)
                            contadorPierde++;
                        else if (nota >= 3)
                            contadorGana++;
                    }


                }
                ganaAsignatura = contadorGana;
                pierdeAsignatura = contadorPierde;
                contadorPierde = 0;
                contadorGana = 0;

                if (asig_gan < ganaAsignatura)
                {
                    asig_gan = ganaAsignatura;
                    mas_gan = n_asignatura;
                }
                if (asig_pier < pierdeAsignatura)
                {
                    asig_pier = pierdeAsignatura;
                    mas_per = n_asignatura;
                }



            }
            foreach (Evaluacion elemento in l_evaluacion)
            {

                elem_evaluacion = elemento;
                n_evaluacion = elem_evaluacion.Asignatura;
                nota = elem_evaluacion.Nota_final;
                if (nota < 3)
                    estudiante_pier++;
                else if (nota >= 3)
                    estudiante_gan++;

            }

            recorrido = estudiante_gan + " estudiantes ganaron evaluaciones y " + estudiante_pier + " perdieron evaluaciones \n" + "La asignatura que más perdieron fue " + mas_per + ", con un total de " + pierdeAsignatura + " evaluaciones perdidas.\n La asignatura que más ganaron fue " + mas_gan + ", con un total de " + ganaAsignatura + " evaluaciones ganadas";

            return recorrido;
        }

    }
}
