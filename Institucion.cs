using System;
using System.Collections.Generic;
using System.IO;

namespace Clases
{
    internal class Institucion
    {

        static private List<Evaluacion> l_evaluacion;
        static private List<Docente> l_docente;
        static private List<Pregrado> l_pregrado;
        static private List<Postgrado> l_postgrado;
        static private List<Asignatura> l_Asignatura;
        static public int count_docente = 0;
        static public int count_estudiante = 0;
        static Institucion Aguardiente = new Institucion();

        //Main que llama al menú
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu() {

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
                        Cargar_Docentes();
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

            //Recorrer historia

            //Variables apoyo
            string ApoyoS = "";
            bool Error = false;

            Console.WriteLine("BIENVENIDO AL SISTEMA DE ADMINISTRACION" +
                              "\n \n Ingrese el numero de la función que quiere realizar" +
                              "\n 1. Crear un nuevo docente" +
                              "\n 2. Crear un nuevo estudiante de Pregrado" +
                              "\n 3. Crear un nuevo estudiante de postgrado" +
                              "\n 4. Crear un nuevo Historial evaluativo" +
                              "\n 5. Crear una nueva Asignatura" +
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
            string ApoyoS = "";

            var text = "C:\\Users\\oveor\\Desktop\\TAREASSSSS\\TEORIA DE LA COMPUTACION\\Codde\\Clases\\recursos\\TextFile1.txt";

            StreamWriter archivo = new StreamWriter(text);

            while (sigo)
            {

                string Name;
                string Id = "";
                string F_nacimiento = "";
                bool ApoyoB = true;
                string Area = "";

                Console.Clear();

                while(ApoyoB)
                {

                    Console.WriteLine("¿Cual es el nombre del nuevo docente?");
                    Name = Console.ReadLine();

                    if (!string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name))
                    {

                        count_docente++;                            

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
                                        
                                        ApoyoS = "D|" + Name + "|" + Id + "|" + F_nacimiento + "|" + Area + "|";

                                        archivo.WriteLine(ApoyoS);
                                        
                                    }

                                    else Console.WriteLine("ERROR: Por favor ingrese un Area");

                                }

                            }

                            else Console.WriteLine("ERROR: Por favor ingrese una fecha de nacimiento");

                        }

                    }

                    else Console.WriteLine("ERROR: Por favor ingrese un nombre valido");
                }

                Console.WriteLine("¿Desea crear otro docente? \n si para continuar \n Cualquier otro texto para salir");
                ApoyoS = Console.ReadLine();

                ApoyoS.ToLower();

                if (ApoyoS != "si")
                {
                    sigo = false;
                    Console.Clear();
                }

            }

            Menu_Admin();

        }

        public static void Menu_Docente()
        {

            //Reportar evaluaciones

        }

        public static void Menu_Estudiante()
        {

            //consultar en historial SU evaluacion

        }

        public static void Cargar_Docentes()
        {

            var text = "C:\\Users\\oveor\\Desktop\\TAREASSSSS\\TEORIA DE LA COMPUTACION\\Codde\\Clases\\recursos\\TextFile1.txt";

            StreamReader archivo = new StreamReader(text);
            StreamWriter archivo2 = new StreamWriter(text);

            string[] v_miembros;
            Docente docente;
            Pregrado pregrado;
            Postgrado postgrado;

            string linea = archivo.ReadLine();

            l_docente.Clear();


            while (linea != null) {

                v_miembros = linea.Split('|');

                if (v_miembros[0].ToUpper() == "D") {

                    docente = new Docente(v_miembros[1], v_miembros[2], v_miembros[3], v_miembros[4]);

                    for (int i = v_miembros.Length - 6; i >= 0; i--)
                    {

                        docente.L_titulos.Add(v_miembros[i+5]);

                    }

                    for (int a = v_miembros.Length -6 ; a >= 0; a--)
                    {
                        Console.WriteLine(docente.L_titulos[a]);
                    }

                    l_docente.Add(docente);

                }

                else if (v_miembros[0].ToUpper() == "P") {

                    

                }

                linea = archivo.ReadLine();
            }
        }
    } 
}
