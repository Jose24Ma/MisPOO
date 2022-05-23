using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Condicionales
    {
        public double MenuCondicionales()
        {
            EjerciciosCon ejercicios = new EjerciciosCon();
            int opcion2;
            try
            {
                Console.WriteLine("Menu Condicionales:");
                Console.WriteLine("---------------------");
                Console.WriteLine("1.Positivo o Negativo");
                Console.WriteLine("2.Mayor y Menor");
                Console.WriteLine("3.3 Numeros enteros (Mayor y Menor");
                Console.WriteLine("4.Suma o Resta entre A y B");
                Console.WriteLine("5.Cociente entre A y B");
                Console.WriteLine("6.Suma o Multiplicacion entre A y B");
                Console.WriteLine("7.Año bisiesto o no");
                Console.WriteLine("---------------------");
                Console.WriteLine("99.Salir del Programa");
                Console.WriteLine("---------------------");



            }
            catch (Exception ex)
            {
                Console.WriteLine("Dato Incorrecto \nIngrese un valor numerico");
                Retorno.Volver();
            }

            Console.WriteLine("Elija una opcion:");
            opcion2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (opcion2)
            {
                case 1:
                    ejercicios.NegativoPositivo();
                    break;
                case 2:
                    ejercicios.MayorMenor();
                    break;
                case 3:
                    ejercicios.MayorMenorTres();
                    break;
                case 4:
                    ejercicios.SumaRestaMenor();
                    break;
                case 5:
                    ejercicios.Cociente();
                    break;
                case 6:
                    ejercicios.NegPos();
                    break;
                case 7:
                    ejercicios.AñoBisiesto();
                    break;
                case 99:
                    Console.WriteLine("Se eligio finalizar el programa");
                    Environment.Exit(1);
                    break;
            }
            return 0;
        }
        class EjerciciosCon
        {
            public double NegativoPositivo()
            {
                Console.WriteLine("Ingrese el numero: ");
                Global.nm1= float.Parse(Console.ReadLine());
                if (Global.nm1 > 0)
                {
                    Console.WriteLine("El numero ingresado es positivo");
                }
                if (Global.nm1 < 0)
                {
                    Console.WriteLine("El numero ingresado es negativo");
                }
                return 0.0;
            }

            public double MayorMenor()
            {
                Console.WriteLine("Digite el 1er numero");
                Global.nm1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 2do numero");
                Global.nm2 = float.Parse(Console.ReadLine());
                if (Global.nm1 > Global.nm2)
                {
                    Console.WriteLine(Global.nm1 + " Es mayor que " + Global.nm2);
                }
                else
                {
                    Console.WriteLine(Global.nm2 + " Es mayor que " + Global.nm1);
                }
                return 0.0;
            }
            public double MayorMenorTres()
            {
                Console.WriteLine("Digite el 1er numero");
                Global.nm1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 2do numero");
                Global.nm2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 3er numero");
                Global.nm3 = float.Parse(Console.ReadLine());
                Global.nm4 = Global.nm1;
                if (Global.nm2 > Global.nm4)
                    Global.nm4 = Global.nm2;
                if (Global.nm3 > Global.nm4)
                    Global.nm4 = Global.nm3;
                Console.WriteLine("El numero mayor es:" + Global.nm4);
                Global.nm5 = Global.nm1;
                if (Global.nm2 < Global.nm5)
                    Global.nm5 = Global.nm2;
                if (Global.nm3 < Global.nm5)
                    Global.nm5 = Global.nm3;
                Console.WriteLine("El numero menor es:" + Global.nm5);
                return 0.0;
            }

            public double SumaRestaMenor()
            {

                Console.WriteLine("Digite el 1er numero");
                Global.nm1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 2do numero");
                Global.nm2 = float.Parse(Console.ReadLine());
                if (Global.nm1 < Global.nm2)
                {
                    Global.nm3 = Global.nm1 + Global.nm2;
                    Console.WriteLine("A es menor que B el resultado de la suma es :" + Global.nm3);
                }
                else
                {
                    if (Global.nm1 > Global.nm2)
                    {
                        Global.nm4 = Global.nm1 - Global.nm2;
                        Console.WriteLine("A es mayor que B \nEl resultado de la resta es :" + Global.nm4);
                    }

                }
                return 0.0;
            }
            public double Cociente()
            {

                Console.WriteLine("Ingrese el dividendo :");
                Global.nm1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese le divisor :");
                Global.nm2 = float.Parse(Console.ReadLine());
                if (Global.nm1 > 0 && Global.nm2 > 0)
                {
                    Global.nm3 = Global.nm1 / Global.nm2;
                    Console.WriteLine("El cociente entre entre A y B es :" + Global.nm3);
                }
                else
                {
                    if (Global.nm1 <= 0 || Global.nm2 <= 0)
                    {
                        Console.WriteLine("la division no es posible");
                    }
                }
                return 0.0;
            }

            public double NegPos()
            {

                Global.nm1 = 0;
                Console.WriteLine("Ingrese 1er numero");
                Global.nm2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el 2do numero");
                Global.nm3 = float.Parse(Console.ReadLine());
                if (Global.nm2 < 0)
                {
                    Global.nm1 = Global.nm2 + Global.nm3;
                    Console.WriteLine("El numero es negativo \n El resultado de la suma :" + Global.nm1);
                }
                else
                {
                    if (Global.nm2 > 0)
                        Global.nm1 = Global.nm2 * Global.nm3;
                    Console.WriteLine("El numero es positivo \n El resultado de la multiplacion :" + Global.nm1);

                }
                return 0.0;
            }

            public double AñoBisiesto()
            {
                Console.WriteLine("Ingrese el año :");
                Global.nm1 = Convert.ToDouble(Console.ReadLine());
                bool esBisiesto = DateTime.IsLeapYear((int)Global.nm1);
                Console.WriteLine("¿El año es bisiesto? : " + esBisiesto);
                return 0.0;
            }
        }
    }
}