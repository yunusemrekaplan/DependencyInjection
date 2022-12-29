using ConsoleApp1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    internal class Car
    {
        private IEngine engine;
        private IType type;

        public Car(IEngine engine, IType type)
        {
            this.engine = engine;
            this.type = type;
        }

        public void Capacity()
        {
            engine.Capacity();
        }

        public void Type()
        {
            type.Type();
        }
    }
}
