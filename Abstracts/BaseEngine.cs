using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstracts
{
    public abstract class BaseEngine : IEngine
    {
        protected int capacity;
        public void Capacity()
        {
            Console.WriteLine("Motor hacmi: " + capacity);
        }
    }
}
