using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Models
{
    class Calculadora
    {
        public double PrimeiroValor { get; set; }
        public double SegundoValor { get; set; }

        public Calculadora()
        {
        }

        public Calculadora(double primeiroValor, double segundoValor)
        {
            PrimeiroValor = primeiroValor;
            SegundoValor = segundoValor;
        }

        public void ExibirCalculadora()
        {
            Console.WriteLine(" --------------------------------- ");
            Console.WriteLine("|        Souza Calculadora        |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|Bem-vindo(a)! :)                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|Selecione abaixo a opção deseja: |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|1. Somar                         |");
            Console.WriteLine("|2. Subtrair                      |");
            Console.WriteLine("|3. Multiplicar                   |");
            Console.WriteLine("|4. Dividir                       |");
            Console.WriteLine("|5. Potenciação                   |");
            Console.WriteLine("|6. Radiação                      |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|Exit. Sair                       |");
            Console.WriteLine(" --------------------------------- ");


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
            return PrimeiroValor / SegundoValor;
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
