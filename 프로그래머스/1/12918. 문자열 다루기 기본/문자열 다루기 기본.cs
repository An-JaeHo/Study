public class Solution {
    public bool solution(string s) {
        bool answer = true;
        
        if(s.Length ==4 ||s.Length ==6)
        {
            for(int i=0;i<s.Length;i++)
            {
                if(char.IsUpper(s[i]) || char.IsLower(s[i]))
                {
                    answer =false;
                }
            }
        }
        else
        {
            answer =false;
        }
        
        
        
        return answer;
    }
}