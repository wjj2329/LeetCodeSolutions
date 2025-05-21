public class MyQueue {
    Stack<int>one;
    Stack<int>two;
    public MyQueue() {
        one = new Stack<int>();
        two = new Stack<int>();
    }
    
    public void Push(int x) {
        one.Push(x);
    }
    
    public int Pop() {
        while(one.Count>0){
            two.Push(one.Pop());
        }
        int value = two.Pop();
        while(two.Count>0){
            one.Push(two.Pop());
        }
        return value;
    }
    
    public int Peek() {
        while(one.Count>0){
            two.Push(one.Pop());
        }
        int value = two.Peek();
        while(two.Count>0){
            one.Push(two.Pop());
        }
        return value;
    }
    
    public bool Empty() {
       return one.Count==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */