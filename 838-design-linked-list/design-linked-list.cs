public class MyLinkedList {
    public class Node{
        public Node(int val){
            this.val = val;
        }
        public Node next; 
        public int val;
    }
    public Node head; 
    public MyLinkedList() {
    }
    
    public int Get(int index) {
        Node curr = head;
        if(head == null){
            return -1;
        }
        for(int i = 0; i<index; i++){
            curr = curr.next;
            if(curr == null){
                return -1;
            }
        }
        
        return curr.val;
    }
    
    public void AddAtHead(int val) {
        if(head == null){
            head = new Node(val);
            return;
        }
        Node newHead = new Node(val);
        newHead.next = head;
        head = newHead;
    }
    
    public void AddAtTail(int val) {
        if(head == null){
            head = new Node(val);
            return;
        }
        Node tail = head;
        while(tail.next!=null){
            tail = tail.next;
        }
        tail.next = new Node(val);
    }
    
    public void AddAtIndex(int index, int val) {
        if(index == 0){
            if(head == null){
                head = new Node(val);
                return;
            }
            Node c = head;
            head = new Node(val);
            head.next = c;
            return;
        }
        Node curr = head;
        if(curr == null){
            return;
        }
        for(int i = 0; i<index-1; i++){
            curr = curr.next;
            if(curr == null){
            return;
            }
        }
        
        Node temp = curr.next;
        curr.next = new Node(val);
        curr.next.next = temp;
    }
    
    public void DeleteAtIndex(int index) {
        if(head == null){
            return;
        }
        if(index == 0){
            head = head.next;
            return;
        }
        Node curr = head;
        for(int i = 0; i<index-1; i++){
            curr = curr.next;
            if(curr == null || curr.next == null){
                return;
            }
        }
        if(curr == null || curr.next == null){
            return;
        }
        curr.next= curr.next.next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */