using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int check =0;
        
        if(s[0].ToString() ==")")
        {
            return answer = false;
        }
        
        for(int i=0; i<s.Length;i++)
        {
            if(s[i].ToString() == ")" )
            {
                if(check == 0)
                {
                    return answer = false;   
                }
                
                check -= 1;
            }
            
            if(s[i].ToString() == "(")
            {
                check += 1;
            }
        }
        
        if(check ==0)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        
        
        
        return answer;
    }
}