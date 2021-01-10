/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

/*
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++){
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] + nums[j] == target){
                    int[] res = {i, j};
                    return res;
                }
            }
        }
    }
}
*/


// Hash Table Reflection

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> table = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            if (table.ContainsKey(target - nums[i])){
                return new int[2]{table[target - nums[i]], i};
            }
            table.Add(nums[i], i);
        }
        return null;
    }
}




/*
  
  PRECODING：

1. 暴力， 两组for循环遍历数组，返回满足条件的两个数---------------------------268ms
2. for 循环遍历数组，target 减去 数组中的每一个数， 再次遍历数组寻找相减的结果
    (和第一种方法一样?)--------------------------------------------------296ms
    将每一个小循环中的计算提出来 反倒时间多了？

    以上 时间复杂度o(n^2)


3. ***哈希表***   (Dictionary in CSharp) 
    -- 时间复杂度o(n)    
    · 数组元素作为key， 数组索引值作为value
    · 每次寻找键值 target - nums[i], 空则存入<num[i], i>
    · 不为空则返回 [ value of （target - nums[i]）， i]

*/


// @lc code=end


