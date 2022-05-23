using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class MiscelaneaEj
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            try
            {
                menu.Menus();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dato Incorrecto \nIngrese un valor numerico");
            }
            String RespuestContinuar = null;
            do
            {
                Console.WriteLine("\n¿Desea seguir usando el programa? SI/NO");
                RespuestContinuar = Console.ReadLine();
                if ((RespuestContinuar == "SI") || (RespuestContinuar == "si"))
                {
                    Console.Clear();
                    Menu menus = new Menu();
                    menus.Menus();
                }
                else if ((RespuestContinuar == "NO") || (RespuestContinuar == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Se decidio terminar el programa");
                    Environment.Exit(1);
                }
            } while ((RespuestContinuar == "SI") && (RespuestContinuar == "NO"));

        }
    }
    class Retorno
    {
        public static void Volver()
        {
            String RespuestContinuar = null;
            do
            {
                Console.WriteLine("\n¿Desea seguir usando el programa? SI/NO");
                RespuestContinuar = Console.ReadLine();
                if ((RespuestContinuar == "SI") || (RespuestContinuar == "si"))
                {
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Menus();
                }
                else if ((RespuestContinuar == "NO") || (RespuestContinuar == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Se decidio terminar programa");
                    Environment.Exit(1);
                }
            } while ((RespuestContinuar == "SI") && (RespuestContinuar == "NO"));

        }
    }
    public class Global
    {
        private static double num1 = 0.0;
        private static double num2 = 0.0;
        private static double num3 = 0.0;
        private static double num4 = 0.0;
        private static double num5 = 0.0;
        public static double nm1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public static double nm2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public static double nm3
        {
            get { return num3; }
            set { num3 = value; }
        }
        public static double nm4
        {
            get { return num4; }
            set { num4 = value; }
        }
        public static double nm5
        {
            get { return num5; }
            set { num5 = value; }
        }

    }

}