using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_user
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Mehmet", "Karanli", "1012", User.RegistrationMonth.December);
            User user2 = new User("Polat", "Alemdar", "2122", User.RegistrationMonth.November);
            User user3 = new User("Cakir", "Suleyman", "12345", User.RegistrationMonth.March);
            User user4 = new User("Memati", "Bas", "qssc5", User.RegistrationMonth.September);
            User user5 = new User("Kilic", "Kilic ", "sa35", User.RegistrationMonth.January);
            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());
            Console.WriteLine(user5.GetDetails());

        }
    }
    }
