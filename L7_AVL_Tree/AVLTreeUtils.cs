using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_AVL_Tree
{
    public delegate bool CheckDelegate<T>(T value);

    public delegate IAVLTree<T> TreeConstructorDelegate<T>();

    public delegate T ActionDelegate<T>(T value);
    class AVLTreeUtils<T>
    {
        
        static public readonly TreeConstructorDelegate<T> ArrayAVLTreeConstructor =() => new ArrayAVLTree<T>(); 

        static public readonly TreeConstructorDelegate<T> LinkedAVLTreeConstructor =() => new LinkedAVLTree<T>();
        
        static public bool Exists(IAVLTree<T> tree, CheckDelegate<T> check)
        {
            foreach(T value in tree)
            {
                if(check(value))
                    return true;
            }
            return false;
        }

       static public IAVLTree<T> FindAll(IAVLTree<T> tree, CheckDelegate<T> check, TreeConstructorDelegate<T> constr)
        {
            IAVLTree<T> resTree = constr();
            foreach(T value in tree)
            {
                if (check(value))
                {
                    resTree.Add(value);
                }
            }
            return resTree;
        }

        static private void ForEachLinked(NodeLinked<T> node, ActionDelegate<T> action)
        {
            if (node is not null)
            {
                node.value = action(node.value);
                ForEachLinked(node.left, action);
                ForEachLinked(node.right, action);
            }
        }

        static private void ForEachArray(NodeArr<T>[] nodesArr, int indx,ActionDelegate<T> action)
        {
          
            if (indx > -1 && indx < nodesArr.Length && nodesArr[indx] is not null)
            {
                nodesArr[indx].item = action(nodesArr[indx].item);
                ForEachArray(nodesArr,nodesArr[indx].left, action);
                ForEachArray(nodesArr,nodesArr[indx].right, action);
            }
        }

        static public void ForEach(IAVLTree<T> tree, ActionDelegate<T> action)
        {
            if (tree.GetType() == typeof(LinkedAVLTree<T>))
            {
                NodeLinked<T> root = ((LinkedAVLTree<T>)tree).root;
                ForEachLinked(root, action);
            }
            else if (tree.GetType() == typeof(ArrayAVLTree<T>))
            {
                ForEachArray(((ArrayAVLTree<T>)tree).nodesArr, 0, action);
            }

        }

        static public bool CheckForAll(IAVLTree<T> tree, CheckDelegate<T> check)
        {
            foreach(T value in tree)
            {
                if (!check(value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
