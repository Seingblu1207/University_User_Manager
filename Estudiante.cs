using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    abstract class Estudiante : Miembro
    {

        private string nombre_acudiente;

        public Estudiante(string nombre, string id, string fecha_nacimiento, string nombre_acudiente) : base(nombre, id, fecha_nacimiento)
        {
        }

        static public string MenuRequisito()
        {

            string requisito = "";

            //Booleano para identificar si la opción seleccionada fue correcta
            Boolean mal = false;

            //Imprimimos el menú y leemos la opción.
            Console.WriteLine("1. pregrado - 2. posgrado");
            string opcion = Console.ReadLine();

            //Ciclo dowhile para que entre al switch, si hay una opción incorrecta repetirá el ciclo, sino saldrá sin problemas
            do
            {

                switch (opcion)
                {

                    case "1":

                        requisito = Pregrado.MenuPregrado();
                        break;

                    case "2":

                        requisito = Postgrado.MenuPosgrado();
                        break;

                    default:

                        mal = true;
                        Console.WriteLine("Seleccione una de las opciones mostradas");
                        opcion = Console.ReadLine();
                        break;

                }

            }

            while (mal);

            return requisito;
        }
    }
}
