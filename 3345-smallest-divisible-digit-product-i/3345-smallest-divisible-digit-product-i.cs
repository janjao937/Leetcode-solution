public class Solution {
    public int SmallestNumber(int n, int t) {
        int x = n;
        while (true) {
            int product = 1;
            int temp = x;

            while (temp > 0) {
                product *= temp % 10;
                temp /= 10;
            }

            if (product % t == 0) {
                return x;
            }

            x++;
        }
    }
}