public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        for(int i = matrix.Length-2; i>-1; i--){
            for(int s = 0; s<matrix[i].Length; s++){
                int min = int.MaxValue;
                if(s!=0){
                min = Math.Min(min, matrix[i+1][s-1]);
                }
                min = Math.Min(min, matrix[i+1][s]);
                if(s<matrix[i].Length-1){
                min = Math.Min(min, matrix[i+1][s+1]);
                }
                matrix[i][s]+=min;
            }
        }
        int returning = int.MaxValue; 
        for(int i = 0; i<matrix[0].Length; i++){
            returning = Math.Min(returning, matrix[0][i]);
        }
        return returning;
    }
}