using ConsoleApp1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    internal class XEngine : BaseEngine
    {
        public XEngine() 
        {
            capacity = 1000;
        }
    }
}
