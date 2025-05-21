public class Solution {
    public int numberOfOnes(string word){
        int total =0; 
        foreach(char c in word){
            if(c =='1'){
                total++;
            }
        }
        return total;
    }
    public int NumberOfBeams(string[] bank) {
        int ammount = 0; 
        int total = 0;
        foreach(string s in bank){
            int current = numberOfOnes(s);
            if(current == 0){
                continue;
            }
            total+=(current*ammount);
            ammount = current;
        }
        return total;
    }
}