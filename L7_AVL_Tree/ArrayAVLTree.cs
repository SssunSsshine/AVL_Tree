using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_AVL_Tree
{
    class ArrayAVLTree<T> : IAVLTree<T>
    {
        public NodeArr<T>[] nodesArr;
        int count;
        private int N;
        public delegate int CompareDelegate(T v1, T v2);
        public readonly CompareDelegate compare = Comparer<T>.Default.Compare;

        public ArrayAVLTree()
        {
            N = 10;
            nodesArr = new NodeArr<T>[N];
        }

        public ArrayAVLTree(CompareDelegate compare)
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
                return count == 0;
            }
        }

        static int LChild(int idx)
        {
            return idx* 2 + 1;
        }

        static int RChild(int idx)
        {
            return idx * 2 + 2;
        }

        static int Parent(int idx)
        {
            if (idx <= 0) return -1;
            return (idx - 1) / 2;
        }

        int Height(int indx)
        {
            if (indx >= N || nodesArr[indx] is null)
            {
                return 0;
            }
            else
            {
                int hl = Height(LChild(indx)) + 1;
                int hr = Height(RChild(indx)) + 1;
                return Math.Max(hl,hr);
            }
        }

        void ShiftUp(int indx, int towards)
        {
            if (indx >= N || nodesArr[indx] == null || nodesArr[towards] is not null)
            {
                return;
            }

            int tmp = Parent(towards);

            if (towards != 0 && nodesArr[tmp] is not null)
                if (towards % 2 == 0)
                    nodesArr[tmp].right = towards;
                else
                    nodesArr[tmp].left = towards;

            nodesArr[towards] = nodesArr[indx]; 
            nodesArr[indx] = null ;

            int lchild = LChild(towards);
            int rchild = RChild(towards);   

            if (nodesArr[lchild] is not null)
                nodesArr[towards].left = lchild;
            else
                nodesArr[towards].left = -1;

            if (nodesArr[rchild] is not null)
                nodesArr[towards].right = rchild;
            else
                nodesArr[towards].right = -1;

            ShiftUp(LChild(indx), lchild);
            ShiftUp(RChild(indx), rchild);
        }

        void ShiftDown(int indx, int towards)
        {
            if (indx >= N || nodesArr[indx] == null)
            {
                return;
            }

            while (towards >= N)
            {
                Enlarge();
            }

            int lchild = LChild(towards);
            int rchild = RChild(towards);

            if (nodesArr[indx].left != -1)
                ShiftDown(LChild(indx), lchild);

            if (nodesArr[indx].right != -1)
                ShiftDown(RChild(indx), rchild);

            if (indx != 0 && indx % 2 == 0)
                nodesArr[Parent(indx)].right = -1;
            else
                nodesArr[Parent(indx)].left = -1;

            nodesArr[towards] = nodesArr[indx];
            nodesArr[indx] = null;

            if (nodesArr[lchild] is not null)
                nodesArr[towards].left = lchild;
            else
                nodesArr[towards].left = -1;

            if (nodesArr[rchild] is not null)
                nodesArr[towards].right = rchild;
            else
                nodesArr[towards].right = -1;
        }

        void Enlarge()
        {
            NodeArr<T>[] array_n;

            N *= 2;
            array_n = new NodeArr<T>[N];

            int i = 0;
            foreach (NodeArr<T> item in nodesArr)
            {
                array_n[i] = item;
                i++;
            }
            
            nodesArr = array_n;
        }

        void RotateRight(int rootIndx)
        {
            int lchild = LChild(rootIndx);
            int rchild = RChild(rootIndx);

            ShiftDown(rchild, RChild(rchild));

            if (nodesArr[rootIndx] is not null)
                nodesArr[rootIndx].right = RChild(rootIndx);

            rchild = RChild(rootIndx);

            nodesArr[rchild] = new NodeArr<T>(nodesArr[rootIndx].item);

            if (LChild(rchild) < N && nodesArr[LChild(rchild)] is not null)
                nodesArr[rchild].left = LChild(rchild);
            else
                nodesArr[rchild].left = -1;

            if (RChild(rchild) < N && nodesArr[RChild(rchild)] is not null)
                nodesArr[rchild].right = RChild(rchild);
            else
                nodesArr[rchild].right = -1;

            ShiftDown(RChild(lchild), LChild(rchild));
            
            rchild = RChild(rootIndx);

            if (nodesArr[rchild] is not null)
                    nodesArr[rchild].left = LChild(rchild);

            nodesArr[rootIndx] = null;

            ShiftUp(lchild, rootIndx);

        }

        void RotateLeft(int rootIndx)
        {
            int rchild = RChild(rootIndx);
            int lchild = LChild(rootIndx);

            ShiftDown(lchild, LChild(lchild));

            if (nodesArr[rootIndx] is not null)
                nodesArr[rootIndx].left = LChild(rootIndx);

            lchild = LChild(rootIndx);

            nodesArr[lchild] = new NodeArr<T>(nodesArr[rootIndx].item);

            if (LChild(lchild) < N && nodesArr[LChild(lchild)] is not null)
                nodesArr[lchild].left = LChild(lchild);
            else
                nodesArr[lchild].left = -1;

            if (RChild(lchild) < N && nodesArr[RChild(lchild)] is not null)
                nodesArr[lchild].right = RChild(lchild);
            else
                nodesArr[lchild].right = -1;

            ShiftDown(LChild(rchild), RChild(lchild));
            
            lchild = LChild(rootIndx);
            
            if (nodesArr[lchild] is not null)
                nodesArr[lchild].right = RChild(lchild);

            nodesArr[rootIndx] = null;

            ShiftUp(rchild, rootIndx);

        }
        void RotateLeftRight(int rootIndx)
        {
            int newRootIndx = RChild(LChild(rootIndx));
            int rchild = RChild(rootIndx);

            ShiftDown(rchild, RChild(rchild));
            
            rchild = RChild(rootIndx);

            nodesArr[rchild] = nodesArr[rootIndx];
            if (LChild(rchild) < N && nodesArr[LChild(rchild)] is not null)
                nodesArr[rchild].left = LChild(rchild);
            else
                nodesArr[rchild].left = -1;

            if (RChild(rchild) < N && nodesArr[RChild(rchild)] is not null)
                nodesArr[rchild].right = RChild(rchild);
            else
                nodesArr[rchild].right = -1;

            ShiftUp(RChild(newRootIndx), LChild(RChild(rootIndx)));

            if (Parent(newRootIndx) < N)
            {
                if (newRootIndx != 0 && newRootIndx % 2 == 0)
                    nodesArr[Parent(newRootIndx)].right = -1;
                else
                    nodesArr[Parent(newRootIndx)].left = -1;
            }
            if (Parent(rootIndx) < N)
            {
                if (rootIndx != 0 && nodesArr[Parent(rootIndx)] is not null)
                    if (rootIndx % 2 == 0)
                        nodesArr[Parent(rootIndx)].right = rootIndx;
                    else
                        nodesArr[Parent(rootIndx)].left = rootIndx;
            }
                
            nodesArr[rootIndx] = nodesArr[newRootIndx]; 
            nodesArr[newRootIndx] = null;

            rchild = RChild(rootIndx);
            int lchild = LChild(rootIndx);

            if (nodesArr[lchild] is not null)
                nodesArr[rootIndx].left = lchild;
            else
                nodesArr[lchild].left = -1;

            if (nodesArr[rchild] is not null)
                nodesArr[rootIndx].right = rchild;
            else
                nodesArr[rchild].right = -1;

            ShiftUp(LChild(newRootIndx), newRootIndx);
        }

        void RotateRightLeft(int rootIndx)
        {
            int newRootIndx = LChild(RChild(rootIndx));
            int lchild = LChild(rootIndx);

            ShiftDown(lchild, LChild(lchild));

            lchild = LChild(rootIndx);

            nodesArr[lchild] = nodesArr[rootIndx];
            if (LChild(lchild) < N && nodesArr[LChild(lchild)] is not null)
                nodesArr[lchild].left = LChild(lchild);
            else
                nodesArr[lchild].left = -1;

            if (RChild(lchild) < N && nodesArr[RChild(lchild)] is not null)
                nodesArr[lchild].right = RChild(lchild);
            else
                nodesArr[lchild].right = -1;

            ShiftUp(LChild(newRootIndx), RChild(lchild));

            if (Parent(newRootIndx) < N)
            {    if (newRootIndx != 0 && newRootIndx % 2 == 0)
                    nodesArr[Parent(newRootIndx)].right = -1;
                else
                    nodesArr[Parent(newRootIndx)].left = -1;
            }
            if (Parent(rootIndx) < N)
            {
                if (rootIndx != 0 && nodesArr[Parent(rootIndx)] is not null)
                    if (rootIndx % 2 == 0)
                        nodesArr[Parent(rootIndx)].right = rootIndx;
                    else
                        nodesArr[Parent(rootIndx)].left = rootIndx;
            }
            nodesArr[rootIndx] = nodesArr[newRootIndx];
            nodesArr[newRootIndx] = null;

            lchild = LChild(rootIndx);
            int rchild = RChild(rootIndx);
            
            if (nodesArr[lchild] is not null)
                nodesArr[rootIndx].left = lchild;
            else
                nodesArr[rootIndx].left = -1;

            if (nodesArr[rchild] is not null)
                nodesArr[rootIndx].right = rchild;
            else
                nodesArr[rootIndx].right = -1;

            ShiftUp(RChild(newRootIndx), newRootIndx);
        }

        void Rebalance(int idx)
        {
            while (true)
            {
                int h = Height(LChild(idx)) - Height(RChild(idx));
                int bf_r;
                if (h < -1)
                {
                    bf_r = Height(LChild(RChild(idx))) - Height(RChild(RChild(idx)));

                    if (bf_r <= 0)
                    {
                        RotateLeft(idx);
                    }
                    else
                    {
                        RotateRightLeft(idx);
                    }
                }
                else if (h > 1)
                {
                    bf_r = Height(LChild(LChild(idx))) - Height(RChild(LChild(idx)));

                    if (bf_r >= 0)
                    {
                        RotateRight(idx);
                    }
                    else
                    {
                        RotateLeftRight(idx);
                    }
                    
                }

                if (idx == 0) break;
                idx = Parent(idx);
            }
        }

        public void Add(T item)
        {
            int i;
            NodeArr<T> node;

            for (i = 0; i < N;)
            {
                node = nodesArr[i];

                if (node is null)
                {
                    node = new NodeArr<T>(item);
                    nodesArr[i] = node;
                    count += 1;
                    if (i != 0)
                    {
                        if (i % 2 == 0)
                            nodesArr[Parent(i)].right = i;
                        else
                            nodesArr[Parent(i)].left = i;
                    }

                    if (0 == i)
                        return;

                    Rebalance(Parent(i));
                    return;
                }

                if (compare(item, node.item) < 0)
                {
                    i = LChild(i);
                    if (i >= N)
                    {
                        Enlarge();
                    }
                }
                else if (compare(item, node.item) > 0)
                {
                    i = RChild(i);
                    if (i >= N)
                    {
                        Enlarge();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        public void Clear()
        {
            if (IsEmpty) return;
            nodesArr = null;
            count = 0;
            nodesArr = new NodeArr<T>[N];
        }

        public bool Contains(T item)
        {
            bool isContains = false;
            int i = 0;
            NodeArr<T> node = nodesArr[i];
            while (!isContains && i < N && node is not null)
            {   
                if (compare(node.item, item) == 0)
                {
                    isContains = true;
                }
                else if (compare(node.item, item) == -1)
                {
                    i = RChild(i);
                }
                else if(compare(node.item, item) == 1)
                {
                    i = LChild(i);
                }
                if (i < N)
                    node = nodesArr[i];
            }
            return isContains;
        }


        int PreviousOrderedNode(int idx)
        {
            int prev, i;

            for (prev = -1, i = LChild(idx);
                i < N && nodesArr[i] is not null; 
                prev = i, i = RChild(i));
            if (prev == -1)
            {
                //Поиск индекса самого маленького элемента из правого поддерева
                for (prev = -1, i = RChild(idx);
                     i < N && nodesArr[i] is not null;
                     prev = i, i = LChild(i)) ;
            }

            return prev;
        }

        public bool Remove(T item)
        {
            int i;

            for (i = 0; i < N;)
            {
                NodeArr<T> n;

                n = nodesArr[i];

                if (n is null)
                    return false;

                if (compare(n.item, item) == 0)
                {
                    int rep;

                    count -= 1;

                    rep = PreviousOrderedNode(i);
                    if (-1 == rep)
                    {
                        nodesArr[i] = null;
                    }
                    else
                    {
                        nodesArr[i] = null;
                        ShiftUp(rep, i);
                        if (rep != 0)
                        {
                            if (nodesArr[LChild(Parent(rep))] is not null)
                            {
                                nodesArr[Parent(rep)].left = LChild(Parent(rep));
                            }
                            else
                                nodesArr[Parent(rep)].left = -1;

                            if (nodesArr[RChild(Parent(rep))] is not null)
                            {
                                nodesArr[Parent(rep)].right = RChild(Parent(rep));
                            }
                            else
                                nodesArr[Parent(rep)].right = -1;
                        }

                        int lrep = LChild(rep);

                        ShiftUp(lrep, RChild(Parent(rep)));
                        if (lrep != 0 && nodesArr[Parent(lrep)] is not null)
                        {
                            if (LChild(Parent(lrep)) < N && nodesArr[LChild(Parent(lrep))] is not null)
                            {
                                nodesArr[Parent(lrep)].left = LChild(Parent(lrep));
                            }
                            else
                                nodesArr[Parent(lrep)].left = -1;

                            if (RChild(Parent(lrep)) < N && nodesArr[RChild(Parent(lrep))] is not null)
                            {
                                nodesArr[Parent(lrep)].right = RChild(Parent(lrep));
                            }
                            else
                                nodesArr[Parent(lrep)].right = -1;
                        }

                        
                    }
                    Rebalance(i);

                    return true;
                }
                else if (compare(n.item, item) == 1)
                {
                    i = LChild(i);
                }
                else if (compare(n.item, item) == -1)
                {
                    i = RChild(i);
                }
            }

            return false;
        }
        public IEnumerable<T> nodes
        {
            get
            {
                T[] itemsArr = new T[N];
                int i = 0;
                foreach (NodeArr<T> n in nodesArr)
                {
                    itemsArr[i] = n.item;
                    ++i;
                }
                return itemsArr;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (NodeArr<T> n in nodesArr)
            {
                if (n is not null)
                     yield return n.item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void ToTreeView(int indx, TreeNode treeNode)
        {
            int i = 0;
            if (indx >= 0 && indx < nodesArr.Length && nodesArr[indx] is not null)
            {
                treeNode.Nodes.Add(nodesArr[indx].item.ToString());
                if (treeNode.Nodes.Count == 2)
                {
                    i++;
                }

                ToTreeView(nodesArr[indx].left, treeNode.Nodes[i]);
                ToTreeView(nodesArr[indx].right, treeNode.Nodes[i]);
            }
        }
        public void ToTreeView(TreeNode treeNode)
        {
            ToTreeView(0, treeNode);
        }
    }
}
