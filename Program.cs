namespace BinaryTreeTraversal;

public abstract class Program
{
    static void Main()
    {
        // Build the sample tree
        var a = new TreeNode('A');
        var b = new TreeNode('B');
        var c = new TreeNode('C');
        var d = new TreeNode('D');
        var e = new TreeNode('E');

        a.Left = b;
        a.Right = c;
        b.Left = d;
        b.Right = e;

        // Call methods
        var height = BinaryTree.Height(a);
        var leafCount = BinaryTree.CountLeaves(a);

        Console.WriteLine("Height of the tree: " + height);
        Console.WriteLine("Number of leaf nodes: " + leafCount);
    }
} // Mostafa Akbarpour - 40272119