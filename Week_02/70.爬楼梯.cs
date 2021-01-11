/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */
using Math;
// @lc code=start

/*
public class Solution {
    //public int[] tmp = new int[10000];
    // 
    // tmp[0] = 0;
    // tmp[1] = 1;
    // tmp[2] = 2;
    // 
    public int ClimbStairs(int n) {
        double sqrt5 = Math.sqrt(5);
        double fibn = Math.pow((1 + sqrt5) / 2, n + 1) - Math.pow((1 - sqrt5) / 2, n + 1);
        return (int)(fibn / sqrt5);
    }
}
*/

/*
public class Solution {
    public int[] tmp = new int[10000];
    
    // tmp[0] = 0;
    // tmp[1] = 1;
    // tmp[2] = 2;
    
    public int ClimbStairs(int n) {
        
    tmp[0] = 0;
    tmp[1] = 1;
    tmp[2] = 2;
        if (tmp[n] == 0){
            tmp[n] = ClimbStairs(n-1)+ClimbStairs(n-2);
            return tmp[n];
        }
        else return tmp[n];
    }
}
*/


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






// @lc code=end

/*
    典型：斐波那契数列

    1. 暴力递归，代码极简，但优化空间较大， 容易超时；
    2. 缓存， 在暴力递归的基础上增加缓存机制，把出现过的数存入数组，每次先查找数组；
    3. 数学归纳法，从第四个数开始，每个数等于前两个数的和，可以通过循环来累加这个数，直到累加到n
        时间复杂度 o(n)

    4. 动规？？？  后面再说把


