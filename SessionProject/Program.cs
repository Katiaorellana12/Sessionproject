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


      

        