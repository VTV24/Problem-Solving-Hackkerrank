using System;
using System.Collections.Generic;
using System.Linq;


class Result
{

    /*
     * Complete the 'mostActive' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY customers as parameter.
     */

    public static List<string> mostActive(List<string> customers)
    {
        var lenght = customers.Count();
        var store = new Dictionary<string, int>();

        customers.ForEach((x) =>
        {
            if (store.ContainsKey(x))
                store[x] += 1;
            else
                store[x] = 1;
        });

        return store.Where(x => x.Value * 1.0 / lenght >= 0.05).Select(x => x.Key).OrderBy(x => x).ToList();

    }

}
class Solution
{
    public static void Main(string[] args)
    {
        int customersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> customers = new List<string>();

        for (int i = 0; i < customersCount; i++)
        {
            string customersItem = Console.ReadLine();
            customers.Add(customersItem);
        }

        List<string> result = Result.mostActive(customers);

        Console.WriteLine(String.Join("\n", result));
    }
}
