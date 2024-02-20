public class Solution {
    public string solution(int n) {
        string answer = "";
        for(int i =0;i<n;i++)
        {
            if(i!=0)
            {
                if(i%2==0)
                {
                    answer +="수";
                }
                else
                {
                    answer +="박";
                }
            }
            else
            {
                answer +="수";
            }
        }
        
        return answer;
    }
}