using CalculadoraConsole.Models;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double um = double.Parse(Console.ReadLine());
            double dois = double.Parse(Console.ReadLine());

            Calculadora calc = new Calculadora(um, dois);
            Console.WriteLine(calc.Somar());
            Console.WriteLine(calc.Subtrair());
            Console.WriteLine(calc.Multiplicar());
            Console.WriteLine(calc.Dividir());
            Console.WriteLine(calc.Potenciacao());
            Console.WriteLine(calc.Radiciacao());

            calc.ExibirCalculadora();

        }
    }
}