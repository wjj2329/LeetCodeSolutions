public class Solution {
    public string Convert(string s, int numRows) {
        List<StringBuilder>myList = new List<StringBuilder>();
        for(int i = 0; i<numRows; i++){
            myList.Add(new StringBuilder());
        }
        int index = 0;
        bool desc = true;
        while(index<s.Length){
            if(desc){
                for(int i =0; i<numRows; i++){                   
                    myList[i].Append(s[index]);
                    index++;
                    if(index>=s.Length){
                        break;
                    }
                }
                desc = false;
            }else{
                for(int x = numRows-1; x>-1; x--){                                     
                    for(int y = numRows-2; y>0; y--){
                        if(y == x){
                            myList[x].Append(s[index]);
                            index++; 
                        }                     
                        if(index>=s.Length){
                        break;
                        }        
                    }
                }
                desc = true;
            }
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<numRows; i++){
            sb.Append(myList[i]);
        }
        
        return sb.ToString();
    }
}