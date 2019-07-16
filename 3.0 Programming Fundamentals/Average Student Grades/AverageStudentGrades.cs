using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Student_Grades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentRecord = new Dictionary<string, List<double>>();
            int repeat = int.Parse(Console.ReadLine());
            List<double> grades = new List<double>();

            for (int i = 0; i < repeat; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!studentRecord.ContainsKey(name))
                {
                    grades.Add(grade);
                    studentRecord.Add(name, grades);
                }
            }
            string outputGrades = string.Join(" ", grades);

            foreach (KeyValuePair<string, List<double>> item in studentRecord)
            {
                string output = string.Join(" ", item.Value);
                Console.WriteLine("{0} -> {1:f2} (avg: )", 
                                    item.Key,
                                    output);
            }
        }
    }
}
