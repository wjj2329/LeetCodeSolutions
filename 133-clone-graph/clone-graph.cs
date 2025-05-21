/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }
        Dictionary<int, Node>myMap = new Dictionary<int, Node>();
        Queue<Node>myQueue = new Queue<Node>();
        myQueue.Enqueue(node);
        myMap.Add(node.val, new Node(node.val));
        HashSet<Node>visited = new HashSet<Node>();
        while(myQueue.Count>0){
            var curr = myQueue.Dequeue();
            foreach(Node t in curr.neighbors){
                if(!myMap.ContainsKey(t.val)){
                    myMap.Add(t.val, new Node(t.val));
                }
                if(!myMap[curr.val].neighbors.Contains(myMap[t.val])){
                    myMap[curr.val].neighbors.Add(myMap[t.val]);
                }
                if(!visited.Contains(t)){
                    myQueue.Enqueue(t);
                }
                visited.Add(t);
            }
        }
        return myMap[node.val];
    }
}