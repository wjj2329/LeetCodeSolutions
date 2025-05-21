public class Solution {
    public long MinimumHealth(int[] damage, int armor) {
        int largestIndex = 0;
        for(int i = 0; i<damage.Length; i++){
            if(damage[i]>damage[largestIndex]){
                largestIndex = i;
            }
        }
        damage[largestIndex]=Math.Max(0, damage[largestIndex]-armor);
        long life = 0; 
        for(int i = 0; i<damage.Length; i++){
            life+=damage[i];
        }
        return life+1;
    }
}