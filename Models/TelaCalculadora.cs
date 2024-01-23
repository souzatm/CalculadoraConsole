using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Models
{
    class TelaCalculadora
    {
        public TelaCalculadora()
        {
        }

        public void ExibirCalculadora()
        {
            Console.WriteLine(" --------------------------------- ");
            Console.WriteLine("|       Calculadora Console       |");
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
            Console.WriteLine("|0. Sair                          |");
            Console.WriteLine(" --------------------------------- ");
        }


    }
}
