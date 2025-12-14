namespace BinaryTreeTraversal;

public class BinaryTree
{
    // Returns the height of the tree based on number of edges
    public static int Height(TreeNode? root)
    {
        if (root == null)
            return -1;

        return 1 + Math.Max(
            Height(root.Left),
            Height(root.Right)
        );
    }

    // Returns the number of leaf nodes in the tree
    public static int CountLeaves(TreeNode? root)
    {
        if (root == null)
            return 0;

        if (root.Left == null && root.Right == null)
            return 1;

        return CountLeaves(root.Left) + CountLeaves(root.Right);
    }
}