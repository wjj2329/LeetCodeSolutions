public class SnakeGame {
    int width;
    int height;
    int x=0; 
    int y =0; 
    int foodIndex=0;
    int[][]food;
    List<int[]>snakeBody = new List<int[]>();
    public SnakeGame(int width, int height, int[][] food) {        
        this.food = food;
        this.width = width;
        this.height = height;
    }
    
    public int Move(string direction) {
        if(direction =="R"){
            y++;
        }
        if(direction =="L"){
            y--;
        }
        if(direction =="U"){
            x--;
        }
        if(direction =="D"){
            x++;
        }
        if(x<0 ||x>=height||y<0||y>=width){
            return -1;
        }
         //add snake head
            int []head = new int[2];
            head[0]=x;
            head[1]=y;
        foreach(int []pair in snakeBody){
            if(pair[0]==x && pair[1]==y){
                return -1;
            }
        }
        snakeBody.Add(head);
        if(foodIndex<food.Length&&food[foodIndex][0]==x&& food[foodIndex][1]==y){
                foodIndex++;
        }else{
            snakeBody.RemoveAt(0);
        }
        return foodIndex;
        
    }
}

/**
 * Your SnakeGame object will be instantiated and called as such:
 * SnakeGame obj = new SnakeGame(width, height, food);
 * int param_1 = obj.Move(direction);
 */