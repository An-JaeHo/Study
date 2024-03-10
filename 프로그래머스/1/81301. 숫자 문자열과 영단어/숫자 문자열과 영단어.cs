using System;

public class Solution {
    public int solution(string s) {
        string answer =null;
        int num =0;
        //Console.WriteLine($"Measured value is {measurement}; too low.");
        while(num<s.Length)
        {
            if(Char.IsDigit(s[num]))
            {
                answer+=s[num];
                num++;
            }
            else
            {
                switch (s[num])
                {
                    case 'z' :
                        answer+='0';
                        num+=4;
                    break;
                    case 'o' :
                        answer+='1';
                        num+=3;
                    break;
                    case 't' :
                        if(s[num+1] == 'w')
                        {
                            answer+='2';
                            num+=3;
                        }
                        else
                        {
                            answer+='3';
                            num+=5;
                        }
                    break;
                    case 'f' :
                        if(s[num+1] == 'o')
                        {
                            answer+='4';
                            num+=4;
                        }
                        else
                        {
                            answer+='5';
                            num+=4;
                        }
                    
                    break;
                    case 's' :
                        if(s[num+1] == 'i')
                        {
                            answer+='6';
                            num+=3;
                        }
                        else
                        {
                            answer+='7';
                            num+=5;
                        }
                    break;
                    case 'e' :
                        answer+='8';
                        num+=5;
                    break;
                        
                    case 'n' :
                        answer+='9';
                        num+=4;
                    break;
                }
            }
        }
        
        return Int32.Parse(answer);
    }
}