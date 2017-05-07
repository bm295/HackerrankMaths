using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        long[] inputs = new long[t];
        BigInteger[] outputs = new BigInteger[t];
        for(int i = 0; i < t; i++) {
            inputs[i] = Convert.ToInt64(Console.ReadLine());
            outputs[i] = BigInteger.ModPow(inputs[i], 2, 1000000007);
        }
        for(int i = 0; i < t; i++) {
            Console.WriteLine(outputs[i]);
        }
    }
}
