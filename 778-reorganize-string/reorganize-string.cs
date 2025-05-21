public class Solution {
    public string ReorganizeString(string s) {
        Dictionary<char, int>myMap = new Dictionary<char, int>();
        foreach (char c in s){
            if(!myMap.ContainsKey(c)){
                myMap.Add(c, 0);
            }
            myMap[c]++;
        }
        
        string result = "";
        while(myMap.Keys.Count!=0)
        {
            int largest = 0; 
            int secondlargest = 0; 
            char largestChar = ' ';
            char secondLargestChar = ' ';
        foreach(char c in myMap.Keys){
                if(myMap[c]>largest){
                    largest = myMap[c];
                    largestChar = c;
                }else if(myMap[c]>secondlargest){
                    secondlargest = myMap[c];
                    secondLargestChar = c;
                }
        }
        if(result.Length==0||result[result.Length-1]!=largestChar){
        myMap[largestChar]--;
        if(myMap[largestChar]==0){
            myMap.Remove(largestChar);
        }
        result+=largestChar;
        }
        else{
            if(secondLargestChar==' '){
                return "";
            }
            result+=secondLargestChar;
            myMap[secondLargestChar]--;
        if(myMap[secondLargestChar]==0){
            myMap.Remove(secondLargestChar);
        }
        }
        }
        return result; 
        
    }
}