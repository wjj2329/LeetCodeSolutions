public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int[] result = new int[spells.Length];
        for(int i = 0; i<spells.Length; i++){
            int left = 0;
            int right = potions.Length-1;
            while(left<=right){
                int middle = (left+right)/2;
                if(middle == potions.Length-1){
                    break;
                }
                long value = (long)potions[middle]*spells[i];
                long nextValue = (long)potions[middle+1]*spells[i];
                if(value<success && nextValue>=success){
                    result[i]=potions.Length-1-middle;
                    break;
                }
                if(value<success){
                    left = middle+1;
                }else{
                    right = middle-1;
                }
            }
            long yourmom = (long)potions[0]*spells[i];
            if(left <= 0 && right <= 0 && yourmom >=success){
                result[i]=potions.Length;
            }
        }
        return result; 
    }
}