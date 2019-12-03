namespace BIND_TEST
{
    partial class GetMoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetMoneyForm));
            this.currentMoney = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.cheonWon = new System.Windows.Forms.PictureBox();
            this.ohcheonWon = new System.Windows.Forms.PictureBox();
            this.manWon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cheonWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohcheonWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manWon)).BeginInit();
            this.SuspendLayout();
            // 
            // currentMoney
            // 
            this.currentMoney.AutoSize = true;
            this.currentMoney.Location = new System.Drawing.Point(317, 79);
            this.currentMoney.Name = "currentMoney";
            this.currentMoney.Size = new System.Drawing.Size(96, 15);
            this.currentMoney.TabIndex = 0;
            this.currentMoney.Text = "currentMoney";
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(320, 344);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(118, 78);
            this.endBtn.TabIndex = 3;
            this.endBtn.Text = "완료";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // cheonWon
            // 
            this.cheonWon.Image = ((System.Drawing.Image)(resources.GetObject("cheonWon.Image")));
            this.cheonWon.Location = new System.Drawing.Point(577, 148);
            this.cheonWon.Name = "cheonWon";
            this.cheonWon.Size = new System.Drawing.Size(211, 131);
            this.cheonWon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheonWon.TabIndex = 6;
            this.cheonWon.TabStop = false;
            this.cheonWon.Click += new System.EventHandler(this.cheonWon_Click);
            // 
            // ohcheonWon
            // 
            this.ohcheonWon.Image = ((System.Drawing.Image)(resources.GetObject("ohcheonWon.Image")));
            this.ohcheonWon.Location = new System.Drawing.Point(300, 148);
            this.ohcheonWon.Name = "ohcheonWon";
            this.ohcheonWon.Size = new System.Drawing.Size(233, 131);
            this.ohcheonWon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ohcheonWon.TabIndex = 5;
            this.ohcheonWon.TabStop = false;
            this.ohcheonWon.Click += new System.EventHandler(this.ohcheonWon_Click);
            // 
            // manWon
            // 
            this.manWon.Image = ((System.Drawing.Image)(resources.GetObject("manWon.Image")));
            this.manWon.Location = new System.Drawing.Point(12, 148);
            this.manWon.Name = "manWon";
            this.manWon.Size = new System.Drawing.Size(248, 131);
            this.manWon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manWon.TabIndex = 4;
            this.manWon.TabStop = false;
            this.manWon.Click += new System.EventHandler(this.manWon_Click);
            // 
            // GetMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cheonWon);
            this.Controls.Add(this.ohcheonWon);
            this.Controls.Add(this.manWon);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.currentMoney);
            this.Name = "GetMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetMoney";
            ((System.ComponentModel.ISupportInitialize)(this.cheonWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohcheonWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manWon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentMoney;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.PictureBox manWon;
        private System.Windows.Forms.PictureBox ohcheonWon;
        private System.Windows.Forms.PictureBox cheonWon;
    }
}