public class Solution {
    public void SortColors(int[] nums) {
        int temp = 0;
        for(int i = 0;i<= nums.Length-1;i++)
        {
            for(int j = 0;j<= nums.Length-1;j++)
            {
                if(nums[i]< nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}