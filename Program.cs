using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user_name = "admin";
            string user_passw = "123";



            while (true)
            {
                Console.Write("Adinizi daxil edin: ");
                string username = Console.ReadLine().Trim();

                Console.Write("Shifrenizi daxil edin: ");
                string password = Console.ReadLine();

                if (username.Equals(user_name) && password == user_passw)
                {
                    Console.WriteLine("Tebrikler! Sisteme daxil oldunuz!");
                    break;
                }
                else if (username != user_name && password == user_passw)
                {
                    Console.WriteLine("Bele bir istifadeci tapilmadi!");
                }
                else if (user_name == user_name && password != user_passw)
                {
                    Console.WriteLine("Shifre duzgun deyil! Tekrar yoxlayin!");
                }
                else
                {
                    Console.WriteLine("Shifre ve istifadeci adi duzgun deyil!");
                }

            }
        }
    }
}
