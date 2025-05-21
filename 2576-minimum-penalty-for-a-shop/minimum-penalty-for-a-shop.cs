public class Solution {
     public int OpenPenalty(string s){
            int count = 0; 
            foreach(char c in s){
                if(c == 'N'){
                    count++;
                }
            }
            return count;
        }
        public int ClosePenalty(string s){
            int count = 0; 
            foreach(char c in s){
                if(c == 'Y'){
                    count++;
                }
            }
            return count;
        }
    public int BestClosingTime(string customers) {
       int maxMin = Int32.MaxValue;
       int index = 0;
       int curMin = ClosePenalty(customers);
       maxMin = curMin;
       for(int i = 0; i<customers.Length; i++){
           if(customers[i]=='Y'){
               curMin--;   
           }else{
               curMin++;
           }
           if(curMin<maxMin){
               maxMin= curMin;
               index = i+1;
           }
       }
       return index;
    }
}