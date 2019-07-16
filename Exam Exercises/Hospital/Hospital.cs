using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            if (!(days >=1 && days <= 1000))
            {
                Console.WriteLine("Error");
            }
            var doctors = 7;
            var numberOfViewedPatients = 0;
            var numberOfUnviewedPatients = 0;
            var untreatedPatients = 0;
            var treatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                var numberOfPatients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }
                
                if (numberOfPatients >= 7)
                {
                    numberOfViewedPatients = doctors;
                    numberOfUnviewedPatients = numberOfPatients - numberOfViewedPatients;
                }
                else
                {
                    numberOfViewedPatients = numberOfPatients;
                    numberOfUnviewedPatients = 0;
                }
                
                
                treatedPatients += numberOfViewedPatients;
                untreatedPatients += numberOfUnviewedPatients;
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }       // 90/100
    }
}
