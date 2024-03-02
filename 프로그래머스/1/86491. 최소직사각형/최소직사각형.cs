using System;

public class Solution {
    public int solution(int[,] sizes) {
        for(var i=0; i< sizes.GetLength(0); i++)
        {
            var tmp = 0;
            if(sizes[i, 0] < sizes[i, 1])
            {
                tmp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = tmp;
            }   
        }
        
        int max1 = 0;
        int max2 = 0;

        for (var i = 0; i < sizes.GetLength(0); i++)
        {
            if (max1 < sizes[i, 0]) max1 = sizes[i, 0];
            if (max2 < sizes[i, 1]) max2 = sizes[i, 1];
        }
        
        int answer = max1 * max2;

        return answer;
    }
}