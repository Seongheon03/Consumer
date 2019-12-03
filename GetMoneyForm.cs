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
    public partial class GetMoneyForm : Form
    {
        public static int money = 5000;

        public GetMoneyForm()
        {
            InitializeComponent();
            currentMoney.Text = setCurrentmoneyText();
        }

        private void manWon_Click(object sender, EventArgs e)
        {
            money += 10000;
            MessageBox.Show("만원 추가되었습니다.");
            currentMoney.Text = setCurrentmoneyText();
        }

        private void ohcheonWon_Click(object sender, EventArgs e)
        {
            money += 5000;
            MessageBox.Show("오천원 추가되었습니다.");
            currentMoney.Text = setCurrentmoneyText();
        }

        private void cheonWon_Click(object sender, EventArgs e)
        {
            money += 1000;
            MessageBox.Show("천원 추가되었습니다.");
            currentMoney.Text = setCurrentmoneyText();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private string setCurrentmoneyText()
        {
            if(money == 0)
                return "현재 돈 : 0원";
            return "현재 돈 : " + String.Format("{0:#,###}", money) + "원";
        }
    }
}
