using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Operadores
    {
        public double MenuOperadores()
        {
            EjerciciosOp ejercicios = new EjerciciosOp();

            int opcion1;
            try
            {
                Console.WriteLine("Menú de Operadores:");
                Console.WriteLine("---------------------");
                Console.WriteLine("1.Área Triángulo");
                Console.WriteLine("2.Suma 2 Enteros");
                Console.WriteLine("3.Elevación al Cuadrado");
                Console.WriteLine("4.Conversión Euros a Dolares");
                Console.WriteLine("5.Valor área y perimetro (Cuadrado)");
                Console.WriteLine("6.Área y Volumen (Cilindro)");
                Console.WriteLine("7.Área de una circunferencia");
                Console.WriteLine("8.Promedio de 3 Num.");
                Console.WriteLine("---------------------");
                Console.WriteLine("99.Salir del Programa");
                Console.WriteLine("---------------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Dato Incorrecto \nIngresé un valor numérico");
                Retorno.Volver();
            }

            Console.WriteLine("Elija una opcion:");
            opcion1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (opcion1)
            {
                case 1:
                    ejercicios.AreaTriangulo();
                    break;
                case 2:
                    ejercicios.SumaEnteros1();
                    break;
                case 3:
                    ejercicios.PotenciaNum();
                    break;
                case 4:
                    ejercicios.ConversionExD();
                    break;
                case 5:
                    ejercicios.AreaPerimetroCua();
                    break;
                case 6:
                    ejercicios.AreaVolumen();
                    break;
                case 7:
                    ejercicios.AreaCirculo();
                    break;
                case 8:
                    ejercicios.Promedio();
                    break;
                case 99:
                    Console.WriteLine("Se eligio finalizar el programa");
                    Environment.Exit(1);
                    break;
            }
            return 0;
        }
        class EjerciciosOp
        {

            public double AreaTriangulo()
            {
                Console.WriteLine("Calcular Area Triangulo ");
                Console.WriteLine("Ingrese la base : ");
                Global.nm1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura : ");
                Global.nm2 = Convert.ToDouble(Console.ReadLine());
                Global.nm4 = Global.nm1 * Global.nm2 / 2;
                Console.WriteLine("El resultado del area es:" + Global.nm4);
                return 0.0;
            }
            public double SumaEnteros1()
            {
                Console.WriteLine("Escriba dos numeros enteros: ");
                Console.WriteLine("Ingrese 1er entero : ");
                Global.nm1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese 2do entero: ");
                Global.nm2 = Convert.ToDouble(Console.ReadLine());
                Global.nm3 = Global.nm1 + Global.nm2;
                Console.WriteLine("El resultado de la suma:" + Global.nm3);
                return 0.0;

            }
            public double PotenciaNum()
            {
                Console.WriteLine("Ingrese el numero : ");
                Global.nm1 = Convert.ToDouble(Console.ReadLine());
                double elevadoAlCuadrado = Math.Pow(Global.nm1, 2);
                Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", Global.nm1, elevadoAlCuadrado));
                return 0.0;
            }
            public double ConversionExD()
            {

                Console.WriteLine("Ingrese la cantidad de euros : ");
                Global.nm1 = double.Parse(Console.ReadLine());
                Global.nm2 = Global.nm1 * 1.06;
                Console.WriteLine("El resultado de la conversion a Dolar: " + Global.nm2);
                return 0.0;
            }
            public double AreaPerimetroCua()
            {
                Console.WriteLine("Ingrese el lado del cuadrado: ");
                Global.nm1 = float.Parse(Console.ReadLine());
                Global.nm3 = Global.nm1 * 4;
                Global.nm4 = Global.nm1 * Global.nm1;
                Console.WriteLine("El perimetro es :" + Global.nm3);
                Console.WriteLine("El area es :" + Global.nm4);
                return 0.0;
            }
            public double AreaVolumen()
            {
                Console.Write("Ingresa el valor de altura: ");
                Global.nm1 = double.Parse(Console.ReadLine());
                Console.Write("Ingresa el valor de radio: ");
                Global.nm2 = double.Parse(Console.ReadLine());
                Global.nm3 = Math.PI * Global.nm2 * Global.nm2 * Global.nm2;
                Global.nm4 = 2.0 * Math.PI * Global.nm2 * (Global.nm2 + Global.nm1);
                Console.WriteLine("Valor de area: " + Global.nm4);
                Console.WriteLine("Valor de volumen: " + Global.nm3);
                return 0.0;
            }

            public double AreaCirculo()
            {
                Console.WriteLine("Ingrese el numero del Diametro");
                Global.nm1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El radio es:" + CircunferenciaEnteros(Global.nm1));
                static double CircunferenciaEnteros(double num1)
                {
                    return Convert.ToDouble(num1 / 2);
                }
                Console.WriteLine("La longitud es:" + LongitudEnteros(Global.nm1));
                static double LongitudEnteros(double num1)
                {
                    return Convert.ToDouble((2 * 3.14) * num1);
                }
                Console.WriteLine("Ingrese el numero del area");
                Global.nm2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area es:" + AreaCirEnteros(Global.nm1, Global.nm2));
                static double AreaCirEnteros(double num1, double num2)
                {
                    return Convert.ToDouble(3.14 * (2 * num2));
                }
                return 0.0;
            }

            public double Promedio()
            {
                Console.Write("Ingresa 1er valor: ");
                Global.nm1 = double.Parse(Console.ReadLine());
                Console.Write("Ingresa 2do valor: ");
                Global.nm2 = double.Parse(Console.ReadLine());
                Console.Write("Ingresa 3er valor: ");
                Global.nm3 = double.Parse(Console.ReadLine());
                Global.nm4 = (Global.nm1 + Global.nm2 + Global.nm3) / 3;
                Console.WriteLine("El promedio total es:" + Global.nm4);
                return 0.0;
            }
        }
    }
}