using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length-1];
        
        if(answer.Length ==0)
        {
            answer = new int[] {-1};
        }
        else
        {
            int number =0;
            int num=0;
            
            for(int i =0; i<arr.Length;i++)
            {
                if(i==0)
                {
                    number= arr[i];
                }
                else
                {
                    if(arr[i] < number)
                    {
                        number = arr[i];
                        num = i;
                    }
                }
            }
            
            int n =0;
            
            for(int i=0;i<arr.Length;i++)
            {
                if(i !=num)
                {
                    answer[n] = arr[i];
                    n++;
                }
                
            }
        }
        
        return answer;
    }
}