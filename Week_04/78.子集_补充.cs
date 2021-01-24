/*
 * @lc app=leetcode.cn id=78 lang=csharp
 *
 * [78] 子集
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> ans = new List<IList<int>>();
        if (nums.Length == 0){
            return ans;
        }
        recursion(ans, new List<int>(), nums, 0);
        return ans;
    }

    void recursion (List<IList<int>> ans, List<int> res, int[] nums, int level){
        if (level == nums.Length){
            ans.Add(new List<int>(res));
            return;
        }
        recursion(ans, res, nums, level+1);
        res.Add(nums[level]);
        recursion(ans, res, nums, level+1);
        res.RemoveAt(res.Count-1);
        //Console.Write(res.Count);
    }
}

/*
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> ans = new List<IList<int>>();
        ans.Add(new List<int>());
        for (int i = 0; i < nums.Length; i++){
            for (int j = 0; j < ans.Count; j++){
                List<int>clone = new List<int>(ans[j]);
                ans.Add(clone);
            }
        }
        return ans;
    }
}

*/

/*
    迭代：Timeout;

    递归：每层两个分支（子树）：包含nums[i] 和 不包含nums[i]
            Reference needs revert changes in every level.

*/




// @lc code=end


