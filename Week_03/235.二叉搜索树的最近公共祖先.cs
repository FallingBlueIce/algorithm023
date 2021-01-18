/*
 * @lc app=leetcode.cn id=235 lang=csharp
 *
 * [235] 二叉搜索树的最近公共祖先
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        while ((root.val - p.val) * (root.val - q.val) > 0)
            root = p.val < root.val ? root.left : root.right;
        return root;
    }
}
// @lc code=end



/*
    1. 递归：
        递归向下查找字节点 p q
        找到后返回节点，找不到返回null
        当前层的左右子树都返回节点时，返回结果

    2. 二叉搜索树中序遍历有序性
        left < root < right
        按照这个逻辑找到第一个符合条件的节点即可

*/

