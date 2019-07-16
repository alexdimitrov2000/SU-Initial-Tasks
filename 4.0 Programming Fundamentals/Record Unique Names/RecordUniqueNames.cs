using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Unique_Names
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            string name = string.Empty;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            Console.WriteLine(string.Join("\n", uniqueNames));
        }
    }
}
