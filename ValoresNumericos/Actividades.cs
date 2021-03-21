using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNuméricos
{
    class ValoresNumericos
    {
        public void A15()
        {
            Console.Write("Ingrese un valor numérico: ");
            string Num = Console.ReadLine();

            if (char.IsNumber(Num, 0))
            {
                Console.WriteLine("Es un valor numérico");
            }
            else
            {
                Console.WriteLine("No es un valor numérico");
            }
        }

        public void A16()
        {
            Console.Write("Ingrese un valor numérico: ");
            string Num = Console.ReadLine();

            if (!int.TryParse(Num, out int Valor))
            {
                Console.WriteLine("No ha ingresado un número entero");
            }
            else
            {
                Console.WriteLine("El valor ingresado es: {0}", Valor);
            }
        }

        public void A17()
        {
            Console.Write("Ingrese el primer valor: ");
            string Valor1 = Console.ReadLine();
            Console.Write("Ingrese el segundo valor: ");
            string Valor2 = Console.ReadLine();

            if (!int.TryParse(Valor1, out int Num1))
            {
                Console.WriteLine("No ha ingresado un número entero");
            }
            else if (!int.TryParse(Valor2, out int Num2))
            {
                Console.WriteLine("No ha ingresado un número entero");
            }
            else
            {
                int Suma = Num1 + Num2;
                int Resta = Num1 - Num2;
                decimal Division = (decimal)Num1 / (decimal)Num2;
                int Multiplicacion = Num1 * Num2;
                double Potencia = Math.Pow(Num1, Num2);

                Console.WriteLine("Suma = " + Suma + Environment.NewLine +
                    "Resta = " + Resta + Environment.NewLine +
                    "División = " + Division + Environment.NewLine +
                    "Multiplicación = " + Multiplicacion + Environment.NewLine +
                    "Potencia = " + Potencia
                    );
            }
        }

        public void A18()
        {
            Console.Write("Ingrese un valor numérico: ");
            string Num = Console.ReadLine();
            if (!decimal.TryParse(Num, out decimal Numero))
            {
                Console.WriteLine("No ha ingresado un valor numérico");
            }
            else
            {
                Numero = decimal.Round(Numero, 2);

                Console.WriteLine("Número ingresado: " + Num);
                Console.WriteLine("Número redondeado: " + Numero);
            }
        }

        public void A19()
        {
            Console.Write("Ingrese un valor numérico: ");
            string Num = Console.ReadLine();
            if (!decimal.TryParse(Num, out decimal Numero))
            {
                Console.WriteLine("No ha ingresado un valor numérico");
            }
            else
            {
                decimal NumInt = Math.Truncate(Numero);
                Console.WriteLine("Número ingresado: " + Num);
                Console.WriteLine("Parte entera: " + NumInt);
            }
        }

        public void A20() // Ejercicio con validaciones del profesor
        {
            Console.Write("Ingrese el primer valor numérico: ");
            string Num1 = Console.ReadLine();

            if (!int.TryParse(Num1, out int Numero))
            {
                Console.WriteLine("No ha ingresado un valor numérico");
                Console.ReadKey();
                return;
            }

            Console.Write("Ingrese el segundo valor numérico: ");
            string Num2 = Console.ReadLine();
            if (!int.TryParse(Num2, out int Numero2))
            {
                Console.WriteLine("No ha ingresado un valor numérico");
                Console.ReadKey();
                return;
            }

            if (Numero > Numero2)
            {
                Console.WriteLine("El número mayor es: " + Numero);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + Numero2);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos
{
    class Actividades
    {
    }
}
