using System;
using System.Collections.Generic;

class GoldBarPuzzle
{
    static void Main()
    {
        int[] bars = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        // First weighing
        List<int> groupI = new List<int> { 1, 2, 3, 4 };
        List<int> groupII = new List<int> { 5, 6, 7, 8 };
        List<int> groupIII = new List<int> { 9, 10, 11, 12 };

        int result = Weighing(groupI, groupII);

        // Second weighing
        if (result == 0)
        {
            result = Weighing(groupIII.GetRange(0, 3), groupI);
            if (result == 0)
            {
                // Third weighing
                result = Weighing(new List<int> { groupIII[3] }, new List<int> { groupIII[0] });
                PrintResult(result, groupIII[3]);
            }
            else
            {
                PrintResult(result, groupIII[2]);
            }
        }
        else
        {
            PrintResult(result, groupIII[0]);
        }
    }

    static int Weighing(List<int> left, List<int> right)
    {
        // Simulating weighing logic. Returns 0 if balanced, 1 if left is heavier, -1 if right is heavier.
        Console.WriteLine($"Weighing: {string.Join(",", left)} vs {string.Join(",", right)}");
        // Replace this with your actual weighing mechanism.
        return 0;
    }

    static void PrintResult(int result, int fakeBar)
    {
        if (result == 0)
            Console.WriteLine($"The fake bar is {fakeBar} and it has the same weight.");
        else if (result == 1)
            Console.WriteLine($"The fake bar is {fakeBar} and it is heavier.");
        else
            Console.WriteLine($"The fake bar is {fakeBar} and it is lighter.");
    }
}