using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> numbers = new List<int>();
        
        numbers.Add(0);
        numbers.Add(1);
        
        for(int i=2;i<n+1;i++)
        {
            if(numbers.Count <n+1)
            {
                numbers.Add((numbers[i-1]+numbers[i-2])%1234567);
            }
        }
        
        answer = numbers[n]%1234567;
        
        return answer;
    }
}