using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        int foodLength =9;
        int[] fightFood = new int[food.Length];
          
        
        for(int i=0; i<food.Length;i++)
        {
            if(food[i]/2!=0)
            {
                fightFood[i] = food[i]/2;
            }
            
            if(food[i]/2==0)
            {
                fightFood[i] = 0;
            }
        }
        
        
        for(int k=0; k<fightFood.Length;k++)
        {
            for(int j =0; j <fightFood[k]; j++)
            {
                for(int h = 0; h<foodLength;h++)
                {
                    if(k ==h)
                    {
                        answer +=h;
                    }
                }
                
            }
        }
        
        answer +="0";
        
        for(int k=(fightFood.Length-1); k>=0;k--)
        {
            for(int j =0; j <fightFood[k]; j++)
            {
                for(int h = 0; h<foodLength;h++)
                {
                    if(k ==h)
                    {
                        answer +=h;
                    }
                }
            }
        }
        
        return answer;
    }
}