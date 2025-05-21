public class Solution {
    public int [][]Clone(int[][]grid){
        int[][] myGrid = new int[grid.Length][];
        for(int i = 0; i<grid.Length; i++){
            myGrid[i]=new int[grid[i].Length];
            for(int j = 0; j<grid[0].Length; j++){
                myGrid[i][j]=grid[i][j];
            }
        }
        return myGrid;
    }
    public bool HasOne(int[][]grid){
        for(int i = 0; i<grid.Length; i++){
            for(int j = 0; j<grid[i].Length; j++){
                if(grid[i][j]==1){
                    return true;
                }
            }
        }
        return false;
    }
    public int OrangesRotting(int[][] grid) {
        bool hasChanged = true;
        int cycle = 0;
        while(hasChanged)
        {
            hasChanged = false;
            int[][]copy = Clone(grid);
            for(int x = 0; x<grid.Length; x++){
                for(int y = 0; y<grid[x].Length; y++){
                    if(grid[x][y]==2){
                        if(x!=0 && grid[x-1][y]==1){
                            hasChanged = true;
                            copy[x-1][y]=2;
                        }
                        if(x!=grid.Length-1 && grid[x+1][y]==1){
                            hasChanged = true;
                            copy[x+1][y]=2;
                        }
                        if(y!=0 && grid[x][y-1]==1){
                            hasChanged = true;
                            copy[x][y-1]=2;
                        }
                        if(y!=grid[x].Length-1 &&grid[x][y+1]==1){
                            hasChanged = true;
                            copy[x][y+1]=2;
                        }
                    }
                }
            }
            grid = copy;
            if(hasChanged){
                cycle++;
            }
        }
        if(HasOne(grid)){
            cycle = -1;
        }
        return cycle;
    }
}