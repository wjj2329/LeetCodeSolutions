public class Solution {
    private void Traverse(int[][]board, int i, int j, int moves){
        if(i<0||i>=board.Length || j<0 || j>=board[i].Length){
            return;
        }
        if(board[i][j]>moves){
            board[i][j]=moves;
            Traverse(board, i-1, j, moves+1);
            Traverse(board, i+1, j, moves+1);
            Traverse(board, i, j-1, moves+1);
            Traverse(board, i, j+1, moves+1);
        }
    }

    public void WallsAndGates(int[][] rooms) {
        for(int i =0; i<rooms.Count(); i++){
            for(int j = 0; j<rooms[i].Count(); j++){
                if(rooms[i][j]==0){
                    Traverse(rooms, i+1, j, 1);
                    Traverse(rooms, i-1, j, 1);
                    Traverse(rooms, i, j-1, 1);
                    Traverse(rooms, i, j+1, 1);
                }
            }
        }
    }
}