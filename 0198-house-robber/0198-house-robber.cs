
public class Solution {
    private int GetMax(int a,int b){
        return a>b?a:b;
    }
    public int Rob(int[] nums) {

        int previous = nums[0];
        if(nums.Length==1) return previous;
        int output =GetMax(nums[0],nums[1]);
        for(int i = 2;i<nums.Length;i++){
            int temp = GetMax(previous+nums[i],output);
            previous = output;
            output =temp;
        }
        return output;
    }
}