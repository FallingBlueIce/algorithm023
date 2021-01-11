/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null || l2 == null){
            return l1 == null ? (l2 == null ? null : l2) : l1;
        }
        if (l1.val <= l2.val){
            l1.next = MergeTwoLists(l1.next, l2);
            return l1;
        }
        else{
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }
}
// @lc code=end

/*

1. 暴力求解
    由于是链式结构，所以重复性问题在这里可以使用递归代替循环，
    有点像贪心算法，每次都求解当前最优解，然后递归函数 MergeTwoLists 中
    要排序的链表就会越来越少，直到完成排序。
2. 方法待研究。。。