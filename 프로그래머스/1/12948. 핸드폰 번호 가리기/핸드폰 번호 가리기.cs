public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        for(int i=0;i<phone_number.Length;i++)
        {
            if(i>phone_number.Length-5)
            {
                answer += phone_number[i];
            }
            else
            {
                answer+="*";
            }
        }
        
        return answer;
    }
}