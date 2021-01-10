/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
/*
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        for (int i = 0; i < s.Length; i++){
            if (t.IndexOf(s[i]) >= 0){
                t = t.Remove(t.IndexOf(s[i]), 1);
            }
        }
        if (t.Length <= 0)
            return true;
        else return false;
    }
}
*/




public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] characters = new int[26];
        if (s.Length != t.Length)
            return false;
        for (int i = 0; i < s.Length; i++){
            characters[s[i] - 'a'] ++;
            characters[t[i] - 'a'] --;
        }
        for (int i = 0; i < 26; i++){
            if (characters[i] != 0){
                return false;
            }
        }
        return true;
    }
}


// @lc code=end

/* 

  PRECODING：

 1. 相同字母替换为“”，遍历完字符串为空则true，不为空则false
    （There might be a trouble with Timeout）

 2. 哈希表，s中出现的字符对应哈希值+1， t中对应哈希值 -1， 最后遍历哈希表是否值全为0
     search -> o(1)

 */