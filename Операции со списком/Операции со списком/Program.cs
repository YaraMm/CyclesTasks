using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_со_списком
{
    class Program
    { 
        public static int ArraysSum (List<int> myList)
        {
            int SumList = 0;
            for(int i = 0; i < myList.Count; i++) { SumList += myList[i]; }
            return SumList;
        }
        public static int ArraysMultiply (List<int> myList)
        {
            int MultiplyList = 1;
            for(int i = 0; i < myList.Count; i++) { MultiplyList *= myList[i]; }
            return MultiplyList;
        }
        public static int MidleNumber (List<int> myList)
        {
            return ArraysSum(myList) / myList.Count;
        }
        public static int MinDifferenceOfList(List<int> myList)
        {
            var differences = new List<int>();
            int midleNum = MidleNumber(myList);
            for (int i = 0; i < myList.Count; i++)
            {
                differences.Add(Math.Abs(midleNum - myList[i]));
            }
            int minDifference = Int32.MaxValue;
            for (int i = 0; i < differences.Count; i++) { if (differences[i] != 0 && differences[i] <= minDifference) { minDifference = differences[i]; } }
            return minDifference;
        }
        public static int NearestMidleNum (List<int> myList)
        {
            int midleNum = MidleNumber(myList);
            int minDifference = MinDifferenceOfList(myList);
            int nearestMidleNum = 0;
            
            for(int i = 0; i < myList.Count; i++)
            {
                if((Math.Abs(midleNum - myList[i])) == minDifference)
                {
                    nearestMidleNum = myList[i];
                }
            }
            return nearestMidleNum;
        }
        public static int IndexOfNearestMidleNumber(List<int> myList)
        {
            int minDifference = MinDifferenceOfList(myList);
            int midleNum = MidleNumber(myList);
            int indexMidleNum = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if ((Math.Abs(midleNum - myList[i])) == minDifference)
                {
                    indexMidleNum = i;
                }
            }
            return indexMidleNum;
        }
        public static int MedianOfList(List<int> myList)
        {
            var assortedList = new List<int>();
            for(int i = 0; i < myList.Count; i++)
            {
                for(int j = 0; j < myList.Count; j++)
                {
                    if(myList[i] < myList[j]) { assortedList.Add(myList[i]);  }
                }
            }
            return myList[1];
        }


        static void Main(string[] args)
        {
            var myList = new List<int> { 1, 4, 6, 90, 56, 2, 6, 9 };
            Console.WriteLine($"Сумма массива равна {ArraysSum(myList)}");
            Console.WriteLine($"Произведение элементов массива равна {ArraysMultiply(myList)}");
            Console.WriteLine($"Среднее значение массива {MidleNumber(myList)}");
            Console.WriteLine($"Ближайшее к среднему значению {NearestMidleNum(myList)}");
            Console.WriteLine($"Индекс ближайшего к среднему {IndexOfNearestMidleNumber(myList)}");
            Console.WriteLine(MedianOfList(myList));
        }
    }
}
