public class Solution {
    public string LargestOddNumber(string num) {       
            int index = num.Length-1;
            while(index >= 0&& (num[index]-'0') % 2==0)
            {
                index--;
            }
            return num.Substring(0, index+1);
    }
}