public class Solution {
    public int LongestMountain(int[] arr) {
        int biggest = 1;
        for(int i = 1; i<arr.Length-1; i++){
            int start = i-1;
            int end = i+1;
            bool s = false;
            while(start>-1 && arr[start]<arr[start+1]){
                s = true;
                start--;
            }
            bool e = false;
            while(end <arr.Length && arr[end-1]>arr[end]){
                e = true;
                end++;
            }
            if(s && e){
            biggest = Math.Max(biggest, (end-start)-1);
            }
        }
        biggest =  biggest ==1?0:biggest;
        return biggest;
    }
}