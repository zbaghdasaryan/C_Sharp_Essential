using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        
        static A()
        {
            Console.WriteLine("staticheski konstuktor");
            
        }
        public A()
        {
            Console.WriteLine("sovorakan construktor");
        }

        
        public static void MetodSt()
        {
            Console.WriteLine("static metod");
        }
        public void M()
        {
            Console.WriteLine("sovorakan metod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A.MetodSt();
            A a = new A();
            a.M();
           
            Console.ReadKey();
        }
    }
}
