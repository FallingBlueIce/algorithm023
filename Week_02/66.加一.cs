/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length - 1; i >= 0; i --){
            digits[i] += 1;
            if (digits[i] <10)
                return digits;
            if (digits[i] == 10){
                digits[i] = 0;
                if (i > 0)
                    continue;
            }
        }
        int[] overflow = new int[digits.Length+1];
        overflow[0] = 1;
        return overflow;
    }
}
// @lc code=end

/* 参考了一种很好的思维————逆向思考
    ·只有最极端的情况下（9999...9)，才会产生溢出
    ·其他情况正常加就可以了，可以暂存后一位的进位（bool）
