public class Solution {
    public int NumSpecial(int[][] mat) {
        int count = 0; 
        for(int i=0; i<mat.Length; i++){
            for(int j=0; j<mat[i].Length; j++){
                if(mat[i][j]==1){
                    bool isValid = true;
                    for(int x =0; x<mat[i].Length; x++){
                        if(j!=x&&mat[i][x]!=0){
                            isValid = false;
                            break;
                        }
                    }
                    if(isValid){
                        for(int x =0; x<mat.Length; x++){
                        if(i!=x&&mat[x][j]!=0){
                            isValid = false;
                            break;
                        }
                    }
                        if(isValid){
                            count++;
                        }
                    }
                }
            }
        }
        return count;
    }
}