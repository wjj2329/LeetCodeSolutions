public class Solution {
    public bool IsValid(string s) {
        Stack<char>myStack = new Stack<char>();
        foreach(char c in s){
            if(c == '}'){
                if(myStack.Count!=0 && myStack.Peek()=='{'){
                    myStack.Pop();
                }else{
                    return false;
                }
            }
            else if(c == ')'){
                if(myStack.Count!=0 && myStack.Peek()=='('){
                    myStack.Pop();
                }else{
                    return false;
                }

            }else if(c == ']'){
                if(myStack.Count!=0 && myStack.Peek()=='['){
                    myStack.Pop();
                }else{
                    return false;
                }
            }else{
                myStack.Push(c);
            }
        }
        return myStack.Count==0;
    }
}