using System;

// Абстрактный класс может быть унаследован от конкретного класса.

namespace Abstraction
{
    // Конкретный класс A.
   

    // Абстрактный класс.
    abstract class AbstractClass : ConcreteClassA
    {
        public abstract void Method();
    }

    // Конкретный класс B.
    class ConcreteClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClassB();

            instance.Method();
            instance.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
