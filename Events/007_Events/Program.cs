using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Account
    {
        // Объявляем делегат
        public delegate void AccountStateHandler(string message);

        // Событие, возникающее при выводе денег
        public event AccountStateHandler Withdrawn;

        // Событие, возникающее при добавление на счет
        public event AccountStateHandler Added;

        int _sum; // Переменная для хранения суммы

        public Account(int sum)
        {
            _sum = sum;
        }

        public void Put(int sum)
        {
            _sum += sum;
            if (Added != null)
                Added($"На счет поступило {sum}");
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (Withdrawn != null)
                    Withdrawn($"Сумма {sum} снята со счета");
            }
            else
            {
                if (Withdrawn != null)
                    Withdrawn("Недостаточно денег на счете");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            // Добавляем обработчики события
            account.Added += Show_Message;
            account.Withdrawn += Show_Message;

            account.Withdraw(100);
            // Удаляем обработчик события
            account.Withdrawn -= Show_Message;

            account.Withdraw(50);
            account.Put(150);

            Console.ReadLine();
        }
        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}

