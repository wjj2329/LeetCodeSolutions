public class Solution {
    public IList<string> GeneratePossibleNextMoves(string currentState) {
        List<string> myStrings = new List<string>();
        for(int i = 0; i<currentState.Length-1; i++){
            if(currentState[i]=='+'&& currentState[i+1]=='+'){
                StringBuilder temp = new StringBuilder(currentState.ToString());
                temp[i]='-';
                temp[i+1]='-';
                myStrings.Add(temp.ToString());
            }
        }
        return myStrings;
    }
}