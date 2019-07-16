using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Average_Srudent_Grades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            List<double> grades = new List<double>();

            int n = int.Parse(Console.ReadLine());
            string[] input = new string[]{};

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }

            foreach (KeyValuePair<string, List<double>> item in studentGrades)
            {
                double average = item.Value.Average();
                List<double> finalGrades = item.Value;
                Console.Write($"{item.Key} -> ");
                foreach (double grade in finalGrades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
