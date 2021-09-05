using System;

namespace SessionProject
{
    class Program
    {

        static Session session = new Session();
        static Boolean isAdmin = false;


        static void Main(string[] args)
        {
            Console.WriteLine("<INICIO DE SESION>");
            login();

        }
        static void menus()
        {
            String option = Console.ReadLine();
            option = option.ToLower();
            String fileName = "";
            String text = "";
            string tarea = "";
            Boolean exit = false;
            if (isAdmin)
            {
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Agregar datos.");
                        Console.WriteLine("Ingrese el usuario: ");
                        String username = Console.ReadLine();
                        Console.WriteLine("Ingrese la contraseña: ");
                        String paasword = Console.ReadLine();
                        session.addCredential(username, paasword);
                        break;

                    case "2":
                        Console.WriteLine("Elegir registro");
                        Console.WriteLine("¿Que registro desea ver?, escriba 1, 2 o 3:");
                        Console.WriteLine("1. SMIS110521 ERICK BENITEZ");
                        Console.WriteLine("2. SMIS012021 MELVIN MENDOZA");
                        Console.WriteLine("3. SMIS015421 SOFIA ASCENCIO");
                        Console.WriteLine("4. SMIS025819 KATIA ORELLANA");
                        tarea = Console.ReadLine();
                        if (tarea == "1")
                        {
                            Console.WriteLine("SMIS110521");
                            Console.WriteLine("Este computo me pareció un poco interesante " +
                                "y con algo de dificultad,pero mis" +
                                " compañeros han ayudado a desarrollar un poco más " +
                                "de experiencia en este entorno " +
                                "de la programación,la clases tanto como el ingeniero que las " +
                                "impartió hizo un buen trabajo." +
                                " Me costó el proceso que realiza a la hora de envíar" +
                                " un trabajo por medio de git. Me encantaría seguir poder aprendiendo.");

                            break;

                        }

                        else if (tarea == "2")
                        {
                            Console.WriteLine("SMIS012021");
                            Console.WriteLine("En el desarrollo del cómputo e logrado adquirir mayor conocimiento sobre" +
                                "  el lenguaje de programación con c#, realizando ejercicios de " +
                                "consola y poniendo en práctica en la semana correspondiente, además el uso de un repositorio " +
                                "desde cómo crearlo hasta trabajar en equipo implementando el trabajo grupal facilitando" +
                                " la práctica en el desarrollo de actividades, no presentó ninguna sugerencia a la ingeniera " +
                                "en cuanto a las clases ya que el plan de estudio del cómputo a sido muy bueno.");

                            break;
                        }


                        else if (tarea == "3")
                        {
                            Console.WriteLine("SMIS110521");
                            Console.WriteLine("Mi experiencia con la programación ha sido buena y de igual forma" +
                                " un poco complicada, la materia y todo " +
                                "es bonita y se entiende solo que a veces a la  hora de realizar los ejercicios es " +
                                "un poco complicado ya que tenemos  que saber lo que " +
                                "vamos escribiendo en el código, ya que una coma, punto alguna letra o número que escribas mal, todo el código se arruina y por " +
                                "eso tenemos que estar pendiente" +
                                " y ir revisando a la hora de realizarlo, en este cómputo he aprendido" +
                                " muchísimas cosas más, controlo un poco más lo básico " +
                                "de el programa de igual forma la ingeniera y mis compañeros an hecho también que" +
                                " sea más fácil ya que si no comprendo algo ellos me explican un poco como hacer " +
                                "el procedimiento.");


                            break;
                        }

                        else if (tarea == "4")
                        {
                            Console.WriteLine("SMIS025819");
                            Console.WriteLine("En el transcurso de este ciclo he  aprendido demasiado y es gracias a la forma tan" +
                                "" +
                                " clara quetiene la licenciada de dar impartir de su clase, me deja no" +
                                " quedo con dudas, espero que siga desarrollandosu trabajo muy bien siempre, siento que lo mas me" +
                                " cuesta son los metodosa la hora de hacer el codigo, tengo que esmerarme mas en eso.");

                        }
                        break;
                    case "3":
                        Console.WriteLine("Crear registro");
                        Console.WriteLine("Nombre del registro? ");
                        fileName = Console.ReadLine();
                        Console.WriteLine("Ingrese un codigo para el registro");
                        text = Console.ReadLine();
                        session.newFile(fileName);
                        session.addTextFile(text, fileName);
                        break;
                    case "4":
                        Console.WriteLine("Borrar registro");
                        Console.WriteLine("Codigo del registro? ");
                        fileName = Console.ReadLine();
                        session.deleteFile(fileName);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada incorrecta");

                        break;

                }
                if (!exit)
                {
                    printMenuAdmin();
                    menus();
                }
            }
            else
            {
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Leer registro.");
                        Console.WriteLine("Escriba el codigo del alumno para ver su registro: ");
                        fileName = Console.ReadLine();
                        if (fileName == "SMIS110521")
                        {
                            Console.WriteLine("ERICK DAVID BENITEZ CANO");
                            Console.WriteLine("Este computo me pareció un poco interesante " +
                                "y con algo de dificultad,pero mis" +
                                " compañeros han ayudado a desarrollar un poco más " +
                                "de experiencia en este entorno " +
                                "de la programación,la clases tanto como el ingeniero que las " +
                                "impartió hizo un buen trabajo." +
                                " Me costó el proceso que realiza a la hora de envíar" +
                                " un trabajo por medio de git. Me encantaría seguir poder aprendiendo.");
                            break;


                        }
                        else if (fileName == "SMIS012021")
                        {
                            Console.WriteLine("MELVIN SANTIAGO RODRIGUEZ MENDOZA");
                            Console.WriteLine("En el desarrollo del cómputo e logrado adquirir mayor conocimiento sobre" +
                                "  el lenguaje de programación con c#, realizando ejercicios de " +
                                "consola y poniendo en práctica en la semana correspondiente, además el uso de un repositorio " +
                                "desde cómo crearlo hasta trabajar en equipo implementando el trabajo grupal facilitando" +
                                " la práctica en el desarrollo de actividades, no presentó ninguna sugerencia a la ingeniera " +
                                "en cuanto a las clases ya que el plan de estudio del cómputo a sido muy bueno.");
                            break;
                        }
                        else if (fileName == "SMIS015421")
                        {
                            Console.WriteLine("SOFIA GISSELL HERNANDEZ ASCENCIO");
                            Console.WriteLine("Mi experiencia con la programación ha sido buena y de igual forma" +
                                " un poco complicada, la materia y todo " +
                                "es bonita y se entiende solo que a veces a la  hora de realizar los ejercicios es " +
                                "un poco complicado ya que tenemos  que saber lo que " +
                                "vamos escribiendo en el código, ya que una coma, punto alguna letra o número que escribas mal, todo el código se arruina y por " +
                                "eso tenemos que estar pendiente" +
                                " y ir revisando a la hora de realizarlo, en este cómputo he aprendido" +
                                " muchísimas cosas más, controlo un poco más lo básico " +
                                "de el programa de igual forma la ingeniera y mis compañeros an hecho también que" +
                                " sea más fácil ya que si no comprendo algo ellos me explican un poco como hacer " +
                                "el procedimiento.");
                            break;
                        }


                        else if (fileName == "SMIS025819")
                        {
                            Console.WriteLine("SMIS025819");
                            Console.WriteLine("En el transcurso de este computo he  aprendido " +
                                "demasiado y es gracias a la forma tan" +
                                "" +
                                " clara quetiene la licenciada de dar impartir de su clase, me deja no" +
                                " quedo con dudas, espero que siga desarrollandosu trabajo muy bien siempre, siento que lo mas me" +
                                " cuesta son los metodosa la hora de hacer el codigo, tengo que esmerarme mas en eso.");


                            break;
                        }

                        text = session.readFile(fileName);
                        Console.WriteLine(text);
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada incorrecta");

                        break;

                }
                if (!exit)
                {
                    printMenuOther();
                    menus();
                }
            }
        }
        static void login()
        {


            Console.WriteLine("Ingrese usuario:");
            String username = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña:");
            String password = Console.ReadLine();
            if (session.login(username, password))
            {
                if (username.Equals("admin"))
                {
                    isAdmin = true;
                    printMenuAdmin();
                }
                else
                {
                    isAdmin = false;
                    printMenuOther();
                }

                menus();
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos");
                login();
            }

        }



        