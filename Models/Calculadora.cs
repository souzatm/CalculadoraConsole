using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Models
{
    class Calculadora
    {
        public int PrimeiroValor { get; set; }
        public int SegundoValor { get; set; }

        public Calculadora()
        {
        }

        public Calculadora(int primeiroValor, int segundoValor)
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

        public double Potenciacao(double primeiroValor)
        {
            double soma = 0;
            for(int i = 0; i < PrimeiroValor; i++) 
            {
                soma = PrimeiroValor * PrimeiroValor;
            }
            return soma;
        }

        // Radiciação
    }
}
