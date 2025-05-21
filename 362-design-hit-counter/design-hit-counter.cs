public class HitCounter {

    LinkedList<int>myList;
    public HitCounter() {
        myList = new LinkedList<int>();
    }
    
    public void Hit(int timestamp) {
        myList.AddLast(timestamp);
    }
    
    public int GetHits(int timestamp) {
        int cull = Math.Max(timestamp-300, 0);       
        while(myList.Count>0&&myList.First.Value<=cull){
            myList.RemoveFirst();
        }
        return myList.Count();
    }
}

/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.Hit(timestamp);
 * int param_2 = obj.GetHits(timestamp);
 */