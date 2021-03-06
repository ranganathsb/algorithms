﻿using System;

namespace Algorithms.SortAlgorithms
{
    /// <summary>
    /// Take d (Fibonaccy sequense or (N, N/2, etc) or 2^i - 1 and etc
    /// Get all elements which indecies i and i+d
    /// Swap if needed
    /// Best:               O(n log(n))
    /// Average:            O(n log(n)^2)
    /// Worst:              O(n log(n)^2)
    /// Additional memory:  1 
    /// </summary>
    /// <remarks>
    /// + No callstack
    /// + O(1) additional memoty
    /// + No degradation in "bad" data cases
    /// </remarks>
    /// <typeparam name="T">Type of array's elements</typeparam>
    public class ShellSorter<T> : ISorter<T> where T : IComparable
    {
        public void sort(T[] array)
        {
            for (var d = array.Length / 2; d > 0; d /= 2)           // go throw d sequence
            {
                for (var i = d; i < array.Length; i++)              // go from d element to the end
                {
                    var temp = array[i];
                    var j = i;
                    for (j = i; j >= d; j -= d)                     // see back with step = d till begin
                    {
                        if (temp.CompareTo(array[j - d]) < 0)                    // find place to insert temp, until element is bigger
                        {
                            array[j] = array[j - d];                // insert sort
                        }
                        else
                        {
                            break;
                        }
                    }

                    array[j] = temp;
                }
            }
        }
    }
}
