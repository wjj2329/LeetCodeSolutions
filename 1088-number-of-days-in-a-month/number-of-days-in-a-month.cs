public class Solution {
    public int NumberOfDays(int year, int month) {
        switch(month){
            case 9:
            case 4:
            case 11:
            case 6:
                return 30;
            case 2:
                    if(year%100 == 0 && year%400 != 0){
                        return 28;
                    }
                    return year%4==0?29:28;
            default:
                return 31;
        }
    }
}