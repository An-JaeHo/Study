using System;

class Solution 
{
    public int solution(int n) 
   {
         int answer = 0;
        int count = BinaryNumber(n);
        bool check = true;
           
        while(check == true)
        {
            n++;
            if(count == BinaryNumber(n))
            {
                answer = n;
                break;
            }
        }    
        return answer;
    }
    
    
     public int BinaryNumber(int n)
    {
        string s = Convert.ToString(n, 2);
        int count = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '1')
            {
                count++;
            }
        }
        return count;
    }
}