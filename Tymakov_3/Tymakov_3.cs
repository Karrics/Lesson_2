using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_3
{
    internal class Tymakov_3
    {
        static void Main(string[] args)
        {
            Bank cheat = Bank.now;
            // Здание 3.1
            Console.Write("Упр 3.1:");
            Console.WriteLine("Вывести тип счёта");
            Console.WriteLine("Счёт - {0}, Баланс - {1}", cheat, (int)cheat);
            // Задание 3.2
            Console.Write("Упр 3.2:");
            Console.WriteLine("Вывести информацию про банковский счёт");
            Bank_2 bank = new Bank_2();
            bank.balance = 999;
            bank.type = "Сберегательная";
            bank.num = 1234;
            bank.Print();
            // задание 3.3
            Console.Write("ДЗ 3.1:");
            Console.WriteLine("Указать место работы человека");
            University work = University.КФУ;
            Worker name = new Worker();
            name.name = "Динар";
            name.work = work;
            name.Print();
            Console.ReadKey();
        }
        enum Bank
        {
            now = 900,
            sber = 777
        }
        struct Bank_2
        {
            public int num;
            public string type;
            public int balance;
            public void Print()
            {
                Console.WriteLine($"Номер: {num}, Тип: {type}, баланс: {balance}");
            }
        }
        struct Worker
        {
            public string name;
            public University work;
            public void Print()
            {
                Console.WriteLine($"Имя: {name}, Вуз: {work}");
            }
        }
        enum University
        {
            КФУ,
            КАИ,
            КХТИ
        }
    }
}
