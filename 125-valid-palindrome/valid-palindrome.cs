public class Solution {
    public bool IsPalindrome(string s) {
        s = String.Concat(s.Where(c => Char.IsLetter(c)||Char.IsDigit(c))).ToLower();
        for(int i =0; i<s.Length/2; i++){
            Console.WriteLine(i);
            Console.WriteLine(s.Length-(1+i));
            if(s[i]!=s[s.Length-(1+i)]){
                return false;
            }
        }
        return true;
    }
}