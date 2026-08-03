public class Solution {
    public int UniquePaths(int m, int n) {
        //[row,colum]
        int[,] robot = new int[m,n];

        for(int i = 0;i<m;i++){
            for(int j=0;j<n;j++){
                if(i==0||j==0){
                    robot[i,j] = 1;
                }
                else{
                    robot[i,j] = robot[i-1,j]+robot[i,j-1];
                }
                
            }
        }
            return robot[m-1,n-1];
    }
}