using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ne_Tymakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упр1
            Console.WriteLine("Упр 1");
            Console.WriteLine("Вывести максимальное и минимальное значение каждого типа");
            Console.WriteLine("Минимальное значение типа byte: {0}, максимальное: {1}", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("Минимальное значение типа sbyte: {0}, максимальное: {1}", SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("Минимальное значение типа short: {0}, максимальное: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Минимальное значение типа ushort: {0}, максимальное: {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Минимальное значение типа int: {0}, максимальное: {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Минимальное значение типа uint: {0}, максимальное: {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Минимальное значение типа long: {0}, максимальное: {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Минимальное значение типа ulong: {0}, максимальное: {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Минимальное значение типа float: {0}, максимальное: {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Минимальное значение типа double: {0}, максимальное: {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Минимальное значение типа decimal: {0}, максимальное: {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine();


            // Упр2
            Console.WriteLine("Упр 2");
            Console.WriteLine("Распечатать информацию о пользователе");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Из какого вы города?");
            string city = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пин-код");
            double pin = Convert.ToDouble(Console.ReadLine());
            User user = new User();
            user.name = name;
            user.city = city;
            user.age = age;
            user.pin = pin;
            user.Print();
            Console.WriteLine();


            // Упр3
            Console.WriteLine("Упр 3");
            Console.WriteLine("Заменить строчные буквы на прописные");
            string str_1 = Console.ReadLine();
            string str_2 = "";
            foreach (char i in str_1)
            {
                str_2 += Char.IsUpper(i) ? Char.ToLower(i) : Char.ToUpper(i);
            }
            Console.WriteLine(str_2);
            Console.WriteLine();


            // Упр4
            Console.WriteLine("Упр 4");
            Console.WriteLine("Количество вхождений подстроки B в строку A");
            Console.WriteLine("Ведите строку А");
            string A = Console.ReadLine();
            Console.WriteLine("Ведите строку B");
            string B = Console.ReadLine();
            int j = 0;
            int x = -1;
            int count = -1;
            while (j != -1)
            {
                j = A.IndexOf(B, x + 1);
                x = j;
                count++;
            }
            Console.WriteLine($"Всего подстрока В входит в строку А {count} раз");
            Console.WriteLine();


            // Упр5
            Console.WriteLine("Упр 5");
            Console.WriteLine("Определить необходимое количество бутылок виски");
            Console.WriteLine("Введите стоимость одной бутылки виски");
            double normPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость бутылки виски по скидке ");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            double holidayPrice = Convert.ToDouble(Console.ReadLine());
            double profit = normPrice - salePrice;
            double count_whisky = holidayPrice / profit;
            Console.WriteLine($"Необходимо купить {count_whisky} бутылок виски");
            Console.WriteLine();


            // Упр6
            Console.Write("Упр 6");
            Console.WriteLine("");

            Console.WriteLine();


            // Упр7
            Console.Write("Упр 7");
            Console.WriteLine("");

            Console.WriteLine();


            // Упр8
            Console.WriteLine("Упр 8");
            Console.WriteLine("Сделать карточки пяти студентам и посчитать сколько они выпили");

            Student student1 = new Student();
            student1.name = "Адель";
            student1.surname = "Каримов";
            student1.id = 01;
            student1.birth = "15.01.2005";
            student1.drinked = 3;
            student1.category = (Alcohol)'c';

            Student student2 = new Student();
            student2.name = "Максим";
            student2.surname = "Емельянов";
            student2.id = 02;
            student2.birth = "27.09.2005";
            student2.drinked = 17;
            student2.category = (Alcohol)'a';

            Student student3 = new Student();
            student3.name = "Динар";
            student3.surname = "Уткузов";
            student3.id = 03;
            student3.birth = "02.12.2005";
            student3.drinked = 5;
            student3.category = (Alcohol)'b';

            Student student4 = new Student();
            student4.name = "Артём";
            student4.surname = "Евлампиев";
            student4.id = 04;
            student4.birth = "01.12.2005";
            student4.drinked = 0;
            student4.category = (Alcohol)'d';

            Student student5 = new Student();
            student5.name = "Илья";
            student5.surname = "Цымбал";
            student5.id = 05;
            student5.birth = "17.2005";
            student5.drinked = 23;
            student5.category = (Alcohol)'a';

            double all = student1.drinked + student2.drinked + student3.drinked + student4.drinked + student5.drinked;
            double stu1_per = student1.drinked / all * 100;
            double stu2_per = student2.drinked / all * 100;
            double stu3_per = student3.drinked / all * 100;
            double stu4_per = student4.drinked / all * 100;
            double stu5_per = student5.drinked / all * 100;

            student1.Print();
            Console.WriteLine("Процент выпитого алкоголя студентом 1 - {0}%", stu1_per);
            student2.Print();
            Console.WriteLine("Процент выпитого алкоголя студентом 2 - {0}%", stu2_per);
            student3.Print();
            Console.WriteLine("Процент выпитого алкоголя студентом 3 - {0}%", stu3_per);
            student4.Print();
            Console.WriteLine("Процент выпитого алкоголя студентом 4 - {0}%", stu4_per);
            student5.Print();
            Console.WriteLine("Процент выпитого алкоголя студентом 5 - {0}%", stu5_per);
            Console.WriteLine();
            Console.ReadKey();
        }
        struct User
        {
            public string name;
            public string city;
            public int age;
            public double pin;
            public void Print()
            {
                Console.WriteLine($"Имя - {name}, город проживания - {city}, возраст - {age}, пин-код - {pin}.");
            }
        }
        struct Student
        {
            public string surname;
            public string name;
            public int id;
            public string birth;
            public Alcohol category;
            public double drinked;
            public void Print()
            {
                Console.WriteLine($"Имя - {name}, фамилия - {surname}, идентификатор - {id}, дата рождения - {birth}, категория алкоголизма {category}, обьем выпитого алкоголя - {drinked}л");
            }
        }
        enum Alcohol
        {
            a = 'a', 
            b = 'b', 
            c = 'c', 
            d = 'd'
        }
    }
}
