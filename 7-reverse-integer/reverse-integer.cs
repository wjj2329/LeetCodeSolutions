public class Solution {
    public int Reverse(int x) {
        string s = x.ToString();
        bool isNegative = false;
        if(s[0]=='-'){
            isNegative = true;
            s = s.Substring(1, s.Length-1);
        }
        StringBuilder sb = new StringBuilder();
        if(isNegative){
            sb.Append("-");
        }
        for(int i =s.Length-1; i>-1; i--){
            sb.Append(s[i]);
        }
        try{
        return Int32.Parse(sb.ToString());
        }catch(Exception e){
            return 0;
        }
    }
}