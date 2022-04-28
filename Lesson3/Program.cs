using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBcool;

namespace Lesson3
{
   
    
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Classes.LogoLesson("3");
                Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.Green);
                Classes.PrintCenter("█                       ГЛАВНОЕ МЕНЮ                       █", ConsoleColor.Green);
                Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.Green);
                Console.WriteLine("");
                Classes.PrintLeft("Задача 1: Демонстрация работы структуры Complex", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 2: Демонстрация работы класса ComplexClass", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 3: Сумма всех нечётных положительных чисел", false, ConsoleColor.White);
                Classes.PrintLeft("Задача 4: Работа с дробями", false, ConsoleColor.White);
                Console.WriteLine("");
                Classes.PrintLeft("Задача 5: Выход", false, ConsoleColor.White);
                Console.WriteLine("");
                Classes.PrintLeft("Какую задачу ты хочешь выполнить: ", true, ConsoleColor.Yellow);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Task1();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 2:
                        Task2();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 3:
                        Task3();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 4:
                        Task4();
                        Console.WriteLine("");
                        Classes.PrintLeft("Для возврата нажми любую клавишу...", false, ConsoleColor.Yellow);
                        Console.ReadKey();
                        break;

                    case 5:
                        return;
                }
            }     
        }

        static void Task1() //Демонстрация работы структуры Complex
        {
            Classes.LogoLesson("3");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█          Демонстрация работы структуры Complex           █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");

            Classes.Complex complex1;
            complex1.re = 2;
            complex1.im = 4;
            Classes.Complex complex2;
            complex2.re = 5;
            complex2.im = -6;

            Classes.PrintLeft(String.Format($"Первое комплексное число {complex1.ToString()}"), false, ConsoleColor.White);
            Classes.PrintLeft(String.Format($"Второе комплексное число {complex2.ToString()}"), false, ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft(String.Format($"Результат сложения {complex1.Plus(complex2).ToString()}"), false, ConsoleColor.Yellow);
            Classes.PrintLeft(String.Format($"Результат произведения {complex1.Multi(complex2).ToString()}"), false, ConsoleColor.Yellow);
            Classes.PrintLeft(String.Format($"Результат вычитания {complex1.Minus(complex2).ToString()}"), false, ConsoleColor.Yellow);       
        }
        static void Task2() // Демонстрация работы класса ComplexClass
        {
            Classes.LogoLesson("3");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█         Демонстрация работы класса ComplexClass          █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");

            ComplexClass complex1 = new ComplexClass(2, 4);
            ComplexClass complex2 = new ComplexClass(5, -6);

            Classes.PrintLeft(String.Format($"Первое комплексное число {complex1.ToString()}"), false, ConsoleColor.White);
            Classes.PrintLeft(String.Format($"Второе комплексное число {complex2.ToString()}"), false, ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Список операций:", false, ConsoleColor.Green);
            Console.WriteLine("");
            Classes.PrintLeft("1: Сложение:", false, ConsoleColor.White);
            Classes.PrintLeft("2: Произведение", false, ConsoleColor.White);
            Classes.PrintLeft("3: Вычитание", false, ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("Какую операцию ты хочешь выполнить: ", true, ConsoleColor.Yellow);

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Classes.PrintLeft(String.Format($"Результат сложения {complex1.Plus(complex2).ToString()}"), false, ConsoleColor.Yellow);
                    break;
                case 2:
                    Classes.PrintLeft(String.Format($"Результат произведения {complex1.Multi(complex2).ToString()}"), false, ConsoleColor.Yellow);
                    break;
                case 3:
                    Classes.PrintLeft(String.Format($"Результат вычитания {complex1.Minus(complex2).ToString()}"), false, ConsoleColor.Yellow);
                    break;
            }
        }
        static void Task3() //Сумма всех нечётных положительных чисел
        {
            Classes.LogoLesson("3");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█         Сумма всех нечётных положительных чисел          █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Classes.PrintCenter("<= Для остановки просто введи 0 =>", ConsoleColor.White);
            Console.WriteLine("");
            int number, summ = 0;
            bool flag;
            do
            {
                flag = false; //меняем на false перед каждым циклом
                Classes.PrintLeft("Введи число: ", true, ConsoleColor.White);
                flag = int.TryParse(Console.ReadLine(), out number);
                if (!flag)
                {
                    number = -1;
                    Classes.PrintLeft("ERROR: Нужно указать целое число. Попробуйте еще раз! ", false, ConsoleColor.Red);
                } else 
                {
                    if (number > 0) summ = (number % 2 != 0) ? number + summ : summ;
                }

            } while (number != 0);
            Classes.PrintLeft("Cумма нечетных положительных чисел: " + summ, false, ConsoleColor.Yellow);
        }
        static void Task4() //Операции с дробями
        {
            Classes.LogoLesson("3");
            Classes.PrintCenter("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█", ConsoleColor.White);
            Classes.PrintCenter("█                    Операция с дробями                    █", ConsoleColor.White);
            Classes.PrintCenter("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█", ConsoleColor.White);
            Console.WriteLine("");
            bool flag,exit=false;
            int x,y;
            do {
                Classes.PrintLeft("Введи для первой дроби числитель: ", true, ConsoleColor.White);
                flag = false;
                flag = int.TryParse(Console.ReadLine(), out x);
                if (!flag) Classes.PrintLeft("ERROR: Нужно указать целое число. Попробуйте еще раз! ", false, ConsoleColor.Red);
            } while (!flag);
            
            do {
                Classes.PrintLeft("Введи для первой дроби знаменатель: ", true, ConsoleColor.White);
                flag = false;
                flag = int.TryParse(Console.ReadLine(), out y);
                if (!flag) Classes.PrintLeft("ERROR: Нужно указать целое число. Попробуйте еще раз! ", false, ConsoleColor.Red);
            } while (!flag);

            MyDrob a = new MyDrob(x, y); //задаем первую дробь

            do
            {
                Classes.PrintLeft("Введи для второй дроби числитель: ", true, ConsoleColor.White);
                flag = false;
                flag = int.TryParse(Console.ReadLine(), out x);
                if (!flag) Classes.PrintLeft("ERROR: Нужно указать целое число. Попробуйте еще раз! ", false, ConsoleColor.Red);
            } while (!flag);
           
            do
            {
                Classes.PrintLeft("Введи для второй дроби знаменатель: ", true, ConsoleColor.White);
                flag = false;
                flag = int.TryParse(Console.ReadLine(), out y);
                if (!flag) Classes.PrintLeft("ERROR: Нужно указать целое число. Попробуйте еще раз! ", false, ConsoleColor.Red);
            } while (!flag);

            MyDrob b = new MyDrob(x, y); //задаем вторую дробь

            Console.WriteLine("");
            Classes.PrintLeft(String.Format($"Первая дробь: {a.ToString()}"), false, ConsoleColor.Yellow);
            Classes.PrintLeft(String.Format($"Вторая дробь: {b.ToString()}"), false, ConsoleColor.Yellow);
            Classes.PrintLeft(String.Format($"Десятичная первая дробь: {a.Decimal}"), false, ConsoleColor.Yellow);
            Classes.PrintLeft(String.Format($"Десятичная вторая дробь: {b.Decimal}"), false, ConsoleColor.Yellow);

            Console.WriteLine("");
            Classes.PrintLeft("Список операций:", false, ConsoleColor.Green);
            Console.WriteLine("");
            Classes.PrintLeft("1: Сложение", false, ConsoleColor.White);
            Classes.PrintLeft("2: Вычитание", false, ConsoleColor.White);
            Classes.PrintLeft("3: Умножение", false, ConsoleColor.White);
            Classes.PrintLeft("4: Деление", false, ConsoleColor.White);
            Console.WriteLine("");
            Classes.PrintLeft("5: Вернуться в меню", false, ConsoleColor.White);
            Console.WriteLine("");      

            do
            {
                Classes.PrintLeft("Какую операцию ты хочешь выполнить: ", true, ConsoleColor.Yellow);
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("");
                        Classes.PrintLeft(String.Format($"Результат сложения до сокращения дроби {(a + b).ToString()}"), false, ConsoleColor.Green);
                        Classes.PrintLeft(String.Format($"Результат сложения после сокращения дроби {MyDrob.Sokratit((a + b)).ToString()}"), false, ConsoleColor.Green);
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("");
                        Classes.PrintLeft(String.Format($"Результат вычитания до сокращения дроби {(a - b).ToString()}"), false, ConsoleColor.Green);
                        Classes.PrintLeft(String.Format($"Результат вычитания после сокращения дроби {MyDrob.Sokratit((a - b)).ToString()}"), false, ConsoleColor.Green);
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("");
                        Classes.PrintLeft(String.Format($"Результат умножения до сокращения дроби {(a * b).ToString()}"), false, ConsoleColor.Green);
                        Classes.PrintLeft(String.Format($"Результат умножения после сокращения дроби {MyDrob.Sokratit((a * b)).ToString()}"), false, ConsoleColor.Green);
                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("");
                        Classes.PrintLeft(String.Format($"Результат деления до сокращения дроби {(a / b).ToString()}"), false, ConsoleColor.Green);
                        Classes.PrintLeft(String.Format($"Результат деления после сокращения дроби {MyDrob.Sokratit((a / b)).ToString()}"), false, ConsoleColor.Green);
                        Console.WriteLine("");
                        break;

                    case 5:
                        exit = true;
                        break;
                }
            } while (!exit);
        }

        
    }
}
