public class Solution {
    public int RomanToInt(string s) {
        int count = 0; 
        Dictionary<char, int>myMap = new Dictionary<char, int>();
        myMap.Add('I', 1);
        myMap.Add('V', 5);
        myMap.Add('X', 10);
        myMap.Add('L', 50);
        myMap.Add('C', 100);
        myMap.Add('D', 500);
        myMap.Add('M', 1000);
        for(int i = 0; i<s.Length; i++){
            char key = s[i];
            if(key == 'I'){
                if(i<s.Length-1&&s[i+1]=='V'){
                    count+=4;
                    i++;
                    continue;
                }
                if(i<s.Length-1&&s[i+1]=='X'){
                    count+=9;
                    i++;
                    continue;
                }
            }else if(key == 'X'){
                if(i<s.Length-1&&s[i+1]=='L'){
                    count+=40;
                    i++;
                    continue;
                }
                if(i<s.Length-1&&s[i+1]=='C'){
                    count+=90;
                    i++;
                    continue;
                }
            }else if(key == 'C'){
                if(i<s.Length-1&&s[i+1]=='D'){
                    count+=400;
                    i++;
                    continue;
                }
                if(i<s.Length-1&&s[i+1]=='M'){
                    count+=900;
                    i++;
                    continue;
                }
            }
            count+=myMap[key];          
        }
        return count;
    }
}