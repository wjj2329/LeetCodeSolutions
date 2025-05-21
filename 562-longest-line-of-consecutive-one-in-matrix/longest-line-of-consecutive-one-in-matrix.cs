public class Solution {
    public int LongestLine(int[][] mat) {
        int longest = 0;
        for(int i =0; i<mat.Length; i++){
            for(int j = 0; j<mat[i].Length; j++){
                if(mat[i][j] == 1){
                    int row = i;
                    int col = j;
                    int count = 0;
                    while(row>=0 && mat[row][col]==1){
                        mat[row][col] = 0;
                        row--;
                        count++;
                    }
                    longest = Math.Max(count, longest);

                    col = j;
                    row = i;
                    mat[row][col]=1;
                    count = 0;
                    while(row<mat.Length && mat[row][col]==1){
                        row++;
                        count++;
                    }
                    longest = Math.Max(count, longest);
                    col = j;
                    row = i;
                    count = 0;
                    while(col<mat[row].Length && mat[row][col]==1 ){
                        col++;
                        count++;
                    }
                    longest = Math.Max(count, longest);
                    count = 0;
                    col = j;
                    row = i;
                    while(col>=0 && mat[row][col]==1){
                        col--;
                        count++;
                    }
                    longest = Math.Max(count, longest);

                    count = 0;
                    col = j;
                    row = i;
                    while(row>=0 && col>=0 && mat[row][col]==1){
                        row--;
                        col--;
                        count++;
                    }
                    longest = Math.Max(count, longest);

                    col = j;
                    row = i;
                    count = 0;
                    while(row<mat.Length && col < mat[row].Length && mat[row][col] == 1){
                        col++;
                        row++;
                        count++;
                    }
                    longest = Math.Max(count, longest);

                    col = j;
                    row = i;
                    count = 0;
                    while(row>=0 && col < mat[row].Length && mat[row][col] == 1){
                        col++;
                        row--;
                        count++;
                    }
                    longest = Math.Max(count, longest);
                    col = j;
                    row = i;
                    count = 0;
                    while(row<mat.Length && col >= 0 && mat[row][col] == 1){
                        col--;
                        row++;
                        count++;
                    }
                    longest = Math.Max(count, longest);
                }
            }
        }
        return longest;
    }
}