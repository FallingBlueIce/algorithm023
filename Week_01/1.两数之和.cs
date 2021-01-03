/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start

// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         for (int i = 0; i < nums.Length; i++){
//             for (int j = 0; j < nums.Length; j++){
//                 if (i == j){
//                     continue;
//                 }else if (nums[i] + nums[j] == target){
//                     int[] res = {i, j};
//                     return res;
//                 }
//             }
//         }
//         return null;
//     }
// }



public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++){
            int sec = target - nums[i];
            for (int j = 0; j < nums.Length; j++){
                if (i == j){
                    continue;
                 }else if (sec == nums[j]){
                    int[] res = {i, j};
                    return res;
                }
            }
        }
        return null;
    }
}


/*
1. 暴力， 两组for循环遍历数组，返回满足条件的两个数---------------------------268ms
2. for 循环遍历数组，target 减去 数组中的每一个数， 再次遍历数组寻找相减的结果
    (和第一种方法一样?)--------------------------------------------------296ms
    将每一个小循环中的计算提出来 反倒时间多了？
3. 

*/


// @lc code=end


