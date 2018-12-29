using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace LevelWidth
{
    /// <summary>
    /// Class to find the width of each level of a tree.
    /// </summary>
    public class LevelWidthFinder
    {
        /// <summary>
        /// Finds the width of each level of the specified tree.
        /// </summary>
        /// <param name="tree">Tree to find width of levels.</param>
        /// <returns>Width of levels in the tree.</returns>
        public int[] Find(Tree tree)
        {
            if (tree == null)
            {
                throw new ArgumentNullException(nameof(tree), "tree cannot be null");
            }

            if (tree.Root == null)
            {
                return new int[] { 0 };
            }

            List<int> results = new List<int>();
            List<Tree.Node> toVisit = new List<Tree.Node>();
            toVisit.Add(tree.Root);

            while (toVisit.Count > 0)
            {
                int levelCount = toVisit.Count;

                for (int i = 0; i < levelCount; i++)
                {
                    Tree.Node node = toVisit[0];
                    toVisit.RemoveAt(0);
                    toVisit.AddRange(node.Children);
                }

                results.Add(levelCount);
            }

            return results.ToArray();
        }
    }
}
