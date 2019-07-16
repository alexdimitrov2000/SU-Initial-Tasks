using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                string[] tokens = input.Split(new[] {" => ", "."}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "dance")
                {
                    data = data
                        .ToDictionary(k => k.Key,
                            v => v.Value.ToDictionary(key => key.Key,
                                                      innerValue => innerValue.Key + "." + innerValue.Value));
                }
                else
                {
                    string selector = tokens[0];
                    string selectorObject = tokens[1];
                    string selectorProperty = tokens[2];

                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Dictionary<string, string>());
                    }
                    data[selector][selectorObject] = selectorProperty;
                }

                input = Console.ReadLine();
            }

            foreach (var elements in data)
            {
                string selector = elements.Key;
                Dictionary<string, string> innerData = elements.Value;

                foreach (var innerElements in innerData)
                {
                    string selectorObject = innerElements.Key;
                    string property = innerElements.Value;

                    Console.WriteLine($"{selector} => {selectorObject}.{property}");
                }
            }
        }
    }
}
