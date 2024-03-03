public class Solution {
    public string solution(string s, int n) {
         string answer = "";
        
        char[] arr = s.ToCharArray();
        
        for(int i=0;i<s.Length;i++){
            int a = arr[i];
            if(a>='a'&&a<='z')
                answer+=(char)('a'+(a-'a'+n)%26);
            else if(a>='A'&&a<='Z')
                answer+=(char)('A'+(a-'A'+n)%26);
            else
                answer+=" ";
        }
        
        return answer;
    }
}