public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int num = a-b;
        
        if(num <0)
        {
            num*=-1;
        }
        
        if(a>=b)
        {
            answer = a;   
        }
        else
        {
            answer =b;
        }
        
        
        for(int i =0; i< num;i++)
        {
            if(a>=b)
            {
                answer+=b+i;
            }
            else
            {
                answer+=a+i;
            }
        }
        
        return answer;
    }
}