public class MyCircularDeque {
    List<int>myList; 
    int size =0; 
    public MyCircularDeque(int k) {
        myList = new List<int>(k);
        size = k;
    }
    
    public bool InsertFront(int value) {
        if(myList.Count<size){
            myList.Insert(0, value);
            return true;
        }
        return false;
    }
    
    public bool InsertLast(int value) {
        if(myList.Count<size){
            myList.Add(value);
            return true;
        }
        return false;
    }
    
    public bool DeleteFront() {
        if(myList.Count>0){
            myList.RemoveAt(0);
            return true;
        }
        return false;
    }
    
    public bool DeleteLast() {
        if(myList.Count>0){
            myList.RemoveAt(myList.Count-1);
            return true;
        }
        return false;
    }
    
    public int GetFront() {
        if(myList.Count>0)
            return myList[0];
        return -1;
    }
    
    public int GetRear() {
        if(myList.Count>0)
            return myList[myList.Count-1];
        return -1;
    }
    
    public bool IsEmpty() {
        return myList.Count==0;
    }
    
    public bool IsFull() {
        return myList.Count==size;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */