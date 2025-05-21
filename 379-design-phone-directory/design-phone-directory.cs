public class PhoneDirectory {
    HashSet<int>slots = new HashSet<int>();
    public PhoneDirectory(int maxNumbers) {
        for(int i =0; i<maxNumbers; i++){
            slots.Add(i);
        }
    }
    
    public int Get() {
        if(slots.Count>0){
            foreach(int s in slots){
                int first = s;
                slots.Remove(s);
                return first;
            }
            return -1;
        }else{
            return -1;
        }
    }
    
    public bool Check(int number) {
        return slots.Contains(number);
    }
    
    public void Release(int number) {
        slots.Add(number);
    }
}

/**
 * Your PhoneDirectory object will be instantiated and called as such:
 * PhoneDirectory obj = new PhoneDirectory(maxNumbers);
 * int param_1 = obj.Get();
 * bool param_2 = obj.Check(number);
 * obj.Release(number);
 */