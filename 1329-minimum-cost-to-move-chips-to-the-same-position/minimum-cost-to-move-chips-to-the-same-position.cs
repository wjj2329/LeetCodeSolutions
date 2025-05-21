public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int evenCost = 0; 
        int oddCost = 0;
        if(position.Length<2){
            return 0;
        }
        for(int i = 0; i<position.Length; i++){
            if(position[i]%2==0){
                oddCost++;
            }else{
                evenCost++;
            }
        }
        return Math.Min(evenCost, oddCost);
    }
}