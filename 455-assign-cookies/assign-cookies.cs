public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        int given = 0;
        Array.Sort(g);
        Array.Sort(s);
        int cookieIndex=0;
        int childIndex=0;
        while(childIndex<g.Length&&cookieIndex<s.Length){
            if(s[cookieIndex]>=g[childIndex]){
                given++;
                childIndex++;
            }
            cookieIndex++;
        }
        return given;
    }
}