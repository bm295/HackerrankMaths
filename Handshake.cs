using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int T = Convert.ToInt32(Console.ReadLine());
        int[] results = new int[T];
        for(int a0 = 0; a0 < T; a0++){
            int N = Convert.ToInt32(Console.ReadLine());
            results[a0] = N * (N - 1) / 2;            
        }
        for (int i = 0; i < T; i++) {
            Console.WriteLine(results[i]);
        }
    }
}
