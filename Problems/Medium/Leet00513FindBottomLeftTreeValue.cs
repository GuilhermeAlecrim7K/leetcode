namespace SharpLeetCode.Problems.Medium;

public class Leet00513FindBottomLeftTreeValue
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }

    public int FindBottomLeftValue(TreeNode root)
    {
        var level = new Queue<TreeNode>();
        var nextLevel = new Queue<TreeNode>();
        nextLevel.Enqueue(root);
        var result = root.val;
        do
        {
            level.Clear();
            while (nextLevel.TryDequeue(out var node))
                level.Enqueue(node);
            var valueSet = false;
            while (level.TryDequeue(out var node))
            {
                if (!valueSet)
                {
                    result = node.val;
                    valueSet = true;
                }
                if (node.left is not null)
                    nextLevel.Enqueue(node.left);
                if (node.right is not null)
                    nextLevel.Enqueue(node.right);
            }
        } while (nextLevel.Count > 0);
        return result;
    }
}