using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_AVL_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Double(int value)
        {
            return value*2;
        }

        private bool IsEven(int value)
        {
            return value == 1000;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        ArrayAVLTree<int> tr = new ArrayAVLTree<int>() { 19, 4, 100, 1, 6, 85, 106, 7, 84, 90, 105, 150, 83, 86, 95 };
        LinkedAVLTree<int> tr2 = new LinkedAVLTree<int>() { 19, 4, 100, 1, 6, 85, 106, 7, 84, 90, 105, 150, 83, 86, 95 };
        ImmutableAVLTree<int> tr3;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(tbAdd.Text);
            tr.Add(value);
            tr2.Add(value);

            treeViewArray.Nodes.Clear();
            treeViewLinked.Nodes.Clear();

            treeViewArray.Nodes.Add("");
            tr.ToTreeView(treeViewArray.Nodes[0]);
            treeViewArray.ExpandAll();

            treeViewLinked.Nodes.Add("");
            tr2.ToTreeView(treeViewLinked.Nodes[0]);
            treeViewLinked.ExpandAll();
            tbAdd.Clear();
            tbAdd.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbRemove.Text == "") return;
            int value = Int32.Parse(tbRemove.Text);
            tr.Remove(value);
            tr2.Remove(value);

            treeViewArray.Nodes.Clear();
            treeViewLinked.Nodes.Clear();

            treeViewArray.Nodes.Add("");
            tr.ToTreeView(treeViewArray.Nodes[0]);
            treeViewArray.ExpandAll();

            treeViewLinked.Nodes.Add("");
            tr2.ToTreeView(treeViewLinked.Nodes[0]);
            treeViewLinked.ExpandAll();
            tbRemove.Clear();
            tbRemove.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tr.Clear();
            tr2.Clear();
            treeViewArray.Nodes.Clear();
            treeViewLinked.Nodes.Clear();
            tbFind.Clear();
            tbFind.Focus();
        }

        private void btnUtilsExists_Click(object sender, EventArgs e)
        {
            string message;
            if (AVLTreeUtils<int>.Exists(tr, IsEven))
            {
                message = "There is even element in a tree";
            }
            else
            {
                message = "There is NOT even element in a tree";
            }
            MessageBox.Show(message);
            
        }


        private void btnCheckForAll_Click(object sender, EventArgs e)
        {
            string message;
            if (AVLTreeUtils<int>.CheckForAll(tr, IsEven))
            {
                message = "\nAll elements are even";
            }
            else
            {
                message = "\nNOT all elements are even";
            }
            MessageBox.Show(message);
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            AVLTreeUtils<int>.ForEach(tr, Double);
            tvUtils.Nodes.Clear();
            tvUtils.Nodes.Add("");
            tr.ToTreeView(tvUtils.Nodes[0]);
            tvUtils.ExpandAll();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            ArrayAVLTree<int> tr4 = (ArrayAVLTree<int>)AVLTreeUtils<int>.FindAll(tr, IsEven, AVLTreeUtils<int>.ArrayAVLTreeConstructor);
            tvUtils.Nodes.Clear();
            tvUtils.Nodes.Add("");
            tr4.ToTreeView(tvUtils.Nodes[0]);
            tvUtils.ExpandAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tr.Contains(Int32.Parse(tbFind.Text)))
            {
                MessageBox.Show("Element is found");
            }
            else
            {
                MessageBox.Show("Element is not found");
            }
        }

        private void tbAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void tbRemove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRemove_Click(sender, e);
            }
        }

        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }

        private void treeViewArray_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SortedList sr= new SortedList();
        }
    }
}
