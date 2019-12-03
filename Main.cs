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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void getMoney_Click(object sender, EventArgs e)
        {
            new GetMoneyForm().ShowDialog();
        }

        private void listToBuy_Click(object sender, EventArgs e)
        {
            new MemoToBuyForm().ShowDialog();
        }

        private void goStore_Click(object sender, EventArgs e)
        { 
            new StoreForm().ShowDialog();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
