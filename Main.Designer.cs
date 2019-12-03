namespace BIND_TEST
{
    partial class Main
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
            this.getMoney = new System.Windows.Forms.Button();
            this.listToBuy = new System.Windows.Forms.Button();
            this.goStore = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getMoney
            // 
            this.getMoney.Location = new System.Drawing.Point(52, 99);
            this.getMoney.Name = "getMoney";
            this.getMoney.Size = new System.Drawing.Size(188, 172);
            this.getMoney.TabIndex = 0;
            this.getMoney.Text = "돈 추가하기";
            this.getMoney.UseVisualStyleBackColor = true;
            this.getMoney.Click += new System.EventHandler(this.getMoney_Click);
            // 
            // listToBuy
            // 
            this.listToBuy.Location = new System.Drawing.Point(305, 99);
            this.listToBuy.Name = "listToBuy";
            this.listToBuy.Size = new System.Drawing.Size(188, 172);
            this.listToBuy.TabIndex = 0;
            this.listToBuy.Text = "메모 / 구매 리스트";
            this.listToBuy.UseVisualStyleBackColor = true;
            this.listToBuy.Click += new System.EventHandler(this.listToBuy_Click);
            // 
            // goStore
            // 
            this.goStore.Location = new System.Drawing.Point(551, 99);
            this.goStore.Name = "goStore";
            this.goStore.Size = new System.Drawing.Size(188, 172);
            this.goStore.TabIndex = 0;
            this.goStore.Text = "편의점 가기";
            this.goStore.UseVisualStyleBackColor = true;
            this.goStore.Click += new System.EventHandler(this.goStore_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(305, 328);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(188, 96);
            this.endBtn.TabIndex = 1;
            this.endBtn.Text = "종료";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.goStore);
            this.Controls.Add(this.listToBuy);
            this.Controls.Add(this.getMoney);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getMoney;
        private System.Windows.Forms.Button listToBuy;
        private System.Windows.Forms.Button goStore;
        private System.Windows.Forms.Button endBtn;
    }
}

