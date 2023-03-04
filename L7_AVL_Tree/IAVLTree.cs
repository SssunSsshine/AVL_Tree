using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_AVL_Tree
{
    public interface IAVLTree<T>: IEnumerable<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        IEnumerable<T> nodes { get;}
        void Add(T node);
        void Clear();
        bool Contains(T node);
        bool Remove(T node);
        void ToTreeView(TreeNode treeNode);


    }
}
