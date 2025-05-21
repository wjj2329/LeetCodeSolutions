public class Solution {
    bool isFound = false;
    public void Recurse(char[][]board, string word, int i , int j, bool[][]visited, StringBuilder curr){
        if(i<0 || i>=board.Length || j<0 || j>=board[i].Length){
            return;
        }
        if(visited[i][j] || curr.Length>=word.Length||isFound){
            return;
        }
        curr.Append(board[i][j]);
        if(curr.ToString()[curr.Length-1]!= word[curr.Length-1]){
            curr.Remove(curr.Length-1, 1);
            return;
        }
        if(word.Equals(curr.ToString())){
            isFound = true;
        }
        visited[i][j]=true;
        Recurse(board, word, i+1, j, visited, curr);
        Recurse(board, word, i-1, j, visited, curr);
        Recurse(board, word, i, j+1, visited, curr);
        Recurse(board, word, i, j-1, visited, curr);
        curr.Remove(curr.Length-1, 1);
        visited[i][j]=false;
    }
    public bool Exist(char[][] board, string word) {
        if(word.Length>board.Length*board[0].Length){
            return false;
        }
        bool[][]myBool = new bool[board.Length][];
        for(int i = 0; i<board.Length; i++){
            myBool[i]=new bool[board[i].Length];
        }
        for(int i =0; i<board.Length; i++){
            for(int j = 0; j<board[i].Length; j++){
                Recurse(board, word, i, j, myBool, new StringBuilder());
            }
        }
        return isFound;
    }
}