/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start


public class Solution {
    List<string> ans = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
        _generate(0, 0, n, "");
        return ans;
    }


    void _generate(int left, int right, int max, string s){
        // terminator
        if (left == max && right == left){
            ans.Add(s);
            return;
        }   

        // process current logic
        //s += "(";
        //s += ")";

        // drill down
        if (left <= max){
            _generate(left + 1, right, max, s + "(" );
        }
        if (right < left){
            _generate(left, right + 1, max, s + ")" );
        }
        // reverse states
    }
}

// @lc code=end

/*

    括号匹配规则：
        1. 一个左括号必须有一个对应的右括号，故左括号数=右括号 left = right = n
        2. 第一个括号不能为右括号，即左括号要出现在右括号之前，left >= right

    递归模板
    1. terminator;
    2. process of current level;
    // 3. recard change of every level in a table. 
    4. drill down;
    5. revert change;

*/