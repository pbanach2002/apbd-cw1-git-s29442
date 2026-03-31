namespace apbd_cw1_git_s29442;
using System;
using System.Linq;

public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Array cannot be empty");

        return values.Average();
    }
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Array cannot be empty");

        return values.Max();
    }
}