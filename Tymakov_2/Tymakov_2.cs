using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_2
{
    internal class Tymakov_2
    {
        static void Main(string[] args)
        {
            // Спросить имя пользователя и поприветствовать его
            Console.Write("Упр 2.1:");
            Console.WriteLine("Спросить имя пользователя и поприветствовать его");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"здравствуйте, {name}");
            Console.WriteLine();

            //Деление одного числа на другое 
            Console.Write("Упр 2.2:");
            Console.WriteLine("Деление одного числа на другое");
            Console.WriteLine("Введите целое число");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Делить на 0 нельзя");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
            Console.WriteLine();

            //Прочитать букву с экрана и вывести на печать следующую за ней
            //букву в алфавитном порядке.
            Console.Write("Д.з 2.1:");
            Console.WriteLine("Вывести следующую букву на экран");
            Console.WriteLine("Введите одну прописную букву из русского алфавита");
            char letter = (char)Console.Read();
            char NextLetter;
            if (letter == 'я')
            {
                NextLetter = 'а';
            }
            else
            {
                NextLetter = (char)(((int)letter) + 1);
            }
            Console.WriteLine(NextLetter);
            Console.WriteLine();

            //Написать программу, которая решает квадратное уравнение.
            //Входные данные – коэффициенты уравнения, выходные – найденные корни.
            Console.Write("Д.з 2.2:");
            Console.WriteLine("Решить квадратное уравнение");
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1 = (-1 * b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-1 * b + Math.Sqrt(d)) / (2 * a);
            if (d < 0)
            {
                Console.WriteLine("Нет корней");
            }
            else if (d == 0)
            {
                Console.WriteLine("Корень уравнения: {0}", x1);
            }
            else
            {
                Console.WriteLine("Корни уравнения: {0} , {1}", x1, x2);
            }

            Console.ReadKey();
        }
    }
}
