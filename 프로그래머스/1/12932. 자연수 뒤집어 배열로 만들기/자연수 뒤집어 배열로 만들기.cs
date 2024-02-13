using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(long n) {
        string number = n.ToString();
        int[] answer = new int[number.Length];
        
        for(int i =0; i<  number.Length; i++)
        {
            answer[i] =  int.Parse(number[i].ToString());
        }
        
        //Array.Sort(answer);
        Array.Reverse(answer);
        
        return answer;
    }
}