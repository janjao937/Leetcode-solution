public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int j = 0;
        for(int i = m; i < nums1.Length; i++){
 
            nums1[i] = nums2[j++];
        }

        for(int i = 0; i< nums1.Length; i++){
            
            for(int k = 0; k<nums1.Length; k++){

                if(nums1[i]<nums1[k]){
                    int temp = nums1[i];
                    nums1[i] = nums1[k];
                    nums1[k] = temp;
                }
            }
        }
    }
}