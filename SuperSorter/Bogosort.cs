using System;
using SuperSorter;

using System.Diagnostics;

class BogoSort : ISort
{
    Stopwatch stopwatch = new Stopwatch();
    private static Random rnd;

    public void SortArray(int[] arr, int start, int end)
    {   stopwatch.Start();
        Sort(arr);
        stopwatch.Stop();
        Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }

    public static int Sort(int[] array)
    {
        int count = 0;

        while (!isSorted(array))
        {
            Shuffle(array);
            count++;
        }

        return count;
    }

    public static void Shuffle(int[] array)
    {
        if (rnd == null) rnd = new Random();

        for (int i = 0; i < array.Length; i++)
            Swap(array, i, rnd.Next(0, array.Length - 1));
    }

    private static void Swap(int[] array, int item1, int item2)
    {
        int temp = array[item1];
        array[item1] = array[item2];
        array[item2] = temp;
    }

    private static bool isSorted(int[] array)
    {
        bool ret = true;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (((IComparable)array[i]).CompareTo(((IComparable)array[i+1])) == 1)
            {
                ret = false;
                break;
            }
        }

        return ret;
    }
}







/*
	Output: Elapsed Time is 5000 ms
*/