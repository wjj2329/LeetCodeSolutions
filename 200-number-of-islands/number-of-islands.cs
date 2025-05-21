public class Solution {
    private void traverse(char[][]grid, int i, int j){
        if(i<0||i>=grid.Count()||j<0||j>=grid[i].Count()){
            return;
        }
        if(grid[i][j]=='0')
        {
            return;
        }
        grid[i][j]='0';
        traverse(grid, i-1, j);
        traverse(grid, i+1, j);
        traverse(grid, i, j-1);
        traverse(grid, i, j+1);
    }
    public int NumIslands(char[][] grid) {
        int count = 0;
        for(int i = 0; i<grid.Count(); i++ ){
            for(int j = 0; j<grid[i].Count(); j++){
                if(grid[i][j]=='1'){
                    count++;
                    traverse(grid, i, j);
                }
            }
        }
        return count;
    }
}