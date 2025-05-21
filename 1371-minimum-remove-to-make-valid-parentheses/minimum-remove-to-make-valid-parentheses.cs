public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x)); 
        Stack<int>myStack = new Stack<int>();
        SortedSet<int>removals = new SortedSet<int>(comparer);
        for(int i =0; i<s.Length; i++){
            if(s[i]=='('){
                myStack.Push(i);
            }else{
                if(s[i]==')'){
                    if(myStack.Count>0){
                        myStack.Pop();
                    }else{
                        removals.Add(i);
                    }
                }
            }
        }
        foreach(int c in myStack){
            removals.Add(c);
        }
        StringBuilder sb = new StringBuilder(s);
        foreach(int c in removals){
            sb.Remove(c, 1);
        }
        return sb.ToString();
    }
}