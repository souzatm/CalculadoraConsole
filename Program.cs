using CalculadoraConsole.Models;
using CalculadoraConsole.Models.Exceptions;
using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaCalculadora calcTela = new TelaCalculadora();
            calcTela.ExibirCalculadora();

            while (true)
            {
                try
                {
                    Console.Write("Qual operação deseja realizar? ");
                    int num = int.Parse(Console.ReadLine());

                    if (num == 0)
                    {
                        Console.WriteLine("Obrigado por utilizar o Calculadora Console! :)");
                        break;
                    }
                    else if (num < 1 || num > 6)
                    {
                        throw new CalculadoraException("Opção inválida.");
                    }
                    else
                    {
                        Console.WriteLine("Informe o primeiro valor a ser calculado:");
                        double valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor a ser calculado:");
                        double valor2 = double.Parse(Console.ReadLine());

                        Calculadora calc = new Calculadora(valor1, valor2);

                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Resultado: " + calc.Somar());
                                break;
                            case 2:
                                Console.WriteLine("Resultado: " + calc.Subtrair());
                                break;
                            case 3:
                                Console.WriteLine("Resultado: " + calc.Multiplicar());
                                break;
                            case 4:
                                Console.WriteLine("Resultado: " + calc.Dividir());
                                break;
                            case 5:
                                Console.WriteLine("Resultado: " + calc.Potenciacao());
                                break;
                            case 6:
                                Console.WriteLine("Resultado: " + calc.Radiciacao());
                                break;
                        }
                    }
                }
                catch (CalculadoraException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}