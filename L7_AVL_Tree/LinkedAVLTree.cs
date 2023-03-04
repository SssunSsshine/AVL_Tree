using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_AVL_Tree
{
    class LinkedAVLTree<T>: IAVLTree<T>
    {
        public NodeLinked<T> root;
        
        int count;
        
        public delegate int CompareDelegate(T v1, T v2);

        public readonly CompareDelegate compare = Comparer<T>.Default.Compare;
        
        public LinkedAVLTree()
        {
            root = null;
            count = 0;
        }

        public LinkedAVLTree(CompareDelegate compare)
        {
            this.compare = compare;
        }

        public int Count 
        { 
            get 
            { 
                return count; 
            } 
        }

        public bool IsEmpty
        {
            get 
            { 
                return root is null; 
            }
        }
        static int Height(NodeLinked<T> n) => (n == null) ? 0 : n.height;
        static int CalcHeight(NodeLinked<T> n)
        {
            if (n is null)
            {
                return 0;
            }
            else
            {
                int hl = CalcHeight(n.left) + 1;
                int hr = CalcHeight(n.right) + 1;
                return Math.Max(hl, hr);
            }
        }
        void UpdateHeightsAfterRotation(NodeLinked<T> n)
        {
            if (n == null) return;
            if (n.left != null)
                n.left.height = 1 + Math.Max(Height(n.left.left),
                                             Height(n.left.right));
            if (n.right != null)
                n.right.height = 1 + Math.Max(Height(n.right.left),
                                              Height(n.right.right));
            n.height = 1 + Math.Max(Height(n.left),
                                    Height(n.right));

        }
        static int BalanceFactor(NodeLinked<T> n) => (n == null) ? 0 : (CalcHeight(n.left) - CalcHeight(n.right));
        NodeLinked<T> RotateRight(NodeLinked<T> n)
        {
            NodeLinked<T> newSubRoot = n.left;
            n.left = n.left.right;
            newSubRoot.right = n;
            UpdateHeightsAfterRotation(newSubRoot);
            return newSubRoot;
        }

        NodeLinked<T> RotateLeft(NodeLinked<T> n)
        {
            NodeLinked<T> newSubRoot = n.right;
            n.right = n.right.left;
            newSubRoot.left = n;
            UpdateHeightsAfterRotation(newSubRoot);
            return newSubRoot;
        }

        void Rebalance(ref NodeLinked<T> root)
        {
            int bF = BalanceFactor(root);
            if (bF > 1)
            {
                if(BalanceFactor(root.left) >= 0)
                {
                    root = RotateRight(root);
                }
                else
                {
                    root.left = RotateLeft(root.left);
                    root = RotateRight(root);
                }
            }
            else if (bF < -1)
            {
                if (BalanceFactor(root.right) <= 0)
                {
                    root = RotateLeft(root);
                }
                else
                {
                    root.right = RotateRight(root.right);
                    root = RotateLeft(root);
                }
            }
        }
        bool AddTo(ref NodeLinked<T> root, T value)
        {
            bool result = true;
            if (root == null)
            {
                root = new NodeLinked<T>(value, 1);
                count++;
                return true;
            }
            else if (compare(value, root.value) < 0)
                result = AddTo(ref root.left, value);
            else if (compare(value, root.value) > 0)
                result = AddTo(ref root.right, value);
            else
                return false;
            root.height = 1 + Math.Max(Height(root.left),
                                  Height(root.right));
            Rebalance(ref root);
            return result;
        }

        public void Add(T theVal) => AddTo(ref root, theVal);

        T PreviousOrderedNode(ref NodeLinked<T> root)
        {
            if (root == null) throw new System.NullReferenceException();
            if (root.right == null)
            {
                T min = root.value;
                root = root.left;
                return min;
            }
            else
                return PreviousOrderedNode(ref root.right);
        }

        bool RemoveFrom(ref NodeLinked<T> root, T value)
        {
            if (root == null) return false;
            bool result = false;
            if (compare(value, root.value) < 0)
                result = RemoveFrom(ref root.left, value); 
            else if (compare(value, root.value) > 0)
                result = RemoveFrom(ref root.right, value);
            else if (compare(value, root.value) == 0)
            {
                if (root.left != null && root.right != null)
                {
                    root.value = PreviousOrderedNode(ref root.left); 
                }
                else root = root.left ?? root.right;
                result = true;
                count--;
            }
            if (root == null) return true;
            root.height = CalcHeight(root);
            Rebalance(ref root);
            return result;
        }

        public bool Remove(T val) => RemoveFrom(ref root, val);

        public void Clear()
        {
            root = null;
            count = 0;
        }

        public bool Contains(T value)
        {
            bool isContains = false;
            int i = 0;
            NodeLinked<T> node = root;
            while (!isContains && i < count && node is not null)
            {
                if (compare(node.value, value) == 0)
                {
                    isContains = true;
                }
                else if (compare(node.value, value) == -1)
                {
                    node = node.right;
                }
                else if (compare(node.value, value) == 1)
                {
                    node = node.left;
                }
            }
            return isContains;
        }

        public IEnumerable<T> nodes
        {
            get
            {
                Queue<NodeLinked<T>> queue = new Queue<NodeLinked<T>>();
                NodeLinked<T> top = root;
                T[] arr = new T[Count*2];
                int i = 0;
                arr[i++] = top.value;
                do
                {
                    if (top.left != null) queue.Enqueue(top.left);
                    if (top.right != null) queue.Enqueue(top.right);
                    if (queue.Count != 0) top = queue.Dequeue();
                    arr[i++] = top.value;
                } while (queue.Count != 0);

                return arr;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return root.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }

        public void ToTreeView(TreeNode treeNode)
        {
            if (!IsEmpty)
                root.ToTreeView(treeNode);
        }
    }
}
