# Learning notes
----
### 树常见解法为什么递归？
> 树中的每一个节点都有相类似的结构（自身+子节点 or null），既然我们要对树的结点进行遍历，无非就是重复遍历一个相同的数据结构，而解决重复性问题的方式，无外乎循环和递归，那么对于树这种结构，显然已经突破一维，此时若使用循环，则需循环嵌套（需要写大量代码），而在这两种方式所用时间复杂度相同（k^n）的情况下，递归以极少的代码量完胜循环，故递归更适合高维数据结构。

*last edit at 1.9*

  ```C++

  // loop
  for (int i = 0; i < k; i++){
    for (int j = 0; j< k; j++){
      for (int m = 0; m< k; m++){
        ...
      }
    }
  }
  
  // recursion
  func (n){
    func (n0)
    func (n1)
    ..
    func (n(k-1))
  }
  
  ```
*last edit at 1.10*

----

## Week Two

  The sun is rising, time to embrace life.

  也许是在舒适区待的太久，仿佛也没有了坚持下去的动力。
  
  这几天的思考，也算是略有收获，我想在我写下这些文字的时候，自己已经做出了选择。
  
  舒适区的体验券应该也要到期了，在我看来，舒适有很多中实现方式，有所为，有所不为。可以选择23岁“死亡”，这样或许可以更加无忧无虑地体验舒适；但另一种方式，也许更值得一试。
  
  我常常在想，一个人成天到晚拼搏到无能为力，这样的生活日复一日，年复一年，难道他们都不想舒适的生活吗？生物归根结底尽是趋利避害，他们真的就像我看到的这样违背了生物本性了吗？
 
  另一种方式，享受挫折，渴望挑战，不断提升高度，每天的挑战越难以想象，那么这一天就会越充实。 这也许就是他们的答案。
  
  ----
  
  一个不能听不能看的人，或许反而能做到正常人做不到的事情。
  
  为什么人进入沙漠会迷路？ 如果剥夺他的大部分能力，让他仅仅具备走直线的能力，是不是比正常人更不容易迷路？
  
  如果是这样，那么在我的成长道路上，我也可以两耳不闻窗外事，一心只读圣贤书。
  
  事与愿违，我离想象中的自己，还差定力。
  
  其实，甚至连我上面的这些思考，也对我“走直线”产生了干扰。
  
  既然这样，那我果断放弃继续思考下去，用这同样的时间，换取更有价值的事情。
  
  嗯，好像没有总结学习算法相关的收获，不过至少方向明确了，接下来就是断舍离了。
  
  ----
  
  *last edit at 1.11 mid*
 
  
*typing...end*
