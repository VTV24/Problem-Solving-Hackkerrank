using System;
using System.Collections.Generic;



class Result
{

    /*
     * Complete the 'getMinCost' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY crew_id
     *  2. INTEGER_ARRAY job_id
     */

    public static long getMinCost(List<int> crew_id, List<int> job_id)
    {
        long cost = 0;
        crew_id.Sort();
        job_id.Sort();

        int length1 = crew_id.Count;
        int length2 = job_id.Count;

        if (length1 == length2)
        {
            for (int i = 0; i < length1; i++)
            {
                if (job_id[i] >= crew_id[i])
                {
                    cost = cost + (job_id[i] - crew_id[i]);
                }
                else
                {
                    cost = cost + (crew_id[i] - job_id[i]);
                }
            }
        }

        return cost;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int crew_idCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> crew_id = new List<int>();

        for (int i = 0; i < crew_idCount; i++)
        {
            int crew_idItem = Convert.ToInt32(Console.ReadLine().Trim());
            crew_id.Add(crew_idItem);
        }

        int job_idCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> job_id = new List<int>();

        for (int i = 0; i < job_idCount; i++)
        {
            int job_idItem = Convert.ToInt32(Console.ReadLine().Trim());
            job_id.Add(job_idItem);
        }

        long result = Result.getMinCost(crew_id, job_id);

        Console.WriteLine(result);
    }
}
