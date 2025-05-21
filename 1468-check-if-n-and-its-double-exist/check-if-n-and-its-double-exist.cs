public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int>mySet = new HashSet<int>();
        foreach(int i in arr){
            mySet.Add(i);
        }
        bool hasZero = false;
        foreach(int i in arr){
            if(i == 0){
              if(hasZero==false){
                hasZero = true;
              }else{
                return true;
              }
            }
            
            if(i!=0 && mySet.Contains(i*2)){
                return true;
            }
        }
        return false;
    }
}