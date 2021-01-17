/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    
    private List<int> res = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null){
            return;
        }
        res.Add(root.val);
        PreorderTraversal(root.left);
        PreorderTraversal(root.right);
        return res;
    }
}
// @lc code=end

/* 
1. 很简单的基本操作，前中后不一样的地方在于27-29这三行位置的不同
    
    左中右 ----中序
        PreorderTraversal(root.left);
        res.Add(root.val);
        PreorderTraversal(root.right);
        
    左右中 ----后序
        PreorderTraversal(root.left);
        PreorderTraversal(root.right);
        res.Add(root.val);

    中左右 ----前序  
        res.Add(root.val);
        PreorderTraversal(root.left);
        PreorderTraversal(root.right);


2. 时空复杂度，击败5%，显然代码有很大的提升空间

