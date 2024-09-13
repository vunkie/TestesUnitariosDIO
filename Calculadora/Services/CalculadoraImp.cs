using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int RestoDivisao(int num1, int num2)
        {
            return num1 % num2;
        }

        public double Potencia(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }

        public double RaizQuadrada(int num1)
        {
            return Math.Sqrt(num1);
        }

        public double RaizCubica(int num1)
        {
            return Math.Pow(num1, 1.0 / 3.0);
        }

        public double LogaritmoBase10(int num1)
        {
            return Math.Log10(num1);
        }

        public double LogaritmoNatural(int num1)
        {
            return Math.Log(num1);
        }

        public int Fatorial(int num1)
        {
            if (num1 == 0)
            {
                return 1;
            }
            else
            {
                return num1 * Fatorial(num1 - 1);
            }
        }

        public int Fibonacci(int num1)
        {
            if (num1 == 0)
            {
                return 0;
            }
            else if (num1 == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(num1 - 1) + Fibonacci(num1 - 2);
            }
        }
        
    }
}