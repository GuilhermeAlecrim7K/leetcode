namespace SharpLeetCode.Problems;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Leet00700SearchInABinarySearchTree
{

    public TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root is null)
            return null;
        if (root.val == val)
            return root;
        return SearchBST(root.val > val ? root.left : root.right, val);
    }
}