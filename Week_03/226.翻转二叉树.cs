/*
 * @lc app=leetcode.cn id=226 lang=csharp
 *
 * [226] 翻转二叉树
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
    public TreeNode InvertTree(TreeNode root) {
        // terminator
        if (root == null){
            return null;
        }

        // current logic
        TreeNode tmp_node;
        tmp_node = root.left;
        root.left =  root.right;
        root.right = tmp_node;

        // drill down
        InvertTree(root.left);
        InvertTree(root.right);

        // return/discard changes
        return root;

        // revert changes
    }
}
// @lc code=end

/* 
    1. 递归， 
        每一层 交换当前节点的左右子节点
        返回交换后的root
        root空则返回null
    
    2. ///
*/
