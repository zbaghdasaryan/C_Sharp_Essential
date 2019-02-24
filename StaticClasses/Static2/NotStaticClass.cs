﻿using System;

// В статических методах нельзя обращаться к нестатическим полям.

namespace Static
{
    class NotStaticClass
    {
        private int id;

        // Конструктор.
        public NotStaticClass(int id)
        {
            this.id = id;
        }

        public static void Method()
        {
            //Console.WriteLine("Instance.Id = {0}", Id);

            Console.WriteLine("В статических методах нельзя обращаться к нестатическим полям.");
        }
    }
}
