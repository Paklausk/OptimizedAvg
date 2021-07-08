using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg = 0; long count = 0;
            while(double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double newValue))
            {
                count++;
                avg = avg - (avg / count) + (newValue / count);
                Console.WriteLine("AVG = " + avg);
            }
        }
    }
}
