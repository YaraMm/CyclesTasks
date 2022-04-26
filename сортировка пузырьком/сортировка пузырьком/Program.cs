using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сортировка_пузырьком
{
    class Program
    {
        public static string BubbleSort(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < myList.Count - 1 - i; j++)
                {
                    if (myList[j] > myList[j + 1])
                    {
                        var variety = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = variety;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < myList.Count; i++) res += myList[i];
            return res;
        }
        static void Main(string[] args)
        {
            var myList = new List<int> { 9, 5, 7, 1, 6, 3, 2, 4, 8, 0 };
            Console.WriteLine(BubbleSort(myList));
        }
    }
}
