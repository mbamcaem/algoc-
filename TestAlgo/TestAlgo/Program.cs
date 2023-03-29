using System;
using System.Collections.Generic;
using System.Linq;

public static class UniqueNumbersFinder
{
    public static int FindMaxSum(List<int> numbers)
    {
        numbers.Sort(); // Sort the list in ascending order

        int largestSum = numbers[numbers.Count - 1] + numbers[numbers.Count - 2]; // Initialize largestSum as the sum of the two largest elements

        return largestSum;
    }
    public static List<int> FindUniqueNumbers(List<int> numbers)
    {
        var countDict = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
            }
            else
            {
                countDict[num] = 1;
            }
        }

        var uniqueNumbers = countDict.Where(pair => pair.Value == 1)
                                     .Select(pair => pair.Key)
                                     .ToList();

        return uniqueNumbers;
    }

    class Program
    {
        static void Main(string[] args)
        {
           

            //soal no 1
            var numbers = new List<int> { 1, 2, 1, 3, 4, 5, 4, 5, 6, 7 };
            var uniqueNumbers = UniqueNumbersFinder.FindUniqueNumbers(numbers);
            Console.WriteLine(string.Join(", ", uniqueNumbers)); // Outputs: 2, 3, 6, 7
            

            //soal no 2
            var numbersA = new List<int> { 5, 9, 7, 11, 26, 34 };
            int maxSum = FindMaxSum(numbersA);
            Console.WriteLine(maxSum); // Outputs: 20

            Console.ReadKey();



        }
    }
}
