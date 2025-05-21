public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int[,]grid = new int[m,n];
        foreach(int[] pair in guards){
            grid[pair[0],pair[1]] = 2;
        }

        foreach(int[] pair in walls){
            grid[pair[0],pair[1]] = 3;
        } 

        foreach(int[] pair in guards){
            int row = pair[0];
            int col = pair[1];
            row--;
            while(row>=0 && grid[row,col]!=2 && grid[row,col]!=3){
                grid[row,col] = 1;
                row--;
            }
            row = pair[0];
            col = pair[1];
            row++;
            while(row<m && grid[row,col]!=2 && grid[row,col]!=3){
                grid[row,col] = 1;
                row++;
            }
            row = pair[0];
            col = pair[1];
            col--;
            while(col>=0 && grid[row,col]!=2 && grid[row,col]!=3){
                grid[row,col] = 1;
                col--;
            }
            row = pair[0];
            col = pair[1];
            col++;
            while(col<n && grid[row,col]!=2 && grid[row,col]!=3){
                grid[row,col] = 1;
                col++;
            }
        }
        int zeros = 0;
        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int col = 0; col < grid.GetLength(1); col++)
            {
                if(grid[row, col] == 0){
                    zeros++;
                }
            }
        }   
          return zeros;
    }
}