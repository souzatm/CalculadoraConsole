using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Models.Exceptions
{
    class CalculadoraException : ApplicationException
    {
        public CalculadoraException(string message) : base(message) { } 
    }
}
