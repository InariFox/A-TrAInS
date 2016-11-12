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
            this.lblStations = new System.Windows.Forms.Label();
            this.cboxStationList = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblFor = new System.Windows.Forms.Label();
            this.cboxFor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagram)).BeginInit();
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
            this.btnOpen.Location = new System.Drawing.Point(921, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(921, 41);
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
            this.dgvDiagram.Location = new System.Drawing.Point(12, 114);
            this.dgvDiagram.Name = "dgvDiagram";
            this.dgvDiagram.RowTemplate.Height = 21;
            this.dgvDiagram.Size = new System.Drawing.Size(984, 603);
            this.dgvDiagram.TabIndex = 3;
            // 
            // lblLineInfo
            // 
            this.lblLineInfo.AutoSize = true;
            this.lblLineInfo.Location = new System.Drawing.Point(28, 17);
            this.lblLineInfo.Name = "lblLineInfo";
            this.lblLineInfo.Size = new System.Drawing.Size(47, 12);
            this.lblLineInfo.TabIndex = 4;
            this.lblLineInfo.Text = "路線名：";
            // 
            // lblDiaList
            // 
            this.lblDiaList.AutoSize = true;
            this.lblDiaList.Location = new System.Drawing.Point(12, 46);
            this.lblDiaList.Name = "lblDiaList";
            this.lblDiaList.Size = new System.Drawing.Size(63, 12);
            this.lblDiaList.TabIndex = 5;
            this.lblDiaList.Text = "ダイヤ選択：";
            // 
            // tboxLineName
            // 
            this.tboxLineName.Location = new System.Drawing.Point(81, 14);
            this.tboxLineName.Name = "tboxLineName";
            this.tboxLineName.ReadOnly = true;
            this.tboxLineName.Size = new System.Drawing.Size(444, 19);
            this.tboxLineName.TabIndex = 6;
            // 
            // cboxDiaList
            // 
            this.cboxDiaList.FormattingEnabled = true;
            this.cboxDiaList.Location = new System.Drawing.Point(81, 43);
            this.cboxDiaList.Name = "cboxDiaList";
            this.cboxDiaList.Size = new System.Drawing.Size(255, 20);
            this.cboxDiaList.TabIndex = 7;
            // 
            // lblStations
            // 
            this.lblStations.AutoSize = true;
            this.lblStations.Location = new System.Drawing.Point(28, 81);
            this.lblStations.Name = "lblStations";
            this.lblStations.Size = new System.Drawing.Size(47, 12);
            this.lblStations.TabIndex = 8;
            this.lblStations.Text = "駅選択：";
            // 
            // cboxStationList
            // 
            this.cboxStationList.FormattingEnabled = true;
            this.cboxStationList.Location = new System.Drawing.Point(81, 78);
            this.cboxStationList.Name = "cboxStationList";
            this.cboxStationList.Size = new System.Drawing.Size(444, 20);
            this.cboxStationList.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(540, 76);
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
            this.lblFor.Location = new System.Drawing.Point(366, 46);
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
            this.cboxFor.Location = new System.Drawing.Point(431, 43);
            this.cboxFor.Name = "cboxFor";
            this.cboxFor.Size = new System.Drawing.Size(94, 20);
            this.cboxFor.TabIndex = 12;
            // 
            // frmRough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.cboxFor);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboxStationList);
            this.Controls.Add(this.lblStations);
            this.Controls.Add(this.cboxDiaList);
            this.Controls.Add(this.tboxLineName);
            this.Controls.Add(this.lblDiaList);
            this.Controls.Add(this.lblLineInfo);
            this.Controls.Add(this.dgvDiagram);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen);
            this.MaximizeBox = false;
            this.Name = "frmRough";
            this.Text = "A-TrAIns";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblStations;
        private System.Windows.Forms.ComboBox cboxStationList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.ComboBox cboxFor;
    }
}

