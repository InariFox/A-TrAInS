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
            this.dgvDiagram = new System.Windows.Forms.DataGridView();
            this.lblLineInfo = new System.Windows.Forms.Label();
            this.lblDiaList = new System.Windows.Forms.Label();
            this.tboxLineName = new System.Windows.Forms.TextBox();
            this.cboxDiaList = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblFor = new System.Windows.Forms.Label();
            this.cboxFor = new System.Windows.Forms.ComboBox();
            this.pn_menu1 = new System.Windows.Forms.Panel();
            this.pn_menu2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagram)).BeginInit();
            this.pn_menu1.SuspendLayout();
            this.pn_menu2.SuspendLayout();
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
            this.btnOpen.Location = new System.Drawing.Point(16, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvDiagram
            // 
            this.dgvDiagram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDiagram.Location = new System.Drawing.Point(0, 77);
            this.dgvDiagram.Name = "dgvDiagram";
            this.dgvDiagram.RowTemplate.Height = 21;
            this.dgvDiagram.Size = new System.Drawing.Size(1008, 652);
            this.dgvDiagram.TabIndex = 3;
            // 
            // lblLineInfo
            // 
            this.lblLineInfo.AutoSize = true;
            this.lblLineInfo.Location = new System.Drawing.Point(25, 15);
            this.lblLineInfo.Name = "lblLineInfo";
            this.lblLineInfo.Size = new System.Drawing.Size(47, 12);
            this.lblLineInfo.TabIndex = 4;
            this.lblLineInfo.Text = "路線名：";
            // 
            // lblDiaList
            // 
            this.lblDiaList.AutoSize = true;
            this.lblDiaList.Location = new System.Drawing.Point(9, 44);
            this.lblDiaList.Name = "lblDiaList";
            this.lblDiaList.Size = new System.Drawing.Size(63, 12);
            this.lblDiaList.TabIndex = 5;
            this.lblDiaList.Text = "ダイヤ選択：";
            // 
            // tboxLineName
            // 
            this.tboxLineName.Location = new System.Drawing.Point(78, 12);
            this.tboxLineName.Name = "tboxLineName";
            this.tboxLineName.ReadOnly = true;
            this.tboxLineName.Size = new System.Drawing.Size(444, 19);
            this.tboxLineName.TabIndex = 6;
            // 
            // cboxDiaList
            // 
            this.cboxDiaList.FormattingEnabled = true;
            this.cboxDiaList.Location = new System.Drawing.Point(78, 41);
            this.cboxDiaList.Name = "cboxDiaList";
            this.cboxDiaList.Size = new System.Drawing.Size(255, 20);
            this.cboxDiaList.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(537, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "読み込み";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(363, 44);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(59, 12);
            this.lblFor.TabIndex = 11;
            this.lblFor.Text = "方向選択：";
            // 
            // cboxFor
            // 
            this.cboxFor.FormattingEnabled = true;
            this.cboxFor.Items.AddRange(new object[] {
            "下り",
            "上り"});
            this.cboxFor.Location = new System.Drawing.Point(428, 41);
            this.cboxFor.Name = "cboxFor";
            this.cboxFor.Size = new System.Drawing.Size(94, 20);
            this.cboxFor.TabIndex = 12;
            // 
            // pn_menu1
            // 
            this.pn_menu1.Controls.Add(this.tboxLineName);
            this.pn_menu1.Controls.Add(this.cboxFor);
            this.pn_menu1.Controls.Add(this.lblFor);
            this.pn_menu1.Controls.Add(this.btnLoad);
            this.pn_menu1.Controls.Add(this.lblLineInfo);
            this.pn_menu1.Controls.Add(this.cboxDiaList);
            this.pn_menu1.Controls.Add(this.lblDiaList);
            this.pn_menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu1.Location = new System.Drawing.Point(0, 0);
            this.pn_menu1.Name = "pn_menu1";
            this.pn_menu1.Size = new System.Drawing.Size(899, 77);
            this.pn_menu1.TabIndex = 13;
            // 
            // pn_menu2
            // 
            this.pn_menu2.Controls.Add(this.btnOpen);
            this.pn_menu2.Controls.Add(this.btnExit);
            this.pn_menu2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_menu2.Location = new System.Drawing.Point(905, 0);
            this.pn_menu2.Name = "pn_menu2";
            this.pn_menu2.Size = new System.Drawing.Size(103, 77);
            this.pn_menu2.TabIndex = 14;
            // 
            // frmRough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pn_menu2);
            this.Controls.Add(this.pn_menu1);
            this.Controls.Add(this.dgvDiagram);
            this.MaximizeBox = false;
            this.Name = "frmRough";
            this.Text = "A-TrAIns";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagram)).EndInit();
            this.pn_menu1.ResumeLayout(false);
            this.pn_menu1.PerformLayout();
            this.pn_menu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdOudia;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvDiagram;
        private System.Windows.Forms.Label lblLineInfo;
        private System.Windows.Forms.Label lblDiaList;
        private System.Windows.Forms.TextBox tboxLineName;
        private System.Windows.Forms.ComboBox cboxDiaList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.ComboBox cboxFor;
        private System.Windows.Forms.Panel pn_menu1;
        private System.Windows.Forms.Panel pn_menu2;
    }
}

