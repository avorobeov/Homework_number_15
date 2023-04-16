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
            const int MaximumNumberOfPasswordErrors = 3;
            bool isExit = false;
            string inputUserPassword;
            string password = "123";
            string message = "Привет!";
            int numberOfPasswordErrors = 0;

            while (isExit == false)
            {
                Console.WriteLine("Для просмотра сообщения ведите пароль");
                inputUserPassword = Console.ReadLine();

                if (password == inputUserPassword && numberOfPasswordErrors < MaximumNumberOfPasswordErrors)
                {
                    Console.WriteLine(message);
                    numberOfPasswordErrors = 0;
                }
                else if (password != inputUserPassword)
                {
                    Console.WriteLine("Вы указали не верный пароль попробуйте ещё раз ");
                    numberOfPasswordErrors++;
                }

                if (numberOfPasswordErrors == MaximumNumberOfPasswordErrors)
                {
                    Console.WriteLine("Вы превысили лимит вода паролей ");
                    isExit = true;
                }
            }
        }
    }
}
