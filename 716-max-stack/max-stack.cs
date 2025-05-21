public class MaxStack {
    public class Node{
        public Node previous;
        public Node next;
        public int val;
        public Node(int val){
            this.val = val;
        }
    }
    Node curr;
    SortedDictionary<int, List<Node>>myDictionary;
    public MaxStack() {
        myDictionary = new SortedDictionary<int, List<Node>>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
    }
    
    public void Push(int x) {
        if(curr == null){
            curr = new Node(x);
        }else{
            curr.next= new Node(x);
            Node previous = curr;
            curr= curr.next;
            curr.previous = previous;
        }
        if(!myDictionary.ContainsKey(x)){
            myDictionary.Add(x, new List<Node>());
        }
        myDictionary[x].Add(curr);
    }
    
    public int Pop() {
        int val = curr.val;
        if(curr.previous == null){
            curr = null;
        }else{
            curr = curr.previous;
        }
        myDictionary[val].RemoveAt(myDictionary[val].Count-1);
        if(myDictionary[val].Count==0){
            myDictionary.Remove(val);
        }
        return val;
    }
    
    public int Top() {
        return curr.val;
    }
    
    public int PeekMax() {
        return myDictionary.First().Key;
    }
    
    public int PopMax() {
        var s = myDictionary.First(); 
        int value = s.Key;
        Node deleted = myDictionary[value][myDictionary[value].Count-1];
        myDictionary[value].RemoveAt(myDictionary[value].Count-1);
        if(myDictionary[value].Count==0){
            myDictionary.Remove(value);
        }
        //set deleted previous to point to deleted next
        if(deleted.previous!=null){
            deleted.previous.next = deleted.next;
        }
        //set deleted next to point to previous
        if(deleted.next!=null){
            deleted.next.previous = deleted.previous;
        }
        if(curr == deleted){
            curr= curr.previous;
        }
        deleted.next=null;
        deleted.previous = null;
        return value;
    }
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */