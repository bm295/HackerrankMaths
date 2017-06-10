using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long solve(int n, int m){
        return (long)n * (long)m - 1;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        long result = solve(n, m);
        Console.WriteLine(result);
    }
}
