public class Solution {
    public int Average(int[][]img, int i, int j){
        int sum = img[i][j];
        int number = 1;
        if(i>0 && j>0){
            sum+=img[i-1][j-1];
            number++;
        }
        if(i>0){
            sum+=img[i-1][j];
            number++;
        }
        if(i>0 && j<img[i].Length-1){
            sum+=img[i-1][j+1];
            number++;
        }
        if(j>0){
            sum+=img[i][j-1];
            number++;
        }
        if(j<img[i].Length-1){
            sum+=img[i][j+1];
            number++;
        }
        if(i<img.Length-1&&j>0){
            sum+=img[i+1][j-1];
            number++;
        }
        if(i<img.Length-1){
            sum+=img[i+1][j];
            number++;
        }
        if(i<img.Length-1 && j<img[i].Length-1){
            sum+=img[i+1][j+1];
            number++;
        }
        return sum/number;
    }
    public int[][] ImageSmoother(int[][] img) {
        int[][]copy = new int[img.Length][];
        for(int i=0; i<img.Length; i++){
            copy[i]=new int[img[i].Length];
            for(int j =0; j<img[i].Length; j++){
                copy[i][j]= img[i][j];
            }
        }
        for(int i = 0; i<img.Length; i++){
            for(int j = 0; j<img[i].Length; j++){
                copy[i][j]=Average(img, i, j);
            }
        }
        return copy;
    }
}