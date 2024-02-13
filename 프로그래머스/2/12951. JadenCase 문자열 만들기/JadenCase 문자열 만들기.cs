public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] ss = s.ToLower().Split(" ");
            
        for(int i =0; i<ss.Length;i++)
        {
            for(int j=0; j<ss[i].Length; j++)
            {
                if(j ==0)
                {
                    answer += ss[i][j].ToString().ToUpper();
                }
                else
                {
                    answer += ss[i][j];
                }
            }
            
            if(i+1 != ss.Length)
            {
                 answer += " ";
            }
        }
        
        return answer;
    }
}