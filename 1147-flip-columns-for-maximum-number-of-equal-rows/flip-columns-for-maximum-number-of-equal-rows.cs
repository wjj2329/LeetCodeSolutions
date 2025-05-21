public class Solution {
    public int MaxV(int[][]matrix){
        int ones = 0;
        int zeros = 0; 
        for(int i =0; i<matrix.Length; i++){
            bool isZero = true;
            bool isOne = true;
            for(int j = 0; j<matrix[i].Length; j++){
                if(matrix[i][j]==0){
                    isOne = false;
                }else{
                    isZero = false;
                }
                if(!isOne && !isZero){
                    break;
                }
            }
            if(isZero){
                zeros++;
            }
            if(isOne){
                ones++;
            }
        }
        return ones+zeros;
    }
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        int max = 0;
        //max = Math.Max(max, MaxV(matrix));
        //go row by row at a time make it all 0 and then make it all 1 and see how many other rows go for the ride
        for(int i = 0; i<matrix.Length; i++){//each row
            // first try zeros
            for(int j = 0; j<matrix[i].Length; j++){
                if(matrix[i][j]==1){// we need to flip to zero
                    for(int x = 0; x<matrix.Length; x++){
                        matrix[x][j] = matrix[x][j]==0?1:0;
                    }
                }
            }
            max = Math.Max(max, MaxV(matrix));
        }
        return max;
    }
}