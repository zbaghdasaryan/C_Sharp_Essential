using System;

// Частичные методы (Partial methods).

namespace PartialClasses
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();

            instance.CallPartialMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
