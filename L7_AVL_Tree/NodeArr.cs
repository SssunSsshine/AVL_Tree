using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_AVL_Tree
{
    class NodeArr<T>
    {
        public T item;
        public int left = -1;
        public int right = -1;
        public NodeArr()
        {
        }
        public NodeArr(T item)
        {
            this.item = item;
        }
        public NodeArr(T item, int left, int right)
        {
            this.item = item;
            this.left = left;
            this.right = right;
        }
    }
}
