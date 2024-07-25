using AssigmentADV01.generic_Range;
using AssigmentADV01.SortAlgorithm;

namespace AssigmentADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1.The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm


            int[] numbers = { 10, 7, 8, 30, 15, 1, 9, 6, 4 };

           
            BubbleSort.Sort(numbers);

            Console.WriteLine("Sorted array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            #endregion



            #region 2.generic Range
            var intRange = new Range<int>(1, 5);
            Console.WriteLine(intRange.IsInRange(3)); 
            Console.WriteLine(intRange.IsInRange(7)); 
            Console.WriteLine(intRange.Length()); 


            var decimalRange = new Range<decimal>(3.5m, 9.8m);
            Console.WriteLine(decimalRange.IsInRange(7.2m)); 
            Console.WriteLine(decimalRange.IsInRange(5.0m)); 
            Console.WriteLine(decimalRange.Length()); 
            #endregion





        }
    }
}
