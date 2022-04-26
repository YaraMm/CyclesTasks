using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поиск_второго_мин_макс
{
    class Program
    {/*
        public static int SecondMinMax(List<int> myList)
        {
            myList = new List<int> { 1, 5, 3, 7, 2, 11, 37, 89, 0 };
            int minNum = myList[0];
            int maxNum = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] < minNum) { minNum = myList[i]; }
                if (myList[i] > maxNum) { maxNum = myList[i]; }
            }
            int secondMinNum = myList[0];
            int secondMaxNum = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] < secondMinNum && myList[i] != minNum) secondMinNum = myList[i];
                if (myList[i] > secondMinNum && myList[i] != maxNum) secondMaxNum = myList[i];
            }
        }*/
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
            int secondMinNum = myList[0];
            int secondMaxNum = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] < secondMinNum && myList[i] != minNum) secondMinNum = myList[i];
                if (myList[i] > secondMinNum && myList[i] != maxNum) secondMaxNum = myList[i];
            }
            Console.WriteLine($"min num ={minNum}");
            Console.WriteLine($"max num ={maxNum}");
            Console.WriteLine($"second min num ={ secondMinNum}");
            Console.WriteLine($"second max num ={ secondMaxNum}");

        }
    }
}

