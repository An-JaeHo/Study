public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string number = x.ToString();
        int num=0;
        
        for(int i=0;i< number.Length;i++)
        {
            num += number[i]-'0';
        }
        
        if(x%num ==0)
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