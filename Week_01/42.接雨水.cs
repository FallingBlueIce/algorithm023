/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 */

// @lc code=start
public class Solution {
    public int Trap(int[] height) {
        int res = 0, left = 0, right = 0;
        for (int i = 0, j = height.Length - 1; i<j; )
        {
            if (height[i] < height[j])            
            {
                if (height[i] >= left)
                {
                    left = height[i];
                }
                else
                {
                    res += (left - height[i]);
                }
                i++;
            }
            else
            {
                if (height[j] >= right)
                {
                    right = height[j];
                }
                else
                {
                    res += (right - height[j]);
                }
                j--;
            }
        }
        return res;
    }
}



/*
分析：
1. 类似于括号匹配； 不同于括号匹配的是，“右括号”可以大于“左括号”或“左括号”可以大于“右括号”
2. 类似于装满水问题， 从两边向中间移动时， 水的高度应该是逐渐增多的， 否则水的高度不变。
    所以要双指针向内部遍历，下一个数更小的一边继续遍历，直到数更大时换另一边向内遍历
*/
// @lc code=end

