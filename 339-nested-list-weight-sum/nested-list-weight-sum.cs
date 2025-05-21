/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList) {
        Queue<NestedInteger>myQueue = new Queue<NestedInteger>();
        foreach(NestedInteger n in nestedList){
            myQueue.Enqueue(n);
        }
        int depth = 1;
        int sum  = 0;
        while(myQueue.Count>0){
            int levelCount = myQueue.Count;
            for(int i = 0; i<levelCount; i++){
                NestedInteger curr = myQueue.Dequeue();
                if(curr.IsInteger()){
                    sum+=(curr.GetInteger()*depth);
                }else{
                    foreach(NestedInteger n in curr.GetList()){
                        myQueue.Enqueue(n);
                    }
                }
            }
            depth++;
        }
        return sum;
    }
}