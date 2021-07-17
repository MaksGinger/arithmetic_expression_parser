using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Yakovlev_Tree
{
    class ExpTree
    {
        private ExpNode root;

        public ExpNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public ExpTree()
        {
            root = null;
        }

        public ExpNode CreateFromPrefix(string s, ref int index)
        {
            
            ExpNode root = null;
            if (index < s.Length)
            {
                root = new ExpNode(s[index]);
                if (s[index].IsOperatorOrBracket())
                {
                    index++;
                    root.Left = CreateFromPrefix(s, ref index);
                    index++;
                    root.Right = CreateFromPrefix(s, ref index);
                }
            }
          
            return root;
        }

        public void DestructTree()
        {
            root = null;
        }

        public void KLPSubTree(ExpNode root, TreeNode treeNode) //нисходящий обход (префиксная)
        {
            if (root != null)
            {
                TreeNode childNode = treeNode.Nodes.Add(root.Sign.ToString());
                KLPSubTree(root.Left,childNode);
                KLPSubTree(root.Right,childNode);
            }
        }

        public void BuildTreeView(ExpNode root,TreeView treeView)
        {
            treeView.Nodes.Clear();
            if (root != null)
            {
                treeView.Nodes.Add(root.Sign.ToString());
                KLPSubTree(root.Left, treeView.Nodes[0]);
                KLPSubTree(root.Right, treeView.Nodes[0]);
                treeView.Nodes[0].ExpandAll();
            }            
        }

        //функция для задания
        public ExpNode WorkOnTree(ExpNode root)
        {
            if (root != null)
            {
                if (root.Left != null)
                    root.Left = WorkOnTree(root.Left);
                if (root.Right != null)
                    root.Right = WorkOnTree(root.Right);

                switch (root.Sign)
                {
                    case '+':
                        if (root.Left.Sign == '0') root = root.Right;
                        else if (root.Right.Sign == '0') root = root.Left;
                        break;
                    case '-':
                        if (root.Right.Sign == '0') root = root.Left;   
                        break;
                    case '*':
                        if (root.Left.Sign == '0' || root.Right.Sign == '0')
                        {
                            root.Left = null;
                            root.Right = null;
                            root.Sign = '0';
                        }
                        else if (root.Left.Sign == '1') root = root.Right;
                        else if (root.Right.Sign == '1') root = root.Left;
                        break;
                    case '/':
                        if (root.Left.Sign == '0')
                        {
                            root.Left = null;
                            root.Right = null;
                            root.Sign = '0';
                        }
                        else if (root.Right.Sign == '0') root = root.Left;                            
                        break;
                }               
            }
            return root;
        }
    }
}
