using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int n =0;
        List<int> numbers = new List<int>();
        
        while(n != s.Length)
        {
            for(int i=0;i< s.Length;i++)
            {
                if(s[n] == s[i])
                {
                    if(!numbers.Contains(s[n]))
                    {
                        numbers.Add(s[n]);
                        answer[n] = -1;
                        continue;
                    }
                    
                    if(n > i)
                    {
                        answer[n] = n-i;
                    }
                }
            }
            n++;
        }
        
        return answer;
    }
}