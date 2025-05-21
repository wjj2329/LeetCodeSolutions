public class Solution {
    public int TotalMoney(int n) {
         List<int> moneyDays = new List<int>();
         for (int i = 0; i <= 6; i++)
         {
             moneyDays.Add(i);
         }
         int ammount = 0;
         int day = 0;
         while (day < n)
         {
             int dayWeek = day%7;
             if(dayWeek==0){
                  moneyDays.RemoveAt(0);
                  moneyDays.Insert(moneyDays.Count, moneyDays.Last()+1);
             }
             ammount+=moneyDays[dayWeek];
             day++;
         }
         return ammount;
    }
}