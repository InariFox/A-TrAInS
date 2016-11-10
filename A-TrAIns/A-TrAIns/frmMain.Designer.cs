namespace A_TrAIns
{
    partial class frmRough
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdOudia = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.tboxDiagram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ofdOudia
            // 
            this.ofdOudia.FileName = "openFileDialog1";
            this.ofdOudia.Filter = "Oudiaダイヤデータ|*.oud";
            this.ofdOudia.Title = "Oudiaのダイヤファイルを開く";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(497, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(13, 12);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(109, 23);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "路線データ表示";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // tboxDiagram
            // 
            this.tboxDiagram.Location = new System.Drawing.Point(12, 71);
            this.tboxDiagram.Multiline = true;
            this.tboxDiagram.Name = "tboxDiagram";
            this.tboxDiagram.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxDiagram.Size = new System.Drawing.Size(559, 278);
            this.tboxDiagram.TabIndex = 3;
            // 
            // frmRough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.tboxDiagram);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen);
            this.MaximizeBox = false;
            this.Name = "frmRough";
            this.Text = "A-TrAInsラフ用";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdOudia;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.TextBox tboxDiagram;
    }
}

