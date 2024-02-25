public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        int smallNum =0;
        int bigNum =0;
        
        if(n>m)
        {
            for(int i=1; i<m+1;i++)
            {
                if(n%i ==0 && m%i==0)
                {
                    if(smallNum< i)
                    {
                        smallNum = i;
                    }
                }
            }
        }
        else
        {
            for(int i=1; i<n+1;i++)
            {
                if(n%i ==0 && m%i==0)
                {
                    if(smallNum< i)
                    {
                        smallNum = i;
                    }
                }
            }
        }
        
        answer[0] = smallNum;
        
        int num1 =n/smallNum;
        int num2 =m/smallNum;
        
        bigNum = num1*num2*smallNum;
        
        answer[1] = bigNum;
        
        return answer;
    }
}