using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee : IWorker
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
