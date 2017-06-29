using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        int[] arrayN = GetComposedArray(n);
        int[] arrayM = GetComposedArray(m);
        var result = arrayN.Length * arrayM.Length;
        Console.WriteLine(result);
    }
        
    private static int[] GetComposedArray(int x) {
        var numberOf2 = x / 2;
        var numberOf1 = x % 2;
        int[] result = new int[numberOf2 + numberOf1];
        for(int i = 0; i < numberOf2; i++) {
            result[i] = 2;
        }
        if (numberOf1 == 1)
            result[numberOf2] = 1;
        return result;
    }
}
