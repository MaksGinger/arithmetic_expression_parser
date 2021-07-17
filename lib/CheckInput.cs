using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Yakovlev_Tree
{
    public static class CheckInput
    {
        public static void CheckTextBox(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !Char.IsLetter(e.KeyChar) &&
                e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != '*'
                    && e.KeyChar != '/' && e.KeyChar != '(' && e.KeyChar != ')')
                e.Handled = true;
        }
    }
}
