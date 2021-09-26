using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var length = arr.Count;
        var positive = 0;
        var negative = 0;
        var zero = 0;


        for (int i = 0; i < length; i++)
        {
            if (arr[i] < 0)
            {
                negative++;
                continue;
            }
            if (arr[i] > 0)
            {
                positive++;
                continue;
            }
            if (arr[i] == 0)
            {
                zero++;
                continue;
            }
        }

        Console.WriteLine("{0:N6}", positive * 1.0 / length);
        Console.WriteLine("{0:N6}", negative * 1.0 / length);
        Console.WriteLine("{0:N6}", zero * 1.0 / length);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
