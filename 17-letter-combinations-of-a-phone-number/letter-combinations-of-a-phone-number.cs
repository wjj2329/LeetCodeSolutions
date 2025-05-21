public class Solution {
    public class Thing{
        public StringBuilder sb;
        public int index; 
        public Thing(){
            sb = new StringBuilder();
            index=0;
        }
    }
    public IList<string> LetterCombinations(string digits) {
        List<string>results = new List<string>();
        if(digits==null||digits==""){
            return results;
        }
        var numbers = new Dictionary<char, string>()
        {
            { '2', "abc"},
            { '3', "def"},
            { '4', "ghi"},
            { '5', "jkl"},
            { '6', "mno"},
            { '7', "pqrs"},
            { '8', "tuv"},
            { '9', "wxyz"}
        };
        Stack<Thing>myStack = new Stack<Thing>();
        myStack.Push(new Thing());
        while(myStack.Count>0){
            Thing curr = myStack.Pop();
            if(curr.index == digits.Length){
                results.Add(curr.sb.ToString());
                continue;
            }
            for(int i = 0; i<numbers[digits[curr.index]].Length; i++){
                Thing temp = new Thing();
                temp.sb = new StringBuilder(curr.sb.Length);
                temp.sb.Append(curr.sb);
                temp.sb.Append(numbers[digits[curr.index]][i]);
                temp.index = curr.index+1;
                myStack.Push(temp);
            }
        }
        return results;
    }
}