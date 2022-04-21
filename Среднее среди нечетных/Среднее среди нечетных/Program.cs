using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее_среди_нечетных
{
    internal class Program
    {
        public static int MidleFromNegativeLessTen(List<int> myList)
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > -10) { sum += myList[i]; counter++; }
            }
            return sum / counter;
        }

        static void Main(string[] args)
        {
            var myList = new List<int> { -9, -12, -4, 5, 6, -10, 8, 60};
            Console.WriteLine(MidleFromNegativeLessTen(myList));
        }
    }
}
