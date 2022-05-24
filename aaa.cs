using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class aaa
    {
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

                        requisito = MenuPregrado();
                        break;

                    case "2":

                        requisito = MenuPosgrado();
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

            //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa

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
            do
            {
                string aux_nota;
                Console.WriteLine("Ingrese la nota:");
                aux_nota = Console.ReadLine();


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
            }
            while (!mal);
            //Se colocan los datos ingresados en el resultado final
            //Aparte, se redondea la nota a dos decimales
            requisito = actividad + " | " + monitor + " | " + decimal.Round(nota, 2);
            return requisito;
        }

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
            do
            {
                mal = false;
                Console.WriteLine("Ingrese el titulo de la tesis:");
                titulo = Console.ReadLine();

                if (!string.IsNullOrEmpty(titulo) && !string.IsNullOrWhiteSpace(titulo))
                {

                    do
                    {
                        mal = false;
                        Console.WriteLine("Ingrese el nombre del director:");
                        director = Console.ReadLine();

                        if (!string.IsNullOrEmpty(director) && !string.IsNullOrWhiteSpace(director))
                        {

                            do
                            {
                                mal = false;
                                Console.WriteLine("Ingrese el nombre del evaluador 1:");
                                evaluador1 = Console.ReadLine();

                                if (!string.IsNullOrEmpty(evaluador1) && !string.IsNullOrWhiteSpace(evaluador1))
                                {

                                    do
                                    {
                                        mal = false;
                                        Console.WriteLine("Ingrese el nombre del evaluador 2:");
                                        evaluador2 = Console.ReadLine();

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
            do
            {

                Console.WriteLine("Ingrese la nota cualitativa de la tesis (Aprueba o Desaprueba):");
                nota_cua = Console.ReadLine();
                //Se verifica que lo ingresado coincida con las opciones
                if (nota_cua.Equals("Aprueba") || nota_cua.Equals("Desaprueba"))

                    mal = false;
                else
                {
                    mal = true;
                    Console.WriteLine("Ingrese si Aprueba o Desaprueba");
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
