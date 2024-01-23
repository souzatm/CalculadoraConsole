using CalculadoraConsole.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Models
{
    class Calculadora
    {
        public double PrimeiroValor { get; set; }
        public double SegundoValor { get; set; }

        public Calculadora(double primeiroValor, double segundoValor)
        {
            PrimeiroValor = primeiroValor;
            SegundoValor = segundoValor;
        }

        public double Somar()
        {
            return PrimeiroValor + SegundoValor;
        }

        public double Subtrair()
        {
            return PrimeiroValor - SegundoValor;
        }

        public double Multiplicar()
        {
            return PrimeiroValor * SegundoValor;
        }


        public double Dividir()
        {
            if (SegundoValor != 0)
            {
                return PrimeiroValor / SegundoValor;
            }
            else
            {
                throw new CalculadoraException("Divisor não pode ser 0.");
            }
        }

        public double Potenciacao()
        {
            double valor = Math.Pow(PrimeiroValor, SegundoValor);
            return valor;
        }

        public double Radiciacao()
        {
            double raiz = Math.Pow(PrimeiroValor, 1.0 / SegundoValor);
            return raiz;
        }
    }
}
