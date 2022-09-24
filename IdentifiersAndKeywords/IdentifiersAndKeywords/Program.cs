using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiersAndKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte smallNum = 1;
            int largeNum = 100;
            float pointValue = 2.5f;
            double largePointValue = 3.7;
            decimal valueOfPi = 3.14m;
            char singleLetter = 'a';
            bool isItWorking = true;

            Console.WriteLine(smallNum);
            Console.WriteLine(largeNum);
            Console.WriteLine(pointValue);
            Console.WriteLine(largePointValue);
            Console.WriteLine(valueOfPi);
            Console.WriteLine(singleLetter);
            Console.WriteLine(isItWorking);

            Console.ReadLine();
        }
    }
}
