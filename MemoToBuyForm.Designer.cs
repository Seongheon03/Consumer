namespace BIND_TEST
{
    partial class MemoToBuyForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addMemo = new System.Windows.Forms.TextBox();
            this.delMemo = new System.Windows.Forms.TextBox();
            this.memoListToBuy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listToBougth = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(197, 109);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(110, 26);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "메모 추가";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(197, 227);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(110, 25);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "메모 삭제";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addMemo
            // 
            this.addMemo.Location = new System.Drawing.Point(65, 110);
            this.addMemo.Name = "addMemo";
            this.addMemo.Size = new System.Drawing.Size(100, 25);
            this.addMemo.TabIndex = 2;
            // 
            // delMemo
            // 
            this.delMemo.Location = new System.Drawing.Point(65, 227);
            this.delMemo.Name = "delMemo";
            this.delMemo.Size = new System.Drawing.Size(100, 25);
            this.delMemo.TabIndex = 2;
            // 
            // memoListToBuy
            // 
            this.memoListToBuy.FormattingEnabled = true;
            this.memoListToBuy.ItemHeight = 15;
            this.memoListToBuy.Location = new System.Drawing.Point(368, 57);
            this.memoListToBuy.Name = "memoListToBuy";
            this.memoListToBuy.Size = new System.Drawing.Size(182, 364);
            this.memoListToBuy.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "메모";
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(207, 336);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(100, 56);
            this.endBtn.TabIndex = 5;
            this.endBtn.Text = "완료";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "구매 목록";
            // 
            // listToBougth
            // 
            this.listToBougth.FormattingEnabled = true;
            this.listToBougth.ItemHeight = 15;
            this.listToBougth.Location = new System.Drawing.Point(580, 57);
            this.listToBougth.Name = "listToBougth";
            this.listToBougth.Size = new System.Drawing.Size(182, 364);
            this.listToBougth.TabIndex = 7;
            // 
            // MemoToBuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listToBougth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memoListToBuy);
            this.Controls.Add(this.delMemo);
            this.Controls.Add(this.addMemo);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "MemoToBuyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemoToBuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox addMemo;
        private System.Windows.Forms.TextBox delMemo;
        private System.Windows.Forms.ListBox memoListToBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listToBougth;
    }
}