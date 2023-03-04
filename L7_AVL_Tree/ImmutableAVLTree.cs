using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_AVL_Tree
{
    class ImmutableAVLTree<T> : IAVLTree<T>
    {
        IAVLTree<T> tree;
        public int Count { get => tree.Count; }

        public bool IsEmpty => tree.IsEmpty;

        public IEnumerable<T> nodes { get => tree; }

        public ImmutableAVLTree(IAVLTree<T> tree)
        {
            this.tree = tree;
        }
        
        public void Add(T node)
        {
            throw new AttemptOfChangingImmutableAVLTree();
        }

        public void Clear()
        {
            throw new AttemptOfChangingImmutableAVLTree();
        }

        public bool Contains(T node)
        {
            return tree.Contains(node);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return tree.GetEnumerator();
        }

        public bool Remove(T node)
        {
            throw new AttemptOfChangingImmutableAVLTree();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ToTreeView(TreeNode treeNode)
        {
            tree.ToTreeView(treeNode);
        }
    }
}
    