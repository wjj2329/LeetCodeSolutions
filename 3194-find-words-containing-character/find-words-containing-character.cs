public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int>myList = new List<int>();
        for(int i = 0; i<words.Length; i++){
            bool contains = false;
            for(int s = 0; s<words[i].Length; s++){
                if(words[i][s]==x){
                    contains = true;
                    break;
                }
            }
            if(contains){
                myList.Add(i);
            }
        }
        return myList;
    }
}