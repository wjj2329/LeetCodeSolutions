public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i =0; i<9; i++){
            HashSet<char>inner = new HashSet<char>();
            HashSet<char>outer = new HashSet<char>();
            for(int j = 0; j<9; j++){
                if(inner.Contains(board[i][j])){
                    return false;
                }
                if(board[i][j]!='.'){
                    inner.Add(board[i][j]);
                }
                if(outer.Contains(board[j][i])){
                    return false;
                }
                if(board[j][i]!='.'){
                    outer.Add(board[j][i]);
                }
            }
        }
        for(int s = 0; s<3; s++){
        for(int x = 0; x<3; x++){
            HashSet<char>grid = new HashSet<char>();
            for(int y = x*3; y<3+(x*3); y++){
                for(int i = s*3; i<3+(s*3); i++){
                    if(grid.Contains(board[y][i])){
                    return false;
                    }
                    if(board[y][i]!='.'){
                    grid.Add(board[y][i]);
                    }
                                        }
                                    }
                                }
        }
        
        
        return true;
    }
}