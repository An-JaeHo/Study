using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] subs = s.Split(' ');
        
        for(int j = 0;j<subs.Length;j++)
        {
            for(int i=0 ; i<subs[j].Length;i++)
            {
                if(i%2 == 0)
                {
                    answer+= Char.ToUpper(subs[j][i]);
                }
                else
                {
                    answer+= Char.ToLower(subs[j][i]);
                }
            }
            
            if(j != subs.Length-1)
            {
                answer+= " ";
            }
        }
        
        return answer;
    }
}