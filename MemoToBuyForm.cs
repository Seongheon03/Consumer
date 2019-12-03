using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIND_TEST
{
    public partial class MemoToBuyForm : Form
    {
        public static List<string> memo = new List<string>();
        public static List<string> bought = new List<string>();

        public MemoToBuyForm()
        {
            InitializeComponent();

            foreach(string str in memo)
                memoListToBuy.Items.Add(str);

            foreach (string str in bought)
                listToBougth.Items.Add(str);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addMemo.Text==(""))
                return;

            memoListToBuy.Items.Add(addMemo.Text);
            memo.Add(addMemo.Text);
            addMemo.Text = "";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            memoListToBuy.Items.Remove(delMemo.Text);
            memo.Remove(delMemo.Text);
            delMemo.Text = "";
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
