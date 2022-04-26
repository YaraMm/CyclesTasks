using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace количество_по_условиям
{
    internal class Program
    {
        public static int EvenPositive(List<int> myList)
        {
            int counter = 0;
            for(int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > 0 && myList[i] % 2 == 0) counter++;
            }
            return counter;
        }
        public static int SumEvenPositive(List<int> myList)
        {
            int counter = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > 0 && myList[i] % 2 == 0) counter = counter + myList[i];
            }
            return counter;
        }
        public static int MultiplyEvenPositive(List<int> myList)
        {
            int counter = 1;
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > 0 && myList[i] % 2 == 0) counter = counter * myList[i];
            }
            return counter;
        }



        static void Main(string[] args)
        {
            var myList = new List<int> { 1, 5, -67, 234, -2546, 621, 46, -100, -243, 2534 };
            Console.WriteLine($"Количество четных положительных элементов списка равно {EvenPositive(myList)}");
            Console.WriteLine($"Их сумма равна {SumEvenPositive(myList)}");
            Console.WriteLine($"Их произведение равно {MultiplyEvenPositive(myList)}");
        }
    }
}
