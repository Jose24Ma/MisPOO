using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Ciclos
    {
        public double MenuCiclos()
        {
            EjerciciosCi ejercicios = new EjerciciosCi();
            int opcion3;
            try
            {
                Console.WriteLine("Menu Ciclos:");
                Console.WriteLine("---------------------");
                Console.WriteLine("1.Multiplos de 3 entre 1 y 100");
                Console.WriteLine("2.Impares entre 0 y 100");
                Console.WriteLine("3.Pares entre 1 a 100");
                Console.WriteLine("4.Numeros Cuadrados del 1 al 30");
                Console.WriteLine("5.Suma de cuadrados");
                Console.WriteLine("6.Secuencia Ascendente");
                Console.WriteLine("7.Suma de numeros");
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
            opcion3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (opcion3)
            {
                case 1:
                    ejercicios.MultiplosxTres();
                    break;
                case 2:
                    ejercicios.ImparesN();
                    break;
                case 3:
                    ejercicios.ParesN();
                    break;
                case 4:
                    ejercicios.NumerosxCuadrados();
                    break;
                case 5:
                    ejercicios.SumaxCuadrados();
                    break;
                case 6:
                    ejercicios.SecuenciaxAscendente();
                    break;
                case 7:
                    ejercicios.SumaEnterosIn();
                    break;
                case 99:
                    Console.WriteLine("Se eligio finalizar el programa");
                    Environment.Exit(1);
                    break;
            }
            return 0;
        }
        class EjerciciosCi
        {
            public double MultiplosxTres()
            {

                do
                {
                    Console.WriteLine("Los multiplos son: " + Global.nm1);
                    Global.nm3 = Global.nm3 + 3;
                    Global.nm1 = Global.nm1 + 1;
                }
                while (Global.nm3 < 100);
                Console.WriteLine("El total de Multiplos son: " + Global.nm1);
                return 0.0;
            }
            public double ImparesN()
            {

                for (Global.nm1 = 1; Global.nm1 <= 100; Global.nm1++)
                {
                    if (Global.nm1 % 2 != 0)
                    {
                        Console.WriteLine(Global.nm1);
                        Global.nm2++;
                    }
                }
                return 0.0;
            }

            public double ParesN()
            {

                for (Global.nm1 = 2; Global.nm1 <= 100; Global.nm1 += 2)
                {
                    Console.WriteLine(Global.nm1);
                }
                return 0.0;
            }

            public double NumerosxCuadrados()
            {
                for (Global.nm1 = 1; Global.nm1 <= 30; Global.nm1++)
                {
                    double elevadoAlCuadrado = Math.Pow(Global.nm1, 2);
                    Console.WriteLine("Proceso " + Global.nm1 + "^2 = " + elevadoAlCuadrado);

                }
                return 0.0;
            }
            public double SumaxCuadrados()
            {
                Global.nm1 = 0;
                for (Global.nm2 = 1; Global.nm2 <= 100; Global.nm2++)
                {
                    Console.WriteLine("Proceso " + Global.nm2);
                    Global.nm1 = Global.nm2 * Global.nm2;
                }
                Console.WriteLine("Valor de la suma : " + Global.nm1);
                return 0.0;
            }
            public double SecuenciaxAscendente()
            {
                Console.WriteLine("Digite el primer numero: ");
                Global.nm1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero: ");
                Global.nm2 = Convert.ToDouble(Console.ReadLine());
                for (Global.nm3 = Global.nm1 + 1; Global.nm3 < Global.nm2; Global.nm3++)
                {
                    Console.WriteLine("Los numeros comprendidos entre " + Global.nm1 + " y " + Global.nm2 + " son :");
                    Console.WriteLine(Global.nm3);
                }
                return 0.0;
            }
            public double SumaEnterosIn()
            {

                do
                {
                    Console.WriteLine("Ingrese un valor (0 para finalizar) :");
                    Global.nm1 = Convert.ToDouble(Console.ReadLine());
                    Global.nm2 = Global.nm1;
                    if (Global.nm2 != 0)
                    {
                        Global.nm3 = Global.nm3 + Global.nm2;
                        Global.nm4++;

                    }
                    else
                    {
                        Console.WriteLine("No se ingresan mas valores");
                    }
                } while (Global.nm2 != 0);
                Console.WriteLine("La suma total es :" + Global.nm3);
                return 0.0;
            }
        }
    }
}