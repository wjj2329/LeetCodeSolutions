public class LRUCache {

    int capacity;
    Dictionary<int, int>myMap;
    List<int>keys;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        myMap = new Dictionary<int, int>();
        keys = new List<int>();
    }
    
    public int Get(int key) {
        if(myMap.ContainsKey(key)){
            keys.Remove(key);
            keys.Add(key);
            return myMap[key];
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(!keys.Contains(key)){
            myMap.Add(key, value);
            keys.Add(key);
            if(keys.Count>capacity){
                var remove = keys[0];
                keys.RemoveAt(0);
                myMap.Remove(remove);
            }
        }else{
            keys.Remove(key);
            keys.Add(key);
            myMap[key]= value;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */