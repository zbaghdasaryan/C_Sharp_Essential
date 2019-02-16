using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {
        public string fild1 = "01";
        private string fild2 = "02";
        protected string fild3 = "03";
    }

    class Deliver : Base
    {
        public Deliver()
            {
            fild1 = "new 01";
            fild3 = "new 03";
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base @base = new Base();
            Deliver deliver = new Deliver();
            Console.WriteLine(@base.fild1);
            Console.WriteLine(deliver.fild1);
        }
    }
}
