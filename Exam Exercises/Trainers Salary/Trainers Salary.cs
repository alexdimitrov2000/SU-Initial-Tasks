using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLectures = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            string lecturer = "";

            var salary = budget / numberOfLectures;
            var jelev = 0;
            var RoYaL = 0;
            var roli = 0;
            var Trofon = 0;
            var sino = 0;
            var others = 0;

            for (int i = 1; i <= numberOfLectures; i++)
            {
                lecturer = Console.ReadLine();
                if (lecturer == "Jelev")
                {
                    jelev++;
                }
                else if (lecturer == "RoYaL")
                {
                    RoYaL++;
                }
                else if (lecturer == "Roli")
                {
                    roli++;
                }
                else if (lecturer == "Trofon")
                {
                    Trofon++;
                }
                else if (lecturer == "Sino")
                {
                    sino++;
                }
                else
                {
                    others++;
                }
            }
            var jelevSalary = jelev * salary;
            var RoYaLSalary = RoYaL * salary;
            var roliSalary = roli * salary;
            var TrofonSalary = Trofon * salary;
            var sinoSalary = sino * salary;
            var othersSalary = others * salary;

            Console.WriteLine($"Jelev salary: {jelevSalary:f2} lv");
            Console.WriteLine($"RoYaL salary: {RoYaLSalary:f2} lv");
            Console.WriteLine($"Roli salary: {roliSalary:f2} lv");
            Console.WriteLine($"Trofon salary: {TrofonSalary:f2} lv");
            Console.WriteLine($"Sino salary: {sinoSalary:f2} lv");
            Console.WriteLine($"Others salary: {othersSalary:f2} lv");
        }
    }
}
