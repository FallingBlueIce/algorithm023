/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
/*
public class Solution {
    public int ClimbStairs(int n) {
        int a = 1, b = 1;
        for (int i = 1; i < n; i++){
            int c = b;
            b += a ;
            a = c;
        }
        return b;
    }
}
*/


public class Solution {
    Dictionary<int, int> ht = new Dictionary<int, int>(){
        {0,0},
        {1,1},
        {2,2}
    };
    public int ClimbStairs(int n) {
        if (ht.ContainsKey(n)){
            return ht[n];
        }
        ht.Add(n, ClimbStairs(n - 1) + ClimbStairs(n - 2));
        return ht[n];
    }
}
// @lc code=end


/*

1. 递归  n > 2 时，每一层楼梯都有两种方式到达，即最近重复子问题
    f(n) = f(n-1) + f(n-2)

2. 动态规划
    爬到第n层楼梯的方法 = n-1层方法 + n-2层方法
    动归公式 d[n] = d[n-1] + d[n-2]
