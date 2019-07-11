using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //char symbol;
            //int countSpaces = 0;
            //do
            //{
            //    Console.WriteLine("\nВведите символы:\n");
            //    symbol = Console.ReadKey().KeyChar;
            //    if(symbol == ' ')
            //    {
            //        countSpaces++;
            //    }
            //} while (symbol != '.');
            //Console.WriteLine("\nКнопка space нажата {0} раз", countSpaces);
            //Console.ReadKey();

            //задание 2
            //int ticketNum, leftNum = 0, rightNum = 0;
            //Console.WriteLine("Введите 6-ти значной номер автобусного билета:");
            //if (int.TryParse(Console.ReadLine(), out ticketNum))
            //{
            //    if(ticketNum < 100000 || ticketNum > 999999)
            //    {
            //        Console.WriteLine("Введенное число не корректно");
            //    }
            //    else
            //    {
            //        for(int i = 0; i < 6; i++)
            //        {
            //            if (i >= 3)
            //            {
            //                rightNum += ticketNum % 10;
            //                ticketNum /= 10;
            //            }
            //            else if(i < 3)
            //            {
            //                leftNum += ticketNum % 10;
            //                ticketNum /= 10;
            //            }
            //        }
            //    }
            //    if(rightNum == leftNum)
            //    {
            //        Console.WriteLine("Поздравляю, у вас счастливый билет");
            //    }
            //    else
            //    {
            //        Console.WriteLine("К сожалению у вас не счастливый билет");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Неверная команда");
            //}
            //Console.ReadKey();

            //задание 3
            //char symbol;
            //do
            //{
            //    Console.WriteLine("\nВведите символ:\n");
            //    symbol = Console.ReadKey().KeyChar;
            //    int temp = symbol;
            //    if (symbol >= 65 && symbol <= 90)
            //    {
            //        temp += 32;
            //        symbol = (char)temp;
            //        Console.WriteLine("\n" + symbol);
            //    }
            //    else if(symbol >= 97 && symbol <= 122)
            //    {
            //        temp -= 32;
            //        symbol = (char)temp;
            //        Console.WriteLine("\n" + symbol);
            //    }
            //} while (symbol != ' ');
            //Console.ReadKey();

            //задача 4
            //Console.WriteLine("Введите первое число:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число:");
            //int number2 = int.Parse(Console.ReadLine());
            //for(int i = number1; i <= number2; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //задача 5
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            while (number > 0)
            {
                //result *= 10;
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
