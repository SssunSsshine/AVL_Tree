using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_AVL_Tree
{
    class AVLTreeException: Exception
    {
        public AVLTreeException(string msg = "AVL Tree exception"):base(msg){}
    }
    class AttemptOfChangingImmutableAVLTree: AVLTreeException
    {
        public AttemptOfChangingImmutableAVLTree(string msg = "AVL Tree cannot be changed"):base(msg){}
    }
}
