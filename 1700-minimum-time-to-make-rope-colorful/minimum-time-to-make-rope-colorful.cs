public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int time = 0;
        int index = 0; 
        while(index<colors.Length){
            PriorityQueue<int, int>myQueue = new PriorityQueue<int, int>();
            while(index<colors.Length-1 && colors[index]==colors[index+1]){
                myQueue.Enqueue(index, neededTime[index]);
                index++;
            }
            myQueue.Enqueue(index, neededTime[index]);
            while(myQueue.Count>1){
                time+=neededTime[myQueue.Dequeue()];
            }
            index++;
        }
        return time;
    }
}