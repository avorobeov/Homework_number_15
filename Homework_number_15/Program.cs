using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_number_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxTryCount = 3;
            string inputUserPassword;
            string password = "123";
            string message = "Привет!";

            for (int i = 0; i < MaxTryCount;)
            {
                Console.WriteLine("Для просмотра сообщения ведите пароль");
                inputUserPassword = Console.ReadLine();

                if (password == inputUserPassword)
                {
                    Console.WriteLine(message);
                    i = 0;
                }
                
                if (password != inputUserPassword)
                {
                    Console.WriteLine("Вы указали не верный пароль попробуйте ещё раз ");
                    i++;
                }
            }
        }
    }
}
