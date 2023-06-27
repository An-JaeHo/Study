public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] numbers = s.Split(" ");
        int[] numberArray = new int[numbers.Length];
        
        for(int i=0; i<numbers.Length; i++)
        {
            numberArray[i]= System.Int32.Parse(numbers[i]);
        }
        
        System.Array.Sort(numberArray);
        
        answer = numberArray[0]+" "+numberArray[numberArray.Length-1];
        
        return answer;
    }
}