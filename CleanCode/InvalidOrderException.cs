using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class InvalidOrderException : Exception
    {
        public InvalidOrderException(string message) : base(message) { }
    }
}
