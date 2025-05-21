/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    int index = 0;
    List<int>myList = new List<int>();
    public NestedIterator(IList<NestedInteger> nestedList) {
        Stack<NestedInteger>myStack = new Stack<NestedInteger>(); 
        for(int i = nestedList.Count-1; i>-1; i--){
            myStack.Push(nestedList[i]);
        }
        while(myStack.Count>0){
            Console.WriteLine(myStack.Count);
            NestedInteger curr = myStack.Pop();
            if(curr.IsInteger()){
                myList.Add(curr.GetInteger());
            }else{
                for(int i = curr.GetList().Count-1; i>-1; i--){
                    myStack.Push(curr.GetList()[i]);
                }
            }
        }
    }

    public bool HasNext() {
        return index<myList.Count;
    }

    public int Next() {
        var r =  myList[index];
        index++;
        return r;
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */