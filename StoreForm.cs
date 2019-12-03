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
    public partial class StoreForm : Form
    {
        static int[] creditMoney = new int[3] { 0, 0, 0 };
        List<string> memo = MemoToBuyForm.memo;
        List<string> shopping = new List<string>();
        decimal[] oldValue = new decimal[9];
        int total = 0;
        int money = GetMoneyForm.money;
        
        public StoreForm()
        {
            InitializeComponent();
            set7_11();

            if (memo.Count == 0)
            {
                memoToBuy.Items.Add("작성한 메모가 없습니다.");
                memoToBuy.Enabled = false;
                return;
            }

            foreach (string str in memo)
                memoToBuy.Items.Add(str);
        }

        private void storeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storeName.SelectedIndex == 0)
                set7_11();
            else if (storeName.SelectedIndex == 1)
                setSeeYou();
            else if (storeName.SelectedIndex == 2)
                setGS24();
        }

        private void sale1Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(sale1, sale1Price, sale1Num, 0);
        }

        private void sale2Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(sale2, sale2Price, sale2Num, 1);
        }

        private void sale3Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(sale3, sale3Price, sale3Num, 2);
        }

        private void snack1Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(snack1, snack1Price, snack1Num, 3);
        }

        private void snack2Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(snack2, snack2Price, snack2Num, 4);
        }

        private void snack3Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(snack3, snack3Price, snack3Num, 5);
        }

        private void drink1Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(drink1, drink1Price, drink1Num, 6);
        }

        private void drink2Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(drink2, drink2Price, drink2Num, 7);
        }

        private void drink3Num_ValueChanged(object sender, EventArgs e)
        {
            changeTotalAndShoppingList(drink3, drink3Price, drink3Num, 8);
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (creditCheck.Checked == true)
            {
                setMemoToBuyFormListBoxs();
                MessageBox.Show("외상처리 되었습니다.");
                Close();
            }
            else if(money < total + creditMoney[storeName.SelectedIndex])
            {
                MessageBox.Show("돈이 부족합니다.");
                return;
            }
            else if (shoppingList.Items.Count == 0 && creditMoney[storeName.SelectedIndex] == 0)
            {
                MessageBox.Show("구매할 물건이 없습니다.");
                return;
            } 
            else
            {
                MessageBox.Show("구매하셨습니다.");
                GetMoneyForm.money -= (total + creditMoney[storeName.SelectedIndex]);
                total = 0;
                creditMoney[storeName.SelectedIndex] = 0;
                setMemoToBuyFormListBoxs();
                Close();
            }
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            if(total != 0 && creditCheck.Checked == true)
            {
                creditMoney[storeName.SelectedIndex] += total;
                setMemoToBuyFormListBoxs();
                MessageBox.Show("외상처리 되었습니다.");
            }
            Close();
        }

        private void changeTotalAndShoppingList(Label product, Label productPrice, NumericUpDown productNum, int oldValueIndex)
        {
            if (productNum.Value > oldValue[oldValueIndex])
                total += Convert.ToInt32(productPrice.Text);

            else
                total -= Convert.ToInt32(productPrice.Text);

            oldValue[oldValueIndex] = productNum.Value;
            price.Text = "합계 : " + setMoneyText(total + creditMoney[storeName.SelectedIndex]);
            setShoppingList(product, productNum);
        }

        private void setShoppingList(Label product, NumericUpDown productNum)
        {
            shoppingList.Items.Remove(product.Text);
            shopping.Remove(product.Text);
            if (productNum.Value > 0)
            {
                shoppingList.Items.Add(product.Text);
                shopping.Add(product.Text);
            }
        }

        private void set7_11()
        {
            storeName.SelectedIndex = 0;
            sale1.Text = "초코에몽"; sale1Price.Text = "800"; sale1Num.Value = 0;
            sale2.Text = "꼬깔콘"; sale2Price.Text = "1000"; sale2Num.Value = 0;
            sale3.Text = "크런키"; sale3Price.Text = "800"; sale3Num.Value = 0;
            snack1.Text = "치킨팝"; snack1Price.Text = "1000"; snack1Num.Value = 0;
            snack2.Text = "허니버터칩"; snack2Price.Text = "1500"; snack2Num.Value = 0;
            snack3.Text = "양파링"; snack3Price.Text = "1300"; snack3Num.Value = 0;
            drink1.Text = "스프라이트"; drink1Price.Text = "1000"; drink1Num.Value = 0;
            drink2.Text = "코카콜라"; drink2Price.Text = "1200"; drink2Num.Value = 0;
            drink3.Text = "환타"; drink3Price.Text = "800"; drink3Num.Value = 0;
            snackPicture.Load(@"C:\Users\user\source\repos\CsStudy\BIND_TEST\Resources\snack1.jpg");
            drinkPicture.Load(@"C:\Users\user\source\repos\CsStudy\BIND_TEST\Resources\drink1.jpg");
            setDefaultText();
        }

        private void setSeeYou()
        {
            storeName.SelectedIndex = 1;
            sale1.Text = "핫바"; sale1Price.Text = "1500"; sale1Num.Value = 0;
            sale2.Text = "참깨라면"; sale2Price.Text = "1000"; sale2Num.Value = 0;
            sale3.Text = "딸기에몽"; sale3Price.Text = "800"; sale3Num.Value = 0;
            snack1.Text = "꼬북칩"; snack1Price.Text = "1300"; snack1Num.Value = 0;
            snack2.Text = "구운양파"; snack2Price.Text = "1500"; snack2Num.Value = 0;
            snack3.Text = "포카칩"; snack3Price.Text = "1500"; snack3Num.Value = 0;
            drink1.Text = "뽀로로 밀크맛"; drink1Price.Text = "1000"; drink1Num.Value = 0;
            drink2.Text = "비타500"; drink2Price.Text = "800"; drink2Num.Value = 0;
            drink3.Text = "밀키스"; drink3Price.Text = "1000"; drink3Num.Value = 0;
            snackPicture.Load(@"C:\Users\user\source\repos\CsStudy\BIND_TEST\Resources\snack2.jpg");
            drinkPicture.Load(@"C:\Users\user\source\repos\CsStudy\BIND_TEST\Resources\drink2.jpg");
            setDefaultText();
        }

        private void setGS24()
        {
            storeName.SelectedIndex = 2;
            sale1.Text = "핫식스"; sale1Price.Text = "1200"; sale1Num.Value = 0;
            sale2.Text = "가나"; sale2Price.Text = "800"; sale2Num.Value = 0;
            sale3.Text = "펩시"; sale3Price.Text = "900"; sale3Num.Value = 0;
            snack1.Text = "뽀또"; snack1Price.Text = "1500"; snack1Num.Value = 0;
            snack2.Text = "콘칩"; snack2Price.Text = "1200"; snack2Num.Value = 0;
            snack3.Text = "바나나킥"; snack3Price.Text = "1300"; snack3Num.Value = 0;
            drink1.Text = "포카리스웨트"; drink1Price.Text = "1800"; drink1Num.Value = 0;
            drink2.Text = "2% 아쿠아"; drink2Price.Text = "1700"; drink2Num.Value = 0;
            drink3.Text = "토레타"; drink3Price.Text = "1800"; drink3Num.Value = 0;
            snackPicture.Load(@"C:\Users\user\source\repos\CsStudy\BIND_TEST\Resources\snack3.jpg");
            drinkPicture.Load(@"C:\Users\user\source\repos\CsStudy\BIND_TEST\Resources\drink3.jpg");
            setDefaultText();
        }

        private string setMoneyText(int money)
        {
            if (money == 0)
                return "0원";

            return String.Format("{0:#,###}", money) + "원";
        }

        private void setMemoToBuyFormListBoxs()
        {
            for (int i = 0; i < memo.Count; i++)
            {
                if (memoToBuy.GetItemChecked(i))
                    MemoToBuyForm.memo.Remove(memoToBuy.Items[i].ToString());
            }

            for (int i = 0; i < shopping.Count; i++)
            {
                bool check = true;

                if (MemoToBuyForm.bought.Count == 0)
                {
                    MemoToBuyForm.bought.Add(shopping[i]);
                    continue;
                }

                for (int j = 0; j < MemoToBuyForm.bought.Count; j++)
                {
                    if (MemoToBuyForm.bought[j].Equals(shopping[i]))
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                    MemoToBuyForm.bought.Add(shopping[i]);
            }
        }                                   

        private void setDefaultText()
        {
            total = 0;
            currentMoney.Text = "현재 돈 : " + setMoneyText(money);
            credit.Text = "외상 : " + setMoneyText(creditMoney[storeName.SelectedIndex]);
            price.Text = "합계 : " + setMoneyText(total + creditMoney[storeName.SelectedIndex]);
            shoppingList.Items.Clear();
            if (creditMoney[storeName.SelectedIndex] == 0)
                credit.Visible = false;
            else
                credit.Visible = true;
        }
    }
}