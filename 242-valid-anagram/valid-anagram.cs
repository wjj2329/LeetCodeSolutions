public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charS = s.ToCharArray();

        Array.Sort(charS);
        s = new string(charS);
                char[] charT = t.ToCharArray();

        Array.Sort(charT);
        t = new string(charT);
                return t == s;
    }
}