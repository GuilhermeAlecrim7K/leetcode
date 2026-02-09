#nullable disable

namespace SharpLeetCode.Problems.Medium;

public class Leet00098ValidateBinarySearchTree
{
    public class TreeNode(int val=0, TreeNode left = null, TreeNode right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }

    public bool IsValidBST(TreeNode root)
    {
        var queue = new Queue<int>();
        TraverseTreeInOrder(root, queue);
        int prev = queue.Dequeue();
        while(queue.TryDequeue(out int cur))
        {
            if (cur <= prev)
                return false;
            prev = cur;
        }
        return true;
    }

    private void TraverseTreeInOrder(TreeNode node, Queue<int> queue)
    {
        if (node is null)
            return;
        TraverseTreeInOrder(node.left, queue);
        queue.Enqueue(node.val);
        TraverseTreeInOrder(node.right, queue);
    }
}