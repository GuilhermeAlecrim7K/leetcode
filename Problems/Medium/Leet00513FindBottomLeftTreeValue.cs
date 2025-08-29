namespace SharpLeetCode.Problems.Medium;

public class Leet00513FindBottomLeftTreeValue
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }

    private int _maxLevel = -1;
    private int _leftmostMaxLevel = 0;
    public int FindBottomLeftValue(TreeNode root)
    {
        DFS(0, root);
        return _leftmostMaxLevel;
    }

    private void DFS(int level, TreeNode? root)
    {
        if (root is null)
            return;

        if (level > _maxLevel)
        {
            _leftmostMaxLevel = root.val;
            _maxLevel = level;
        }

        DFS(level + 1, root.left);
        DFS(level + 1, root.right);
    }
}