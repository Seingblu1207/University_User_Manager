using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Pregrado : Estudiante
    {
        
        private string[] datos = new string[4];

        public Pregrado(string nombre, string id, string fecha_nacimiento, string nombre_acudiente, string[] datos) : base(nombre, id, fecha_nacimiento, nombre_acudiente)
        {
        }

        public string[] Datos { get => datos; set => datos = value; }

        static public string MenuPregrado()
        {
            //Declaramos las variables usadas en el método
            string actividad = "";
            string monitor = "";
            decimal nota = 0;
            string requisito = "";
            Boolean mal = false;

            //Imprime el menú de el requisito del estudiante de pregrado y lee la opción
            Console.WriteLine("1. practica - 2. pasantia investigativa - 3. plan de negocios");//este es otro menú, Ponle las opciones que aparecen en el switch, case 1, 2 y 3
            string opcion = Console.ReadLine();
            mal = false;
            do
            {
                switch (opcion)
                {

                    case "1":
                        mal = false;
                        actividad = "Practica";
                        break;
                    case "2":
                        mal = false;
                        actividad = "Pasantía investigativa";
                        break;
                    case "3":
                        mal = false;
                        actividad = "Plan de negocios";
                        break;
                    default:
                        mal = true;
                        Console.WriteLine("Seleccione una opción de las mostradas.");
                        opcion = Console.ReadLine();
                        break;

                }
            }
            while (mal);

            mal = false;

            Console.WriteLine("Ingrese el nombre del monitor:");
            monitor = Console.ReadLine();

            do
            {

                if (!string.IsNullOrEmpty(monitor) && !string.IsNullOrWhiteSpace(monitor))
                    mal = false;
                else
                {
                    Console.WriteLine("ERROR: Por favor ingrese un monitor valido");
                    monitor = Console.ReadLine();
                    mal = true;
                }

            }
            while (mal);


            mal = true;

            string aux_nota;
            Console.WriteLine("Ingrese la nota:");
            aux_nota = Console.ReadLine();
            do
            {



                //Verifica que lo que se haya ingresado sea un numero, si no repite el ciclo
                mal = Decimal.TryParse(aux_nota, out nota);
                if (mal)
                {
                    //Verifica que la nota sea un número entre 0 y 5
                    if (nota >= 0 || nota <= 5)
                        mal = true;

                    if (nota < 0 || nota > 5)
                    {
                        mal = false;
                        Console.WriteLine("La nota debe ser entre 0 y 5.");
                    }
                }
                aux_nota = Console.ReadLine();
            }
            while (!mal);
            //Se colocan los datos ingresados en el resultado final
            //Aparte, se redondea la nota a dos decimales
            requisito = actividad + " | " + monitor + " | " + decimal.Round(nota, 2);
            return requisito;
        }
    }
}
