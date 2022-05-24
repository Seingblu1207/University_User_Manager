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
            //Declaramos las variables usadas en el método
            string actividad = "";
            string monitor = "";
            decimal nota = 0;

            string titulo = "";
            string director = "";
            string nota_cua = "";
            string evaluador1 = "";
            string evaluador2 = "";
            string fecha = "";
            DateTime fecha_date;
            string requisito = "";

            //Booleano para identificar si la opción seleccionada fue correcta (Hay varios repartidos por el codigo)
            Boolean mal1 = false;

            //Imprimimos el menú y leemos la opción.
            Console.WriteLine("1. pregrado - 2. posgrado");//No hecho el menú bonito jaja, ayudame con eso
            string opcion1 = Console.ReadLine();

            //Ciclo dowhile para que entre al switch, si hay una opción incorrecta repetirá el ciclo, sino saldrá sin problemas
            do
            {

                switch (opcion1)
                {

                    case "1":
                        //Imprime el menú de el requisito del estudiante de pregrado y lee la opción
                        Console.WriteLine("1. practica - 2. pasantia investigativa - 3. plan de negocios");//este es otro menú, Ponle las opciones que aparecen en el switch, case 1, 2 y 3
                        string opcion2 = Console.ReadLine();
                        Boolean mal2 = false;
                        do
                        {
                            switch (opcion2)
                            {

                                case "1":

                                    mal2 = false;
                                    actividad = "Practica";
                                    break;

                                case "2":

                                    mal2 = false;
                                    actividad = "Pasantía investigativa";
                                    break;

                                case "3":

                                    mal2 = false;
                                    actividad = "Plan de negocios";
                                    break;

                                default:

                                    mal1 = true;
                                    Console.WriteLine("Seleccione una opción de las mostradas.");
                                    break;

                            }
                        }
                        while (mal2);
                        Console.WriteLine("Ingrese el nombre del monitor:");
                        monitor = Console.ReadLine();

                        Boolean mal3 = true;
                        do
                        {
                            string aux_nota;
                            Console.WriteLine("Ingrese la nota:");
                            aux_nota = Console.ReadLine();


                            //Verifica que lo que se haya ingresado sea un numero, si no repite el ciclo
                            mal3 = Decimal.TryParse(aux_nota, out nota);

                            //Verifica que la nota sea un número entre 0 y 5
                            if (nota >= 0 || nota <= 5)
                                mal3 = true;

                            if (nota < 0 || nota > 5)
                            {
                                mal3 = false;
                                Console.WriteLine("La nota debe ser entre 0 y 5.");
                            }
                        }
                        while (!mal3);
                        //Se colocan los datos ingresados en el resultado final
                        //Aparte, se redondea la nota a dos decimales
                        requisito = actividad + " | " + monitor + " | " + decimal.Round(nota, 2);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el titulo de la tesis:");
                        titulo = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del director:");
                        director = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del evaluador 1:");
                        evaluador1 = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del evaluador 2:");
                        evaluador2 = Console.ReadLine();

                        Boolean mal4 = false;
                        do
                        {
                            Console.WriteLine("Ingrese la nota cualitativa de la tesis (Aprueba o Desaprueba):");
                            nota_cua = Console.ReadLine();
                            //Se verifica que lo ingresado coincida con las opciones
                            if (nota_cua.Equals("Aprueba") || nota_cua.Equals("Desaprueba"))

                                mal4 = false;
                            else
                            {
                                mal4 = true;
                                Console.WriteLine("Ingrese si Aprueba o Desaprueba");
                            }
                        }
                        while (mal4);

                        Boolean mal5 = true;
                        do
                        {
                            Console.WriteLine("Ingrese la fecha de sustentacion (dd/MM/yyyy):");
                            fecha = Console.ReadLine();
                            //Comprueba que lo ingresado pueda entrar en el formato de fecha
                            mal5 = DateTime.TryParse(fecha, out fecha_date);

                        }
                        while (!mal5);

                        requisito = titulo + " | " + director + " | " + evaluador1 + " | " + evaluador2 + " | " + nota_cua + " | " + fecha;

                        break;
                    default:
                        mal1 = true;
                        Console.WriteLine("Seleccione una de las opciones mostradas.");
                        break;

                }
            }
            while (mal1);

            return requisito;
        }


    }
}
