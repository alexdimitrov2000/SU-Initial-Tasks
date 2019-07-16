using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Registered_Users
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, DateTime> registration = new Dictionary<string, DateTime>();
            string format = "dd/MM/yyyy";

            while (input != "end")
            {
                string[] inpuTokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string username = inpuTokens[0];
                DateTime dateOfRegistration = DateTime.ParseExact(inpuTokens[1], format, CultureInfo.InvariantCulture);

                registration.Add(username, dateOfRegistration);

                input = Console.ReadLine();
            }

            Dictionary<string, DateTime> wantedUsers = new Dictionary<string, DateTime>();

            wantedUsers = registration.Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var wantedUserRegistrations in wantedUsers)
            {
                Console.WriteLine($"{wantedUserRegistrations.Key}");
            }
        }
    }
}
