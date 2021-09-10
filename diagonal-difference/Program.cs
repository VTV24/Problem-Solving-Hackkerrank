using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var length = arr.Count();
        var leftToRight = 0;
        var rightToLeft = 0;

        for (int i = 0, j = length - 1; i < length & j >= 0; i++, j--)
        {
            leftToRight += arr[i][i];
            rightToLeft += arr[i][j];
        }

        return Math.Abs(rightToLeft - leftToRight);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);

        Console.ReadLine();

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
