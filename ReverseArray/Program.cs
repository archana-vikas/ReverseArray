using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int[] arrReverse = new int[n];
        int i;
        //Loop to access Array elements//
        for( i=n-1; i>=0;i--)
        {
            arrReverse[i] = arr[i];
            Console.Write(arrReverse[i]);
            Console.Write(" ");
        }
        

        Console.ReadLine();
    }
}
