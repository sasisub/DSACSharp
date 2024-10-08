using BTree;

namespace DSARunner;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BTree.TreeNode root = new TreeNode(3);

        var left = new TreeNode(9);
        var right = new TreeNode(20);

        root.Left = left;
        root.Right = right;

        var left2 = new TreeNode(15);
        var right2 = new TreeNode(7);

        right.Left = left2;
        right.Right = right2;

        Challege treeChallenge = new Challege();

        int maxDepth = treeChallenge.MaxDepth(root);
    }
}

