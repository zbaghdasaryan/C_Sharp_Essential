using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        private int b;
        public static int z;

        static A()
        {
            Console.WriteLine("staticheski konstuktor");
            z = 222;
        }

        public A(int b)
        {
            this.b = b;
        }
        public static void Msas()
        {

        }
        public void M()
        {
            Console.WriteLine("{0}, {1}",b, z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A.Msas();
            A.z=2;
            Console.ReadKey();
        }
    }
}
