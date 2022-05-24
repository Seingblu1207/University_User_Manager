using System;
using System.Collections.Generic;

namespace Clases
{
    internal class Institucion
    {

        private List<Evaluacion> l_evaluacion;
        private List<Docente> l_docente;
        private List<Pregrado> l_pregrado;
        private List<Postgrado> l_postgrado;
        private List<Historia> l_Historia;
        private List<Asignatura> l_Asignatura;
        int count_docente = 0;

        internal List<Evaluacion> L_evaluacion { get => l_evaluacion; set => l_evaluacion = value; }
        internal List<Docente> L_docente { get => l_docente; set => l_docente = value; }
        internal List<Pregrado> L_pregrado { get => l_pregrado; set => l_pregrado = value; }
        internal List<Postgrado> L_postgrado { get => l_postgrado; set => l_postgrado = value; }
        internal List<Historia> L_Historia { get => l_Historia; set => l_Historia = value; }
        internal List<Asignatura> L_Asignatura { get => l_Asignatura; set => l_Asignatura = value; }
        public int Count_docente { get => count_docente; set => count_docente = value; }




        //Main que llama al menú
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {

            //Variables apoyo
            string ApoyoS = "";
            bool Error = false;


            Console.WriteLine("----------------- BIENVENIDO AL SISTEMA DE USUARIOS DE LA UPB ----------------- \n" +
                              "\n Si desea ingresar al area administrativa digite '1'" +
                              "\n Si desea ingresar al area de docencia digite '2'" +
                              "\n Si desea ingresar al area estudiantil digite '3'" +
                              "\n Si desea salir del sistema, digite '0'");

            ApoyoS = Console.ReadLine();

            //Comprueba constantemente si la opcion es valida
            do
            {

                switch (ApoyoS)
                {

                    case "1":
                        Console.Clear();
                        Menu_Admin();
                        Error = false;
                        break;

                    case "2":
                        Console.Clear();
                        Menu_Docente();
                        Error = false;
                        break;

                    case "3":
                        Console.Clear();
                        //Menu_Estudiante();
                        aaa.MenuRequisito();
                        Error = false;
                        break;

                    case "0":
                        Error = false;
                        break;

                    default:
                        Error = true;
                        break;
                }

                //Si hay error imprime aviso y lee de nuevo
                if (Error)
                {

                    Console.WriteLine("El valor ingresado no cohincide con los de la lista, ingrese el valor de nuevo");
                    ApoyoS = Console.ReadLine();
                }
            }
            while (Error);
        }
    
        public static void Menu_Admin()
        {

            //Variables apoyo
            string ApoyoS = "";
            bool Error = false;

            Console.WriteLine("BIENVENIDO AL SISTEMA DE ADMINISTRACION" +
                              "\n \n Ingrese el numero de la función que quiere realizar" +
                              "\n 1. Crear un nuevo docente" +
                              "\n 2. Modificar los datos de un docente" +
                              "\n 3. Crear un nuevo estudiante de Pregrado" +
                              "\n 4. Modificar los datos de un estudiante de Pregrado" + 
                              "\n 5. Crear un nuevo estudiante de postgrado" +
                              "\n 6. Modificar los datos de un estudiante de postgrado" + 
                              "\n 7. Crear un nuevo Historial evaluativo" +
                              "\n 8. Modificar los datos de un Historial evaluativo" + 
                              "\n 9. Crear una nueva Asignatura" +
                              "\n 10. Modificar los datos de una Asignatura" +
                              "\n 0. Volver al menu anterior");
            ApoyoS = Console.ReadLine();

            //Comprueba constantemente si la opcion es valida
            do
            {

                switch (ApoyoS)
                {

                    case "1":
                        Console.Clear();
                        Menu_Create_Docente();
                        Error = false;
                        break;

                    case "2":
                        Console.Clear();
                        Error = false;
                        break;

                    case "3":
                        Console.Clear();
                        Error = false;
                        break;

                    case "4":
                        Console.Clear();
                        Error = false;
                        break;

                    case "5":
                        Console.Clear();
                        Error = false;
                        break;

                    case "6":
                        Console.Clear();
                        Error = false;
                        break;

                    case "7":
                        Console.Clear();
                        Error = false;
                        break;

                    case "8":
                        Console.Clear();
                        Error = false;
                        break;

                    case "9":
                        Console.Clear();
                        Error = false;
                        break;

                    case "10":
                        Console.Clear();
                        Error = false;
                        break;

                    case "0":
                        Error = false;
                        Console.Clear();
                        Menu();
                        break;

                    default:
                        Error = true;
                        break;
                }

                //Si hay error imprime aviso y lee de nuevo
                if (Error)
                {

                    Console.WriteLine("El valor ingresado no cohincide con los de la lista, ingrese el valor de nuevo");
                    ApoyoS = Console.ReadLine();
                }
            }
            while (Error);
        }

        public static void Menu_Create_Docente() {

            bool sigo = true;

            while (sigo)
            {
                string Name;
                string Id = "";
                string F_nacimiento = "";
                bool ApoyoB = true;
                string Area = "";
                string ApoyoS = "";

                Console.WriteLine("eo");
                while(ApoyoB)
                {
                    Console.WriteLine("eo 2");
                    Console.WriteLine("¿Cual es el nombre del nuevo docente?");
                    Name = Console.ReadLine();

                    if (!string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name))
                    {

                        while (string.IsNullOrEmpty(Id) || string.IsNullOrWhiteSpace(Id))
                        {

                            Console.WriteLine("¿Cual es el id del nuevo docente?");
                            Id = Console.ReadLine();

                            if (!string.IsNullOrEmpty(Id) && !string.IsNullOrWhiteSpace(Id))
                            {

                                while (string.IsNullOrEmpty(F_nacimiento) || string.IsNullOrWhiteSpace(F_nacimiento))
                                {

                                    Console.WriteLine("¿Cual es la fecha de nacimiento del nuevo docente?");
                                    F_nacimiento = Console.ReadLine();

                                    if (!string.IsNullOrEmpty(F_nacimiento) && !string.IsNullOrWhiteSpace(F_nacimiento))
                                    {

                                        while (string.IsNullOrEmpty(Area) || string.IsNullOrWhiteSpace(Area))
                                        {

                                            Console.WriteLine("¿En que area enseña el nuevo docente?");
                                            Area = Console.ReadLine();

                                            if (!string.IsNullOrEmpty(Area) && !string.IsNullOrWhiteSpace(Area))
                                            {

                                                Console.WriteLine("Lihto");
                                                Console.ReadLine();

                                            }

                                            else Console.WriteLine("ERROR: Por favor ingrese un Area");

                                        }

                                    }

                                    else Console.WriteLine("ERROR: Por favor ingrese una fecha de nacimiento");

                                }

                            }

                            else Console.WriteLine("ERROR: Por favor ingrese un id valido");

                        }

                    }

                    else Console.WriteLine("ERROR: Por favor ingrese un nombre valido");

                    ApoyoB = false;
                }

                Console.WriteLine("¿Desea crear otro docente?");
                ApoyoS = Console.ReadLine();

                ApoyoS.ToLower();

                if(ApoyoS != "si")
                {
                    sigo = false;
                }

            }

            Menu_Admin();

        }

        public static void Menu_Docente()
        {

        }

        public static void Menu_Estudiante()
        {

        }
    } 
}
