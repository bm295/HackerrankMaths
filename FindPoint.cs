using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = Convert.ToInt32(Console.ReadLine());
        int[] results = new int[2 * n];
        for (int i = 0; i < n; i++) {
            string[] tmp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(tmp, Int32.Parse);
            int[] ret = new int[2];
            ret[0] = 2 * arr[2] - arr[0];
            ret[1] = 2 * arr[3] - arr[1];
            results[i * 2] = ret[0];
            results[i * 2 + 1] = ret[1];
        }
        for (int i = 0; i < n; i++) { 
            Console.WriteLine(string.Format("{0} {1}", results[i * 2], results[i * 2 + 1]));
        }
    }
}
