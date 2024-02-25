using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        List<char> sChar = new List<char>();
        int number =0;
        int remove0 =0;
        
        while(true)
        {
            sChar.Clear();
            
            for(int i=0 ;i<s.Length; i++)
            {
                if(s[i].ToString() == "1")
                {
                    sChar.Add(s[i]);
                }
                else
                {
                    remove0++;
                }
            }
            
            s = Convert.ToString(sChar.Count,2);
            
            number++;
            
            if(s== "1")
            {
                break;
            }
        }
        
        answer[0] = number;
        answer[1] = remove0;
        
        return answer;
    }
}