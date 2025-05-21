public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int index=0; 
        while(index<matrix.Length-1 &&target > matrix[index][matrix[index].Length-1]){
            index++;
        }
        for(int i =0; i<matrix[index].Length; i++){
            if(matrix[index][i] == target){
                return true;
            }
        }
        return false;
    }
}