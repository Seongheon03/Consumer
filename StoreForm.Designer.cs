namespace BIND_TEST
{
    partial class StoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.storeName = new System.Windows.Forms.ComboBox();
            this.buyBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
            this.snack = new System.Windows.Forms.Label();
            this.drink = new System.Windows.Forms.Label();
            this.sale1Num = new System.Windows.Forms.NumericUpDown();
            this.sale1 = new System.Windows.Forms.Label();
            this.memoToBuy = new System.Windows.Forms.CheckedListBox();
            this.sale3 = new System.Windows.Forms.Label();
            this.sale2 = new System.Windows.Forms.Label();
            this.snack1 = new System.Windows.Forms.Label();
            this.snack3 = new System.Windows.Forms.Label();
            this.snack2 = new System.Windows.Forms.Label();
            this.drink1 = new System.Windows.Forms.Label();
            this.drink3 = new System.Windows.Forms.Label();
            this.drink2 = new System.Windows.Forms.Label();
            this.listToBuy = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.currentMoney = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.shoppingList = new System.Windows.Forms.ListBox();
            this.drinkPicture = new System.Windows.Forms.PictureBox();
            this.snackPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sale2Num = new System.Windows.Forms.NumericUpDown();
            this.sale3Num = new System.Windows.Forms.NumericUpDown();
            this.snack1Num = new System.Windows.Forms.NumericUpDown();
            this.snack2Num = new System.Windows.Forms.NumericUpDown();
            this.snack3Num = new System.Windows.Forms.NumericUpDown();
            this.drink1Num = new System.Windows.Forms.NumericUpDown();
            this.drink2Num = new System.Windows.Forms.NumericUpDown();
            this.drink3Num = new System.Windows.Forms.NumericUpDown();
            this.sale1Price = new System.Windows.Forms.Label();
            this.sale2Price = new System.Windows.Forms.Label();
            this.sale3Price = new System.Windows.Forms.Label();
            this.snack1Price = new System.Windows.Forms.Label();
            this.snack2Price = new System.Windows.Forms.Label();
            this.snack3Price = new System.Windows.Forms.Label();
            this.drink1Price = new System.Windows.Forms.Label();
            this.drink2Price = new System.Windows.Forms.Label();
            this.drink3Price = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.creditCheck = new System.Windows.Forms.CheckBox();
            this.credit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sale1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snack1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snack2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snack3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink3Num)).BeginInit();
            this.SuspendLayout();
            // 
            // storeName
            // 
            this.storeName.FormattingEnabled = true;
            this.storeName.Items.AddRange(new object[] {
            "7 11",
            "SEEYOU",
            "GS25"});
            this.storeName.Location = new System.Drawing.Point(12, 12);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(121, 23);
            this.storeName.TabIndex = 0;
            this.storeName.SelectedIndexChanged += new System.EventHandler(this.storeName_SelectedIndexChanged);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(668, 397);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(120, 41);
            this.buyBtn.TabIndex = 2;
            this.buyBtn.Text = "구매";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // outBtn
            // 
            this.outBtn.Location = new System.Drawing.Point(525, 397);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(120, 41);
            this.outBtn.TabIndex = 2;
            this.outBtn.Text = "나가기";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // snack
            // 
            this.snack.AutoSize = true;
            this.snack.Location = new System.Drawing.Point(38, 188);
            this.snack.Name = "snack";
            this.snack.Size = new System.Drawing.Size(37, 15);
            this.snack.TabIndex = 4;
            this.snack.Text = "과자";
            // 
            // drink
            // 
            this.drink.AutoSize = true;
            this.drink.Location = new System.Drawing.Point(38, 320);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(37, 15);
            this.drink.TabIndex = 4;
            this.drink.Text = "음료";
            // 
            // sale1Num
            // 
            this.sale1Num.Location = new System.Drawing.Point(276, 74);
            this.sale1Num.Name = "sale1Num";
            this.sale1Num.Size = new System.Drawing.Size(66, 25);
            this.sale1Num.TabIndex = 6;
            this.sale1Num.ValueChanged += new System.EventHandler(this.sale1Num_ValueChanged);
            // 
            // sale1
            // 
            this.sale1.AutoSize = true;
            this.sale1.Location = new System.Drawing.Point(118, 76);
            this.sale1.Name = "sale1";
            this.sale1.Size = new System.Drawing.Size(42, 15);
            this.sale1.TabIndex = 7;
            this.sale1.Text = "sale1";
            // 
            // memoToBuy
            // 
            this.memoToBuy.FormattingEnabled = true;
            this.memoToBuy.Location = new System.Drawing.Point(360, 63);
            this.memoToBuy.Name = "memoToBuy";
            this.memoToBuy.Size = new System.Drawing.Size(203, 324);
            this.memoToBuy.TabIndex = 8;
            // 
            // sale3
            // 
            this.sale3.AutoSize = true;
            this.sale3.Location = new System.Drawing.Point(118, 148);
            this.sale3.Name = "sale3";
            this.sale3.Size = new System.Drawing.Size(42, 15);
            this.sale3.TabIndex = 7;
            this.sale3.Text = "sale3";
            // 
            // sale2
            // 
            this.sale2.AutoSize = true;
            this.sale2.Location = new System.Drawing.Point(118, 111);
            this.sale2.Name = "sale2";
            this.sale2.Size = new System.Drawing.Size(42, 15);
            this.sale2.TabIndex = 7;
            this.sale2.Text = "sale2";
            // 
            // snack1
            // 
            this.snack1.AutoSize = true;
            this.snack1.Location = new System.Drawing.Point(118, 208);
            this.snack1.Name = "snack1";
            this.snack1.Size = new System.Drawing.Size(54, 15);
            this.snack1.TabIndex = 7;
            this.snack1.Text = "snack1";
            // 
            // snack3
            // 
            this.snack3.AutoSize = true;
            this.snack3.Location = new System.Drawing.Point(118, 282);
            this.snack3.Name = "snack3";
            this.snack3.Size = new System.Drawing.Size(54, 15);
            this.snack3.TabIndex = 7;
            this.snack3.Text = "snack3";
            // 
            // snack2
            // 
            this.snack2.AutoSize = true;
            this.snack2.Location = new System.Drawing.Point(118, 245);
            this.snack2.Name = "snack2";
            this.snack2.Size = new System.Drawing.Size(54, 15);
            this.snack2.TabIndex = 7;
            this.snack2.Text = "snack2";
            // 
            // drink1
            // 
            this.drink1.AutoSize = true;
            this.drink1.Location = new System.Drawing.Point(118, 340);
            this.drink1.Name = "drink1";
            this.drink1.Size = new System.Drawing.Size(45, 15);
            this.drink1.TabIndex = 7;
            this.drink1.Text = "drink1";
            // 
            // drink3
            // 
            this.drink3.AutoSize = true;
            this.drink3.Location = new System.Drawing.Point(118, 412);
            this.drink3.Name = "drink3";
            this.drink3.Size = new System.Drawing.Size(45, 15);
            this.drink3.TabIndex = 7;
            this.drink3.Text = "drink3";
            // 
            // drink2
            // 
            this.drink2.AutoSize = true;
            this.drink2.Location = new System.Drawing.Point(118, 375);
            this.drink2.Name = "drink2";
            this.drink2.Size = new System.Drawing.Size(45, 15);
            this.drink2.TabIndex = 7;
            this.drink2.Text = "drink2";
            // 
            // listToBuy
            // 
            this.listToBuy.AutoSize = true;
            this.listToBuy.Location = new System.Drawing.Point(582, 40);
            this.listToBuy.Name = "listToBuy";
            this.listToBuy.Size = new System.Drawing.Size(67, 15);
            this.listToBuy.TabIndex = 9;
            this.listToBuy.Text = "장바구니";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "사야할 물건들";
            // 
            // currentMoney
            // 
            this.currentMoney.AutoSize = true;
            this.currentMoney.Location = new System.Drawing.Point(665, 9);
            this.currentMoney.Name = "currentMoney";
            this.currentMoney.Size = new System.Drawing.Size(96, 15);
            this.currentMoney.TabIndex = 10;
            this.currentMoney.Text = "currentMoney";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(37, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "할인중";
            // 
            // shoppingList
            // 
            this.shoppingList.FormattingEnabled = true;
            this.shoppingList.ItemHeight = 15;
            this.shoppingList.Location = new System.Drawing.Point(585, 63);
            this.shoppingList.Name = "shoppingList";
            this.shoppingList.Size = new System.Drawing.Size(203, 319);
            this.shoppingList.TabIndex = 13;
            // 
            // drinkPicture
            // 
            this.drinkPicture.Location = new System.Drawing.Point(12, 338);
            this.drinkPicture.Name = "drinkPicture";
            this.drinkPicture.Size = new System.Drawing.Size(100, 100);
            this.drinkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drinkPicture.TabIndex = 5;
            this.drinkPicture.TabStop = false;
            // 
            // snackPicture
            // 
            this.snackPicture.Location = new System.Drawing.Point(12, 206);
            this.snackPicture.Name = "snackPicture";
            this.snackPicture.Size = new System.Drawing.Size(100, 100);
            this.snackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snackPicture.TabIndex = 5;
            this.snackPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sale2Num
            // 
            this.sale2Num.Location = new System.Drawing.Point(276, 109);
            this.sale2Num.Name = "sale2Num";
            this.sale2Num.Size = new System.Drawing.Size(66, 25);
            this.sale2Num.TabIndex = 6;
            this.sale2Num.ValueChanged += new System.EventHandler(this.sale2Num_ValueChanged);
            // 
            // sale3Num
            // 
            this.sale3Num.Location = new System.Drawing.Point(276, 146);
            this.sale3Num.Name = "sale3Num";
            this.sale3Num.Size = new System.Drawing.Size(66, 25);
            this.sale3Num.TabIndex = 6;
            this.sale3Num.ValueChanged += new System.EventHandler(this.sale3Num_ValueChanged);
            // 
            // snack1Num
            // 
            this.snack1Num.Location = new System.Drawing.Point(276, 206);
            this.snack1Num.Name = "snack1Num";
            this.snack1Num.Size = new System.Drawing.Size(66, 25);
            this.snack1Num.TabIndex = 6;
            this.snack1Num.ValueChanged += new System.EventHandler(this.snack1Num_ValueChanged);
            // 
            // snack2Num
            // 
            this.snack2Num.Location = new System.Drawing.Point(276, 241);
            this.snack2Num.Name = "snack2Num";
            this.snack2Num.Size = new System.Drawing.Size(66, 25);
            this.snack2Num.TabIndex = 6;
            this.snack2Num.ValueChanged += new System.EventHandler(this.snack2Num_ValueChanged);
            // 
            // snack3Num
            // 
            this.snack3Num.Location = new System.Drawing.Point(276, 278);
            this.snack3Num.Name = "snack3Num";
            this.snack3Num.Size = new System.Drawing.Size(66, 25);
            this.snack3Num.TabIndex = 6;
            this.snack3Num.ValueChanged += new System.EventHandler(this.snack3Num_ValueChanged);
            // 
            // drink1Num
            // 
            this.drink1Num.Location = new System.Drawing.Point(276, 338);
            this.drink1Num.Name = "drink1Num";
            this.drink1Num.Size = new System.Drawing.Size(66, 25);
            this.drink1Num.TabIndex = 6;
            this.drink1Num.ValueChanged += new System.EventHandler(this.drink1Num_ValueChanged);
            // 
            // drink2Num
            // 
            this.drink2Num.Location = new System.Drawing.Point(276, 373);
            this.drink2Num.Name = "drink2Num";
            this.drink2Num.Size = new System.Drawing.Size(66, 25);
            this.drink2Num.TabIndex = 6;
            this.drink2Num.ValueChanged += new System.EventHandler(this.drink2Num_ValueChanged);
            // 
            // drink3Num
            // 
            this.drink3Num.Location = new System.Drawing.Point(276, 410);
            this.drink3Num.Name = "drink3Num";
            this.drink3Num.Size = new System.Drawing.Size(66, 25);
            this.drink3Num.TabIndex = 6;
            this.drink3Num.ValueChanged += new System.EventHandler(this.drink3Num_ValueChanged);
            // 
            // sale1Price
            // 
            this.sale1Price.AutoSize = true;
            this.sale1Price.Location = new System.Drawing.Point(234, 76);
            this.sale1Price.Name = "sale1Price";
            this.sale1Price.Size = new System.Drawing.Size(31, 15);
            this.sale1Price.TabIndex = 7;
            this.sale1Price.Text = "800";
            // 
            // sale2Price
            // 
            this.sale2Price.AutoSize = true;
            this.sale2Price.Location = new System.Drawing.Point(234, 111);
            this.sale2Price.Name = "sale2Price";
            this.sale2Price.Size = new System.Drawing.Size(39, 15);
            this.sale2Price.TabIndex = 7;
            this.sale2Price.Text = "1000";
            // 
            // sale3Price
            // 
            this.sale3Price.AutoSize = true;
            this.sale3Price.Location = new System.Drawing.Point(234, 148);
            this.sale3Price.Name = "sale3Price";
            this.sale3Price.Size = new System.Drawing.Size(31, 15);
            this.sale3Price.TabIndex = 7;
            this.sale3Price.Text = "800";
            // 
            // snack1Price
            // 
            this.snack1Price.AutoSize = true;
            this.snack1Price.Location = new System.Drawing.Point(234, 208);
            this.snack1Price.Name = "snack1Price";
            this.snack1Price.Size = new System.Drawing.Size(39, 15);
            this.snack1Price.TabIndex = 7;
            this.snack1Price.Text = "1000";
            // 
            // snack2Price
            // 
            this.snack2Price.AutoSize = true;
            this.snack2Price.Location = new System.Drawing.Point(234, 243);
            this.snack2Price.Name = "snack2Price";
            this.snack2Price.Size = new System.Drawing.Size(39, 15);
            this.snack2Price.TabIndex = 7;
            this.snack2Price.Text = "1500";
            // 
            // snack3Price
            // 
            this.snack3Price.AutoSize = true;
            this.snack3Price.Location = new System.Drawing.Point(234, 280);
            this.snack3Price.Name = "snack3Price";
            this.snack3Price.Size = new System.Drawing.Size(39, 15);
            this.snack3Price.TabIndex = 7;
            this.snack3Price.Text = "1300";
            // 
            // drink1Price
            // 
            this.drink1Price.AutoSize = true;
            this.drink1Price.Location = new System.Drawing.Point(234, 340);
            this.drink1Price.Name = "drink1Price";
            this.drink1Price.Size = new System.Drawing.Size(39, 15);
            this.drink1Price.TabIndex = 7;
            this.drink1Price.Text = "1000";
            // 
            // drink2Price
            // 
            this.drink2Price.AutoSize = true;
            this.drink2Price.Location = new System.Drawing.Point(234, 375);
            this.drink2Price.Name = "drink2Price";
            this.drink2Price.Size = new System.Drawing.Size(39, 15);
            this.drink2Price.TabIndex = 7;
            this.drink2Price.Text = "1200";
            // 
            // drink3Price
            // 
            this.drink3Price.AutoSize = true;
            this.drink3Price.Location = new System.Drawing.Point(234, 412);
            this.drink3Price.Name = "drink3Price";
            this.drink3Price.Size = new System.Drawing.Size(31, 15);
            this.drink3Price.TabIndex = 7;
            this.drink3Price.Text = "800";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(687, 358);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(38, 15);
            this.price.TabIndex = 54;
            this.price.Text = "price";
            // 
            // creditCheck
            // 
            this.creditCheck.AutoSize = true;
            this.creditCheck.Location = new System.Drawing.Point(460, 410);
            this.creditCheck.Name = "creditCheck";
            this.creditCheck.Size = new System.Drawing.Size(59, 19);
            this.creditCheck.TabIndex = 55;
            this.creditCheck.Text = "외상";
            this.creditCheck.UseVisualStyleBackColor = true;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(687, 340);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(42, 15);
            this.credit.TabIndex = 56;
            this.credit.Text = "credit";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.creditCheck);
            this.Controls.Add(this.price);
            this.Controls.Add(this.currentMoney);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listToBuy);
            this.Controls.Add(this.memoToBuy);
            this.Controls.Add(this.drink2);
            this.Controls.Add(this.snack2);
            this.Controls.Add(this.sale2);
            this.Controls.Add(this.drink3);
            this.Controls.Add(this.snack3);
            this.Controls.Add(this.drink1);
            this.Controls.Add(this.sale3);
            this.Controls.Add(this.snack1);
            this.Controls.Add(this.snack3Price);
            this.Controls.Add(this.sale3Price);
            this.Controls.Add(this.drink3Price);
            this.Controls.Add(this.snack2Price);
            this.Controls.Add(this.sale2Price);
            this.Controls.Add(this.drink2Price);
            this.Controls.Add(this.snack1Price);
            this.Controls.Add(this.sale1Price);
            this.Controls.Add(this.drink1Price);
            this.Controls.Add(this.sale1);
            this.Controls.Add(this.drink3Num);
            this.Controls.Add(this.snack3Num);
            this.Controls.Add(this.sale3Num);
            this.Controls.Add(this.drink2Num);
            this.Controls.Add(this.snack2Num);
            this.Controls.Add(this.sale2Num);
            this.Controls.Add(this.drink1Num);
            this.Controls.Add(this.snack1Num);
            this.Controls.Add(this.sale1Num);
            this.Controls.Add(this.drinkPicture);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.snackPicture);
            this.Controls.Add(this.snack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.shoppingList);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvenienceStore";
            ((System.ComponentModel.ISupportInitialize)(this.sale1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snack1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snack2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snack3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink3Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox storeName;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label snack;
        private System.Windows.Forms.PictureBox snackPicture;
        private System.Windows.Forms.Label drink;
        private System.Windows.Forms.PictureBox drinkPicture;
        private System.Windows.Forms.NumericUpDown sale1Num;
        private System.Windows.Forms.Label sale1;
        private System.Windows.Forms.CheckedListBox memoToBuy;
        private System.Windows.Forms.Label sale3;
        private System.Windows.Forms.Label sale2;
        private System.Windows.Forms.Label snack1;
        private System.Windows.Forms.Label snack3;
        private System.Windows.Forms.Label snack2;
        private System.Windows.Forms.Label drink1;
        private System.Windows.Forms.Label drink3;
        private System.Windows.Forms.Label drink2;
        private System.Windows.Forms.Label listToBuy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label currentMoney;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox shoppingList;
        private System.Windows.Forms.NumericUpDown sale2Num;
        private System.Windows.Forms.NumericUpDown sale3Num;
        private System.Windows.Forms.NumericUpDown snack1Num;
        private System.Windows.Forms.NumericUpDown snack2Num;
        private System.Windows.Forms.NumericUpDown snack3Num;
        private System.Windows.Forms.NumericUpDown drink1Num;
        private System.Windows.Forms.NumericUpDown drink2Num;
        private System.Windows.Forms.NumericUpDown drink3Num;
        private System.Windows.Forms.Label sale1Price;
        private System.Windows.Forms.Label sale2Price;
        private System.Windows.Forms.Label sale3Price;
        private System.Windows.Forms.Label snack1Price;
        private System.Windows.Forms.Label snack2Price;
        private System.Windows.Forms.Label snack3Price;
        private System.Windows.Forms.Label drink1Price;
        private System.Windows.Forms.Label drink2Price;
        private System.Windows.Forms.Label drink3Price;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.CheckBox creditCheck;
        private System.Windows.Forms.Label credit;
    }
}