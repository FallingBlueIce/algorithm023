/*
 * @lc app=leetcode.cn id=153 lang=csharp
 *
 * [153] 寻找旋转排序数组中的最小值
 */

// @lc code=start
    public class Solution {
        public int FindMin(int[] nums) {
            int min = 5000;
            int left = 0;
            int right = nums.Length;
            while (left <= right)
            {  
                if (left == right)
                    return nums[left];           
                int mid = (left + right) / 2;
                min = nums[mid] < min ? nums[mid] : min;
                if (nums[left] < nums[mid] && nums[mid] < nums[right]){
                    return nums[left];
                }
                if (left == mid || right ==mid)
                    return nums[left] <= nums[right] ? nums[left] : nums[right];
                if (nums[left] < nums[mid]){
                    left = mid;
                    continue;
                }
                else{
                    right = mid;
                    continue;
                }
                
            }
            return min;
        }
    }
// @lc code=end

/*
// 二分
    mid 左右两边的有序数组数 >= 1
    左值、中值、右值有序时，左值为最小值
    其他情况 左值有序则最小值在右边数组，反之亦然
    特殊情况 数组长度<2 

    代码有待优化，时空复杂度都处于很低水平
    