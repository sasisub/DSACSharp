using System;
namespace BTree
{
	public class Challege
	{
		public Challege()
		{
		}

		public int MaxDepth(TreeNode node)
		{

			if (node == null)
				return 0;

			int leftMaxDepth = MaxDepth(node.Left);
            int rightMaxDepth = MaxDepth(node.Right);

			return 1 + (Math.Max(leftMaxDepth, rightMaxDepth));

        }
    }
}

