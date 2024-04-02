class Program
{
    //O(N) ST 
    static void Main(string[] args)
    {
        var root = new BinaryTree(1);
        root.left = new BinaryTree(2);
        root.left.left = new BinaryTree(4);
        root.left.left.left = new BinaryTree(8);
        root.left.left.right = new BinaryTree(9);

        root.left.right = new BinaryTree(5);
        root.left.right.left = new BinaryTree(10);

        root.right = new BinaryTree(3);
        root.right.left = new BinaryTree(6);
        root.right.right = new BinaryTree(7);

        var res = new List<int>();
        Solve(root, 0, res);
        Console.WriteLine(string.Join("\t", res));
    }

    public static List<int> BranchSums(BinaryTree root)
    {
        var res = new List<int>();
        Solve(root, 0, res);
        return res;
    }

    public static void Solve(BinaryTree tree, int s, List<int> result)
    {
        if (tree == null)
            return;

        s = s + tree.value;


        if (tree.left == null && tree.right == null)
        {
            result.Add(s);
            return;
        }

        if (tree.left != null)
            Solve(tree.left, s, result);

        Solve(tree.right, s, result);
    }
}

public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}

