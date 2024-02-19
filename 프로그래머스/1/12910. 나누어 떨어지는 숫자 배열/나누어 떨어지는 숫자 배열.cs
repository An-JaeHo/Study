using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int length =0;
        int number =0;
        
        for(int i=0; i<arr.Length;i++)
        {
            if(arr[i]%divisor ==0)
            {
                length++;
            }
        }
        
        
        int[] answer = new int[length];
        
        if(answer.Length ==0)
        {
            answer = new int[] {-1};
        }
        else
        {
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i]%divisor ==0)
                {
                    answer[number]=arr[i];
                    number++;
                }
            }
            
            Array.Sort(answer);
        }
        
        
        
        return answer;
    }
}