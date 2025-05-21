public class Solution {
    public int FindLonelyPixel(char[][] picture) {
        int count = 0;
        for(int i =0; i<picture.Length; i++){
            for(int j =0; j<picture[i].Length; j++){
                if(picture[i][j]=='B'){
                    int row = i;
                    int col = j;
                    bool isLonely = true;
                    for(int x = 0; x<picture.Length; x++){
                        if(picture[x][col] == 'B' && x!=row){
                            isLonely = false;
                            break;
                        }
                    }
                    if(isLonely){
                    for(int x = 0; x<picture[row].Length; x++){
                        if(picture[row][x] == 'B' && x!=col){
                            isLonely = false;
                        }
                    }
                    }
                    if(isLonely){
                        count++;
                    }
                    
                }
            }
        }
        return count;
    }
}