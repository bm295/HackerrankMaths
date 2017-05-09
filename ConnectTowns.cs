using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] outputs = new int[n];
        for(int i = 0; i < n; i++) {
            var townCount = Convert.ToInt32(Console.ReadLine());
            string[] routeLine = Console.ReadLine().Split(' ');
            int[] routes = Array.ConvertAll(routeLine, Int32.Parse);
            outputs[i] = 1;
            for(int j = 0; j < townCount - 1; j++) {
                outputs[i] = (outputs[i] * routes[j]) % 1234567;
            }
        }
        for(int i = 0; i < n; i++) {
            Console.WriteLine(outputs[i]);
        }
    }
}
