/*
 * @lc app=leetcode.cn id=102 lang=csharp
 *
 * [102] 二叉树的层序遍历
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



 // 1. queue

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        //template：
        // queue
        List<IList<int>> ans = new List<IList<int>>();
        if (root == null){
            return ans;
        }

        Queue<TreeNode> nodes = new Queue<TreeNode>();
        // start with root
        nodes.Enqueue(root);

        while (nodes.Count != 0){
            List<int> res = new List<int>();
            int length = nodes.Count;

            // every level do:
            for (int i = 0; i < length; i++){
                TreeNode node = nodes.Dequeue();
                res.Add(node.val);

                // while the current node has no child, the queue will be empty. 
                // Then all over.

                if (node.left != null){
                    nodes.Enqueue(node.left);
                }
                if (node.right != null){
                    nodes.Enqueue(node.right);
                }
            }
            //

            // puts result of every level to 'answer'.
            ans.Add(res);
        }
        // return all results.
        return ans;
    }
}


/*
// 2. recursion

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> ans = new List<IList<int>>();
        if (root == null){
            return ans;
        }
        List<int> res = new List<int>();
        res.Add(root.val);
        ans.Add(res);
        recursion(ans, root, 1);
        return ans;
    }
    void recursion(List<IList<int>> ans, TreeNode root, int level){
        // terminator
        if (root.left == null && root.right == null){
            return;
        }

        // current process logic
        if (ans.Count <= level){
            List<int> res = new List<int>();
            ans.Add(res);
        }
        if (root.left != null){
            ans[level].Add(root.left.val);
            recursion(ans, root.left, level + 1);
        }
        if (root.right != null){
            ans[level].Add(root.right.val);
            recursion(ans, root.right, level + 1);
        }
        return;

        // drill down
        // recursion(left & right)

        // revert changes
    }
}
*/
// @lc code=end

/*
    层序遍历： 按深度值遍历
        从左往右访问节点
        可使用BFS
        1、 使用queue
        2、 使用递归(o(2^n))


