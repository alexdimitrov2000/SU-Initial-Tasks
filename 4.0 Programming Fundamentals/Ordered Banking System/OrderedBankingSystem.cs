using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var allData = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                string[] tokens = input.Split(new [] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string bank = tokens[0];
                string account = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!allData.ContainsKey(bank))
                {
                    allData.Add(bank, new Dictionary<string, decimal>());
                }
                if (!allData[bank].ContainsKey(account))
                {
                    allData[bank].Add(account, 0);
                }
                allData[bank][account] += balance;

                input = Console.ReadLine();
            }

            var sortedDict = allData
                .OrderByDescending(v => v.Value.Values.Sum())
                .ThenByDescending(v => v.Value.Values.Max())
                .ToDictionary(k => k.Key, v => v.Value);
            
            foreach (var data in sortedDict)
            {
                string currentBank = data.Key;
                Dictionary<string, decimal> currentAccountDetails = data.Value;
                var sortedAccountsData = currentAccountDetails
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var accountDetails in sortedAccountsData)
                {
                    string currentAccount = accountDetails.Key;
                    decimal currentBalance = accountDetails.Value;
                    
                    Console.WriteLine($"{currentAccount} -> {currentBalance} ({currentBank})");
                }
            }
        }
    }
}
