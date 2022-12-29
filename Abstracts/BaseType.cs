using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstracts
{
    public abstract class BaseType : IType
    {
        protected string? type;
        public void Type()
        {
            Console.WriteLine("Araba tipi: " + type);
        }
    }
}
