/*
 * @lc app=leetcode.cn id=33 lang=csharp
 *
 * [33] 搜索旋转排序数组
 */

// @lc code=start

// 递归

public class Solution {
    public int Search(int[] nums, int target) {
        return binSearch(nums, 0, nums.Length - 1, target);
    }
    int binSearch(int[] nums, int left, int right, int target){
        //terminator
        if (nums.Length == 0){
            return -1;
        }
        if (left == right){
            if (nums[left] == target)
                return left;
            else return -1;
        }
        
        int mid = (right + left) / 2;   
        if (nums[mid] == target)
            return mid;
        if (mid == 0)
            return nums[right] == target ? right : -1;
        if (mid == nums.Length)
            return nums[left] == target ? left : -1;
        Console.Write("left = "+left+"\nright = "+right+"\nmid = "+mid+"\n");

        // current process logic
        if (nums[right] > nums[mid + 1]){
            if (nums[right] >= target && target >= nums[mid + 1]){
                return binSearch(nums, mid + 1, right, target);
            }
            else{
                return binSearch(nums, left, mid - 1, target);
            }
        }
        else {
            if (target >= nums[left] && nums[mid - 1] >= target){
                return binSearch(nums, left, mid - 1, target);
            }
            else return binSearch(nums, mid + 1, right, target);
        }

    }
}


// 循环
public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        if (n == 0) {
            return -1;
        }
        if (n == 1) {
            return nums[0] == target ? 0 : -1;
        }
        int left = 0, right = n - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            if (nums[mid] == target) {
                return mid;
            }
            if (nums[0] <= nums[mid]) {
                if (nums[0] <= target && target < nums[mid]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            } else {
                if (nums[mid] < target && target <= nums[n - 1]) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}
// @lc code=end

/*
    二分，
    1. 递归（遇到很多特殊情况的坑，最后填完了又超时，代码还需优化）
        （二分查找的模板有点问题
    2. 循环 (套模板，没什么问题)