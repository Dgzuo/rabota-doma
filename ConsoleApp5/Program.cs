using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 12;
            Console.WriteLine("Компьютер Загадал Число ОТ 1-20.Попробуйте его угадать");
            int userNumber = int.Parse(Console.ReadLine());
            if(userNumber == secretNumber)
            {
                Console.WriteLine("Вы УГАДАЛИ!!!");
            }

            if(userNumber<secretNumber)
            {
                Console.WriteLine("Секретное число больше");
            }

            if(userNumber>secretNumber)
            {
                Console.WriteLine("Секретное число меньше");
                
            }
            Console.ReadKey();
        }
    }
}
