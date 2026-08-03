public class Solution {


       public int MyAtoi(string s) {
        int index = 0;
        int sign = 1;
        int a = 0;

        while (index < s.Length && s[index] == ' ')
            index++;

        if (index < s.Length && (s[index] == '+' || s[index] == '-')) {
            sign = s[index] == '+' ? 1 : -1;
            index++;
        }

        while (index < s.Length && char.IsDigit(s[index])) {
            int digit = s[index] - '0';

            if (a > int.MaxValue / 10 || (a == int.MaxValue / 10 && digit > int.MaxValue % 10)) {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            a  *= 10 ;
            a+= digit;
            index++;
        }

        return a * sign;
    }
    
}