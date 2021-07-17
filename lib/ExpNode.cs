using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Yakovlev_Tree
{
    class ExpNode
    {
        private char sign;
        private ExpNode left;
        private ExpNode right;

        public char Sign
        {
            get { return sign; }
            set { sign = value; }
        }
        public ExpNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public ExpNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public ExpNode() { }

        public ExpNode(char sign) 
        {
            Sign = sign;
        }

        public ExpNode(char sign, ExpNode left, ExpNode right)
        {
            Sign = sign;
            Left = left;
            Right = right;
        }
    }
}
