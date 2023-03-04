using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_AVL_Tree
{
    class NodeLinked<T>: IEnumerable<T>
    {
        public T value;

        public NodeLinked<T> left;
        
        public NodeLinked<T> right;
        
        public int height;

        public NodeLinked(T value, int height)
        {
            this.value = value;
            this.height = height;
        }
        
        private TreeNode nodeView;
        
        public void ToTreeView(TreeNode treeNode)
        {
            nodeView = new TreeNode();
            nodeView.Text = value.ToString();
            treeNode.Nodes.Add(nodeView);
            if(left is not null)
            {
                left.ToTreeView(nodeView);
            }
            if(right is not null)
            {
                right.ToTreeView(nodeView);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
                if (left != null)
                {
                    foreach (T v in left)
                    {
                        yield return v;
                    }
                }

                yield return value;

                if (right != null)
                {
                    foreach (T v in right)
                    {
                        yield return v;
                    }
                }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
