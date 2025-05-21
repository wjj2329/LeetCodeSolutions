public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string>myArr = new List<string>(n);
        for(int i = 1; i<n+1; i++){
            if(i%3!=0 && i%5!=0){
                myArr.Add(i.ToString());
            }else if(i%3 == 0 && i%5!=0){
                myArr.Add("Fizz");
            }else if(i%5 == 0&& i%3!=0){
                myArr.Add("Buzz");
            }else{
                myArr.Add("FizzBuzz");
            }
        }
        return myArr;
    }
}