public class Solution {
    public int[] PlusOne(int[] digits) {
        int index = digits.Length-1;
        digits[index]+=1;
        while(digits[index] == 10){
            digits[index]=0; 
            index--;
            if(index== -1){
                int[]result = new int[digits.Length+1];
                for(int i =1; i<result.Length; i++){
                    result[i]=digits[i-1];
                }
                result[0]=1;
                return result;
            } 
            digits[index]+=1;
        }
        return digits;
    }
}