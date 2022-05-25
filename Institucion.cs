using System;
using System.Collections.Generic;
using System.IO;

namespace Clases
{
    internal class Institucion
    {

        static public List<Evaluacion> l_evaluacion;
        static public List<Docente> l_docente;
        static public List<Pregrado> l_pregrado;
        static public List<Postgrado> l_postgrado;
        static public List<Asignatura> l_Asignatura;
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
                        Cargar();
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

            Console.Clear();
            bool sigo = true;
            string ApoyoS = "";


            bool ApoyoB = true;

            Console.Clear();
    
            while (ApoyoB)
            {

                string Name;
                string Id = "";
                string F_nacimiento = "";
                ApoyoS = "";
                DateTime ApoyoD;
                int ApoyoI;
                string Area = "";

                Console.WriteLine("¿Cual es el nombre del nuevo docente?");
                Name = Console.ReadLine();

                if (!string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name))
                {

                    count_docente++;

                    while (string.IsNullOrEmpty(F_nacimiento) || string.IsNullOrWhiteSpace(F_nacimiento) || !DateTime.TryParse(F_nacimiento, out ApoyoD))
                    {
                            
                        Console.WriteLine("¿Cual es la fecha de nacimiento del nuevo docente? (dd/MM/yyyy) INCLUYENDO LOS '/'");
                        F_nacimiento = Console.ReadLine();

                        if (!string.IsNullOrEmpty(F_nacimiento) && !string.IsNullOrWhiteSpace(F_nacimiento) && DateTime.TryParse(F_nacimiento, out ApoyoD))
                        {

                            while (string.IsNullOrEmpty(Area) || string.IsNullOrWhiteSpace(Area))
                            {

                                Console.WriteLine("¿En que area enseña el nuevo docente?");
                                Area = Console.ReadLine();

                                if (!string.IsNullOrEmpty(Area) && !string.IsNullOrWhiteSpace(Area))
                                {

                                    do
                                    {

                                        Console.WriteLine("¿Cuantos titulos tiene el docente?");
                                        ApoyoS = Console.ReadLine();

                                    }
                                    while (!int.TryParse(ApoyoS, out ApoyoI));

                                    if(ApoyoI < 1)
                                    {

                                        ApoyoI = 1;

                                    }

                                    ApoyoS = count_docente.ToString();
                                    F_nacimiento = ApoyoD.ToString();
                                    Docente docente = new Docente(Name, ApoyoS, F_nacimiento, Area);

                                    for (int i = 1; i <= ApoyoI; i++)
                                    {

                                        Console.WriteLine("Ingrese el titulo n° " + i);
                                        ApoyoS = Console.ReadLine();
                                        docente.L_titulos.Add(ApoyoS);
                                        ApoyoB = false;
            
                                    }

                                }

                                else Console.WriteLine("ERROR: Por favor ingrese un Nombre_Acudiente");

                            }

                        }

                        else Console.WriteLine("ERROR: Por favor ingrese una fecha de nacimiento");

                    }

                }

                else Console.WriteLine("ERROR: Por favor ingrese un nombre valido");
            }

            Console.WriteLine("¿Desea crear otro docente? \n si para continuar \n Cualquier otro texto para salir");
            ApoyoS = Console.ReadLine();

            ApoyoS=  ApoyoS.ToLower();

            if (ApoyoS != "si")
            {
 
                Console.Clear();
                Menu_Admin();
            
            }

            else Menu_Create_Docente();

        }

        public static void Menu_Create_Pregrado()
        {
            Console.Clear();
            bool sigo = true;
            string ApoyoS = "";


            bool ApoyoB = true;

            Console.Clear();

            while (ApoyoB)
            {

                string Name;
                string Id = "";
                string F_nacimiento = "";
                string Nombre_Acudiente = "";
                int Año = 2010;
                string Colegio = "";
                string titulo = "";
                
                ApoyoS = "";
                DateTime ApoyoD;
                

                Console.WriteLine("¿Cual es el nombre del nuevo estudiante?");
                Name = Console.ReadLine();

                if (!string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name))
                {

                    count_estudiante++;

                    while (string.IsNullOrEmpty(F_nacimiento) || string.IsNullOrWhiteSpace(F_nacimiento) || !DateTime.TryParse(F_nacimiento, out ApoyoD))
                    {

                        Console.WriteLine("¿Cual es la fecha de nacimiento del nuevo estudiante? (dd/MM/yyyy) INCLUYENDO LOS '/'");
                        F_nacimiento = Console.ReadLine();

                        if (!string.IsNullOrEmpty(F_nacimiento) && !string.IsNullOrWhiteSpace(F_nacimiento) && DateTime.TryParse(F_nacimiento, out ApoyoD))
                        {
                            
                            while (string.IsNullOrEmpty(Nombre_Acudiente) || string.IsNullOrWhiteSpace(Nombre_Acudiente))
                            {

                                Console.WriteLine("¿Cual es el nombre del acudiente del estudiante?");
                                Nombre_Acudiente = Console.ReadLine();

                                if (!string.IsNullOrEmpty(Nombre_Acudiente) && !string.IsNullOrWhiteSpace(Nombre_Acudiente))
                                {
                                    //colegio año y titulo
                                    while (string.IsNullOrEmpty(Colegio) || string.IsNullOrWhiteSpace(Colegio))
                                    {

                                        Console.WriteLine("¿Cual es el nombre del colegio del que fue egresado?");
                                        Colegio = Console.ReadLine();

                                        if (!string.IsNullOrEmpty(Colegio) && !string.IsNullOrWhiteSpace(Colegio))
                                        {

                                            while ( Año <= 2010 || Año >= 2023)
                                            {

                                                Console.WriteLine("¿En que año fue egresado?");
                                                Colegio = Console.ReadLine();

                                                if (Año > 2010 && Año < 2023)
                                                {

                                                    while (string.IsNullOrEmpty(titulo) || string.IsNullOrWhiteSpace(titulo))
                                                    {

                                                        Console.WriteLine("¿Cual es el titulo que consiguio al gradiarse?");
                                                        Colegio = Console.ReadLine();

                                                        if (!string.IsNullOrEmpty(titulo) && !string.IsNullOrWhiteSpace(titulo))
                                                        {

                                                            ApoyoS = Año.ToString();
                                                            F_nacimiento = ApoyoD.ToString();
                                                            string[] datos = new string[3];

                                                            datos[0] = Colegio;
                                                            datos[1] = ApoyoS;
                                                            datos[2] = titulo;

                                                            ApoyoS = count_docente.ToString();

                                                            Pregrado pregrado = new Pregrado(Name, ApoyoS, F_nacimiento,Nombre_Acudiente, datos);

                                                            l_pregrado.Add(pregrado);
                                                        }

                                                        else Console.WriteLine("ERROR: Por favor ingrese un titulo");

                                                    }

                                                }

                                                else Console.WriteLine("ERROR: Por favor ingrese un año valido (2011-2022)");

                                            }

                                        }

                                        else Console.WriteLine("ERROR: Por favor ingrese un Nombre de colegio");

                                    }

                                }

                                else Console.WriteLine("ERROR: Por favor ingrese un Nombre de Acudiente");

                            }

                        }

                        else Console.WriteLine("ERROR: Por favor ingrese una fecha de nacimiento");

                    }

                }

                else Console.WriteLine("ERROR: Por favor ingrese un nombre");
            }

            Console.WriteLine("¿Desea crear otro estudiante? \n si para continuar \n Cualquier otro texto para salir");
            ApoyoS = Console.ReadLine();

            ApoyoS = ApoyoS.ToLower();

            if (ApoyoS != "si")
            {

                Console.Clear();
                Menu_Admin();

            }

            else Menu_Create_Pregrado();

        }

        public static void Menu_Docente()
        {

            //Reportar evaluaciones

        }

        public static void Menu_Estudiante()
        {

            //consultar en historial SU evaluacion

        }

        public static void Cargar()
        {
            var text = "C:\\Users\\oveor\\Desktop\\TAREASSSSS\\TEORIA DE LA COMPUTACION\\Codde\\Clases\\recursos\\TextFile1.txt";

            StreamReader archivo = new StreamReader(text);

            string[] v_miembros;
            Docente docente;
            Pregrado pregrado;
            Postgrado postgrado;
            string[] ApoyoS = new string[3];

            string linea = archivo.ReadLine();


            while (linea != null) {

                v_miembros = linea.Split('|');

                switch (v_miembros[0])
                {
                    case "D":

                        docente = new Docente(v_miembros[1], v_miembros[2], v_miembros[3], v_miembros[4]);

                        for (int i = v_miembros.Length - 6; i >= 0; i--)
                        {

                            docente.L_titulos.Add(v_miembros[i + 5]);

                        }

                        l_docente.Add(docente);

                        break;

                    case "P":

                        for (int i = 0; i <= 2; i++)
                        {

                            ApoyoS[i] = v_miembros[i + 5];

                        }

                        pregrado = new Pregrado(v_miembros[1], v_miembros[2], v_miembros[3], v_miembros[4], ApoyoS);

                        break;

                    case "O":

                        

                        break;

                }

                linea = archivo.ReadLine();
            }
        }
    } 
}
