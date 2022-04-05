using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИндексМинМакс
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int> { 1, 5, 3, 7, 2, 11, 37, 89, 0 };
            int minNum = myList[0];
            int maxNum = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] < minNum) { minNum = myList[i]; }
                if (myList[i] > maxNum) { maxNum = myList[i]; }
            }
            int minIndex = 0;
            int maxIndex = 0;
            for(int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == minNum) {  minIndex = i; }
                if (myList[i] == maxNum) { maxIndex = i; }
            }
            Console.WriteLine($"Индекс минимального числа:{minIndex}/nИндекс максимального числа: {maxIndex}");
        }
    }
}
