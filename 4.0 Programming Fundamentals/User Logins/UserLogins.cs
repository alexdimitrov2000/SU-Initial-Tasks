using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> accounts = new Dictionary<string, string>();

            int countOfUnsuccessfulLogins = 0;
            string[] inputUserPass = Console.ReadLine().Split(new char[]{ ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            while (inputUserPass[0] != "login")
            {
                string user = inputUserPass[0];
                string password = inputUserPass[1];

                accounts[user] = password;

                inputUserPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            inputUserPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            while (inputUserPass[0] != "end")
            {
                string userToLogin = inputUserPass[0];
                string passwordToLogin = inputUserPass[1];

                if (accounts.ContainsKey(userToLogin))
                {
                    if (accounts[userToLogin] != passwordToLogin)
                    {
                        Console.WriteLine($"{userToLogin}: login failed");
                        countOfUnsuccessfulLogins++;
                    }
                    else
                    {
                        Console.WriteLine($"{userToLogin}: logged in successfully");
                    }
                }
                else
                {
                    Console.WriteLine($"{userToLogin}: login failed");
                    countOfUnsuccessfulLogins++;
                }
                inputUserPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            Console.WriteLine($"unsuccessful login attempts: {countOfUnsuccessfulLogins}");
        }
    }
}
