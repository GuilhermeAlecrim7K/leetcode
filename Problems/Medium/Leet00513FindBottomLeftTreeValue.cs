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
        level.Enqueue(root);
        var result = root.val;
        do
        {
            var valueSet = false;
            TreeNode? leftMostCurLevel = null;
            while (level.TryPeek(out var node) && !ReferenceEquals(node, leftMostCurLevel))
            {
                if (!valueSet)
                {
                    result = node.val;
                    valueSet = true;
                }
                if (node.left is not null)
                {
                    level.Enqueue(node.left);
                    leftMostCurLevel ??= node.left;
                }
                if (node.right is not null)
                {
                    level.Enqueue(node.right);
                    leftMostCurLevel ??= node.right;
                }
                level.Dequeue();
            }
        } while (level.Count > 0);
        return result;
    }
}