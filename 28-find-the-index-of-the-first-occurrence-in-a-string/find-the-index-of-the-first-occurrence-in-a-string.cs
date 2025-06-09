public class Solution {
    public int StrStr(string haystack, string needle) {
        for(int i = 0; i<haystack.Length; i++){
            int index = 0;
            while(index<needle.Length && index+i<haystack.Length && needle[index]==haystack[index+i]){
                index++;
            }
            if(index == needle.Length){
                return i;
            }
        }
        return -1;
    }
}