public class FileSystem {
    Node root;
    public FileSystem() {
        root = new Node();
    }
    public class Node{
        public Dictionary<string, Node> Children = new Dictionary<string, Node>();
        public int Value;

    }
    public bool CreatePath(string path, int value) {
        string[] parts = path.Split('/');
        Node curr = root;
        Console.WriteLine(parts.Count());
        for(int i =1; i<parts.Count()-1; i++){
            if(curr.Children.ContainsKey(parts[i])){
                curr = curr.Children[parts[i]];
            }else{
                return false;
            }
        }
        if(curr.Children.ContainsKey(parts[parts.Count()-1])){
            return false;
        }
        curr.Children.Add(parts[parts.Count()-1], new Node());
        curr.Children[parts[parts.Count()-1]].Value = value;
        return true;
    }
    
    public int Get(string path) {
        string[] parts = path.Split('/');
        Node curr = root;
        for(int i =1; i<parts.Count()-1; i++){
            if(curr.Children.ContainsKey(parts[i])){
                curr = curr.Children[parts[i]];
            }else{
                return -1;
            }
        }
        return curr.Children.ContainsKey(parts[parts.Count()-1])?curr.Children[parts[parts.Count()-1]].Value:-1;
    }
}

/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * bool param_1 = obj.CreatePath(path,value);
 * int param_2 = obj.Get(path);
 */