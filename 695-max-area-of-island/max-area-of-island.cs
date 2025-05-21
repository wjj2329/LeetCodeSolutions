public class Solution {
    int max = 0;
    public void Recurse(int i, int j, int[][]grid, ref int currMax){
        if(i<0 || j<0 || i>=grid.Length ||j>=grid[i].Length){
            return;
        }
        if(grid[i][j]==0){
            return;
        }else{
            currMax++;
        }
        grid[i][j]=0;
        Recurse(i+1, j, grid, ref currMax);
        Recurse(i-1, j, grid, ref currMax);
        Recurse(i, j+1, grid, ref currMax);
        Recurse(i, j-1, grid, ref currMax);

    }
    public int MaxAreaOfIsland(int[][] grid) {
        max = 0;
        for(int i =0; i<grid.Length; i++){
            for(int j = 0; j<grid[i].Length; j++){
                if(grid[i][j]==1){
                    int tempMax = 0;
                    Recurse(i, j, grid, ref tempMax);
                    max = Math.Max(max, tempMax);
                }
            }
        }
        return max;
    }
}