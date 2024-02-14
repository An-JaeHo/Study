using System;
using System.Collections;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        string number = n.ToString();
        int[] numbers = new int[number.Length];
        
        for(int i=0; i<number.Length;i++)
        {
            numbers[i] = int.Parse(number[i].ToString());
        }
        
        Array.Sort(numbers);
        Array.Reverse(numbers);
        
        
        for(int i=0; i<numbers.Length;i++)
        {
            answer+=numbers[i]*(long)Math.Pow(10,(numbers.Length-i-1));
        }
        
        return answer;
    }
}