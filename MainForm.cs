using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Yakovlev_Tree
{
    public partial class MainForm : Form
    {
        private ExpTree tree;
        private string expression;

        private ExpTree Tree
        {
            get { return tree; }
            set { tree = value; }
        }
        private string Expression
        {
            get { return expression; }
            set { expression = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            Tree = new ExpTree();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void expBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput.CheckTextBox(e);
        }

        private void CreateTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (expBox.Text == "") MessageBox.Show("Вы не ввели выражение!", "Внимание!");
            else
            {
                int index = 0;
                Expression = expBox.Text;
                if (Expression.GetStringForm() != "" )
                {
                    if (Expression.GetStringForm() == "postfix")
                        Tree.Root = Tree.CreateFromPrefix(Expression.PostfixToPrefix(), ref index);
                    else if (Expression.GetStringForm() == "prefix")
                        Tree.Root = Tree.CreateFromPrefix(Expression, ref index);
                    else if (Expression.GetStringForm() == "infix")
                        Tree.Root = Tree.CreateFromPrefix(Expression.InfixToPrefix(), ref index);
                    Tree.BuildTreeView(Tree.Root, treeView1);
                }
                else MessageBox.Show("Вероятно вы ввели выражение, не имеющее смысла", "Внимание!");
            }
        }

        private void DestructTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tree.DestructTree();
            expBox.Clear();
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (Tree.Root != null)
            {
                Tree.BuildTreeView(Tree.Root, treeView1);
            }
            else MessageBox.Show("Дерево не создано", "Внимание!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            expBox.Clear();
        }

        private void TaskTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tree.Root != null)
            {
                Tree.Root = Tree.WorkOnTree(Tree.Root);
                Tree.BuildTreeView(Tree.Root, treeView2);
            }
            else MessageBox.Show("Дерево не создано", "Внимание!");
        }
    }
}
