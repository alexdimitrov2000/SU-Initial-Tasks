using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Pipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var firstPipeDebit = int.Parse(Console.ReadLine());
            var secondPipeDebit = int.Parse(Console.ReadLine());
            var hoursMissing = double.Parse(Console.ReadLine());

            var firstPipeFill = hoursMissing * firstPipeDebit;
            var secondPipeFill = hoursMissing * secondPipeDebit;
            var totalFill = firstPipeFill + secondPipeFill;

            if (totalFill <= capacity)
            {
                var summedPercent = Math.Truncate(totalFill / capacity * 100);
                var firstPipePercent = Math.Truncate(firstPipeFill / totalFill * 100);
                var secondPipePercent = Math.Truncate(secondPipeFill / totalFill * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", summedPercent, firstPipePercent, secondPipePercent);
            }

            else
	        {
		        var overFlow = totalFill - capacity;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursMissing, overFlow);
	        }            
        }
    }
}
