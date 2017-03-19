using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new List<int>();
            var continueSeries = true;
            var maxInSeries = 100;

            fibonacci.Add(0);
            fibonacci.Add(1);

            while(continueSeries)
            {
                var index = fibonacci.Count;
                var nextInSeries = fibonacci[index - 1] + fibonacci[index - 2];

                if (nextInSeries < maxInSeries)
                    fibonacci.Add(nextInSeries);
                else
                    continueSeries = false;
            }

            foreach(var entry in fibonacci)
                Console.WriteLine(entry);

            Console.ReadLine();
        }
    }
}
