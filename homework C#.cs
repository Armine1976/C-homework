using System;

class Program
{
    static void Main()
    {
        // Weighting I
        bool resultI = CompareSets(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 });
        
        // Weighting II
        bool resultII = CompareSets(new int[] { 1, 2, 5 }, new int[] { 3, 4, 9 });
        
        if (resultII)
        {
            // If {1, 2, 5} equals {3, 4, 9}
            // Compare 6 and 7 by Weighting III
            bool resultIII = CompareSets(new int[] { 6 }, new int[] { 7 });
            
            if (resultIII)
            {
                Console.WriteLine("The fake is 8");
            }
            else
            {
                Console.WriteLine("The fake is the light one");
            }
        }
        else
        {
            Console.WriteLine("One of 6, 7, 8 is false and the false is light");
        }
    }

    static bool CompareSets(int[] set1, int[] set2)
    {
        // Your comparison logic here
        // For simplicity, this example considers sets as equal if they have the same elements
        return SetEquals(set1, set2);
    }

    static bool SetEquals(int[] set1, int[] set2)
    {
        // Your set equality comparison logic here
        // This example assumes that sets are equal if they have the same elements
        return new HashSet<int>(set1).SetEquals(set2);
    }
}
