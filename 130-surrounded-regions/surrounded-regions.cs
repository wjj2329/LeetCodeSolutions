public class Solution {
    public void Mark(char[][]board, int x, int y){
        if(x<0 || x>=board.Length || y<0 || y>=board[x].Length || board[x][y]!='I'){
            return;
        }
        board[x][y]='X';
        Mark(board, x+1, y);
        Mark(board, x-1, y);
        Mark(board, x, y+1);
        Mark(board, x, y-1);          
    }
    public void UnMark(char[][]board, int x, int y){
        if(x<0 || x>=board.Length || y<0 || y>=board[x].Length || board[x][y]!='I'){
            return;
        }
        board[x][y]='O';
        UnMark(board, x+1, y);
        UnMark(board, x-1, y);
        UnMark(board, x, y+1);
        UnMark(board, x, y-1);    
    }
    public bool Check(char[][]board, int x, int y){
        if(x<0 || x>=board.Length || y<0 || y>=board[x].Length){
            return false;
        }
        if(board[x][y]!='O'){
            return true;
        }
        board[x][y]='I';
        return Check(board, x+1, y) && Check(board, x-1, y) && Check(board, x, y+1) && Check(board, x, y-1);
    }
    public void Solve(char[][] board) {
        for(int i = 1; i<board.Length-1; i++){
            for(int j = 1; j<board[i].Length-1; j++){
                if(board[i][j] == 'O'){         
                    if(Check(board, i, j)){
                        Mark(board, i, j);
                    }else{
                        UnMark(board, i, j);
                    }
                }
            }
        }
    }
}