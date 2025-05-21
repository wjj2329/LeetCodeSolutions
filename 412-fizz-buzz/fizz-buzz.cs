public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string>myArr = new List<string>(n);
        for(int i = 1; i<n+1; i++){
            int mod3 = i%3;
            int mod5 = i%5;
            if(mod3!=0 && mod5!=0){
                myArr.Add(i.ToString());
            }else if(mod3 == 0 && mod5!=0){
                myArr.Add("Fizz");
            }else if(mod5 == 0&& mod3!=0){
                myArr.Add("Buzz");
            }else{
                myArr.Add("FizzBuzz");
            }
        }
        return myArr;
    }
}