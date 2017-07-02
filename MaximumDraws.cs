using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var t = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[t];
        for (int i = 0; i < t; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < t; i++) {
            Console.WriteLine(arr[i] + 1);
        }
    }
}
