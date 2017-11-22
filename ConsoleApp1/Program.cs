using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine(5 + "  " + 7 + "  " + 9);
        }
        static void Task2()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        static void Task3()
        {
            int cm = 465;
            int CmVM = 100;
            Console.WriteLine("количество метров " + cm / CmVM);
        }
        static void Task4()
        {
            int days = 234;
            int DaysInWeek = 7;
            Console.WriteLine("количество недель " + days / DaysInWeek);
        }
        static void Task5()
        {
            int count = 0, desyat = 10;
            Console.WriteLine("vvedite x: ");
            int x = int.Parse(Console.ReadLine());
            if (x % desyat == 1)
            {
                count++;
            }
            if (x - x % desyat == 1)

            {
                count++;
            }
            Console.WriteLine("desyatkov = " + x / desyat + " , edinis = " + count + " , summa sifr = " + (x / desyat + x % desyat) + " , proizvedenie = " + (x / desyat * x % desyat));
        }
        static void Task6()
        {
            bool a = true, b = false, c = false;
            Console.WriteLine("a или b = " + (a || b));
            Console.WriteLine("a и b = " + (a && b));
            Console.WriteLine("b или c = " + (b || c));
        }
        static void Task7()
        {
            /*7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?*/
            int radKrug = 5, storKvad = 5;
            if(Math.PI*radKrug*radKrug>storKvad*storKvad)
            {
                Console.WriteLine("u kruga bolwe");
            }
            else
            {
                Console.WriteLine("u kvadrata bolwe");
            }
        }
        static void Task8()
        {
            int mas1 = 50, mas2 = 25;
            int v1 = 14, v2 = 35;
            if(mas1/v1>mas2/v2)
            {
                Console.WriteLine("u mas1 bolwe");
            }
            else
            {
                Console.WriteLine("u mas2 bolwe");
            }
        }
        static void Task9()
        {
            int sop1 = 180, sop2 = 255;
            int napr1 = 465, napr2 = 234;
            if (napr1 / sop1 > napr2 / sop2)
            {
                Console.WriteLine("u 2 menwe");
            }
            else
            {
                Console.WriteLine("u 1 menwe");
            }
        }
        static void Task10()
        {
            for(int i=20;i<35;i++)
            {
                Console.WriteLine(i);
            }
            int b = int.Parse(Console.ReadLine());
            if(b>10)
            {
                for(int i=10;i<b;i++)
                {
                    Console.WriteLine(i * i);
                }
            }
            else
            {
                Console.WriteLine("nope");
            }
            int a = int.Parse(Console.ReadLine());
            if (a < 50)
            {
                for (int i = a; i < 50; i++)
                {
                    Console.WriteLine(i * i*i);
                }
            }
            else
            {
                Console.WriteLine("nope");
            }
            int t = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (c > t)
            {
                for (int i = t; i < c; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            Console.ReadLine();
        }
    }
}
