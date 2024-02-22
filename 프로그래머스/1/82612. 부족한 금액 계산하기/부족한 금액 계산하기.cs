using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        for(int i=1; i< count+1;i++)
        {
            money -= price*i;
        }
        
        if(money<0)
        {
            money *= -1;
        }
        else
        {
            money =0;
        }
        
        return money;
    }
}