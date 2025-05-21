public class Solution {
    public string BetterCompression(string compressed) {
        Dictionary<char, int>myMap = new Dictionary<char, int>();
        for(int i =(int)'a'; i<=(int)'z'; i++){
            myMap.Add((char)i, 0);
        }
        char currentLetter =' ';
        StringBuilder currentNum = new StringBuilder();
        for(int i =0; i<compressed.Length; i++){
            if(Char.IsLetter(compressed[i])){
                currentLetter = compressed[i];
            }else{
                currentNum.Append(compressed[i]);
            }
            if(i>=compressed.Length-1|| Char.IsLetter(compressed[i+1])){
                myMap[currentLetter]+=Int32.Parse(currentNum.ToString());
                currentNum = new StringBuilder();
            }
        }
        StringBuilder result = new StringBuilder();
        foreach(char key in myMap.Keys){
            if(myMap[key]!=0){
                result.Append(key);
                result.Append(myMap[key]);
            }
        }
        return result.ToString();
    }
}