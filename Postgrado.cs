using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Postgrado : Estudiante
    {

        private string[,] datos = new string[4, 5];

        public Postgrado(string nombre, string id, string fecha_nacimiento, string nombre_acudiente, string[,] datos) : base(nombre, id, fecha_nacimiento, nombre_acudiente)
        {
        }

        public string[,] Datos { get => datos; set => datos = value; }
        static public string MenuPosgrado()
        {
            string titulo = "";
            string director = "";
            string nota_cua = "";
            string evaluador1 = "";
            string evaluador2 = "";
            string fecha = "";
            DateTime fecha_date;
            string requisito = "";

            Boolean mal = false;

            Console.WriteLine("Ingrese el titulo de la tesis:");
            titulo = Console.ReadLine();
            do
            {
                mal = false;


                if (!string.IsNullOrEmpty(titulo) && !string.IsNullOrWhiteSpace(titulo))
                {
                    Console.WriteLine("Ingrese el nombre del director:");
                    director = Console.ReadLine();
                    do
                    {
                        mal = false;


                        if (!string.IsNullOrEmpty(director) && !string.IsNullOrWhiteSpace(director))
                        {
                            Console.WriteLine("Ingrese el nombre del evaluador 1:");
                            evaluador1 = Console.ReadLine();
                            do
                            {
                                mal = false;


                                if (!string.IsNullOrEmpty(evaluador1) && !string.IsNullOrWhiteSpace(evaluador1))
                                {
                                    Console.WriteLine("Ingrese el nombre del evaluador 2:");
                                    evaluador2 = Console.ReadLine();
                                    do
                                    {
                                        mal = false;


                                        if (!string.IsNullOrEmpty(evaluador2) && !string.IsNullOrWhiteSpace(evaluador2))
                                        {

                                            Console.WriteLine("Correcto! Presione enter para continuar");
                                            Console.ReadKey();

                                        }

                                        else Console.WriteLine("ERROR: Por favor ingrese un evaluador valido");
                                        evaluador2 = Console.ReadLine();
                                        mal = true;

                                    }
                                    while (mal);

                                }

                                else Console.WriteLine("ERROR: Por favor ingrese un evaluador valido");
                                evaluador1 = Console.ReadLine();
                                mal = true;
                            }
                            while (mal);

                        }

                        else Console.WriteLine("ERROR: Por favor ingrese director valido");
                        director = Console.ReadLine();
                        mal = true;
                    }
                    while (mal);

                }

                else Console.WriteLine("ERROR: Por favor ingrese un titulo valido");
                titulo = Console.ReadLine();
                mal = true;
            }
            while (mal);

            mal = false;
            Console.WriteLine("Ingrese la nota cualitativa de la tesis (Aprueba o Desaprueba):");
            nota_cua = Console.ReadLine();
            do
            {


                //Se verifica que lo ingresado coincida con las opciones
                if (nota_cua.Equals("Aprueba") || nota_cua.Equals("Desaprueba"))

                    mal = false;
                else
                {
                    mal = true;
                    Console.WriteLine("Ingrese si Aprueba o Desaprueba");
                    nota_cua = Console.ReadLine();
                }
            }
            while (mal);

            mal = true;
            do
            {
                Console.WriteLine("Ingrese la fecha de sustentacion (dd/MM/yyyy):");
                fecha = Console.ReadLine();
                //Comprueba que lo ingresado pueda entrar en el formato de fecha
                mal = DateTime.TryParse(fecha, out fecha_date);

            }
            while (!mal);

            requisito = titulo + " | " + director + " | " + evaluador1 + " | " + evaluador2 + " | " + nota_cua + " | " + fecha;

            return requisito;
        }
    }
}
