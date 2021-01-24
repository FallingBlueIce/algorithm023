/*
 * @lc app=leetcode.cn id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
/*

// 1. 暴力

public class Solution {
    public double MyPow(double x, int n) {
        if (n == 1){
            return x;
        }
        else if (n == 0){
            return 1;
        }
    
        return x *= MyPow(x, n - 1);
    }
}
*/

/*
public class Solution {
    public double MyPow(double x, int n) {
        if(x == 0){
            return 0;
        }
        if (n == 1){
            return x;
        }
        else if (n == -1){
            return 1/x;
        }
        else if (n == 0){
            return 1;
        }
        double res = MyPow(x, n / 2);
        if (n % 2 != 0){
            return res * res * (n > 0 ? x : 1 / x);
        }
        else{
            return res * res; //不能使用 mypow * mypow， 否则时间复杂度会变为指数级
        }
    }
}
*/

public class Solution {
    public double MyPow(double x, int n) {
        if (x == 0)
            return 0;

        long N = n;
        if (N < 0){
            N = -N;
            x = 1/x;
        }
        double res = 1;
        while (N > 0)
        {
            if (N % 2 != 0)
                res *= x;
            x *= x;
            N /= 2;
        }
        return res;
    }
}



// @lc code=end

/*
    坑点：
        1. 指数为负的情况；
        2. x = 0
        3. 将o(logn) 的算法变成 o(2^n)的算法
            即每一层使用 MyPow(n/2)*Mypow(n/2) 的形式向下递归
            正解使用 *值* 相乘而不是 *递归函数* 相乘
    
    方法：
        1. 递归（分支、二分的思想）
            和pow()函数一样 对指数进行二分 每层 pow(n/2)^2 向下递归

        2. 循环 （同递归的思路）
            每一层 res^2 并记录该值(res)
            直到指数被拆分完毕
*/