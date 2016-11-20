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
            this.btn_newfile = new System.Windows.Forms.Button();
            this.btn_saytrain = new System.Windows.Forms.Button();
            this.btn_saystation = new System.Windows.Forms.Button();
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
            this.btnOpen.Location = new System.Drawing.Point(16, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 67);
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
            this.dgvDiagram.Location = new System.Drawing.Point(0, 102);
            this.dgvDiagram.Name = "dgvDiagram";
            this.dgvDiagram.RowTemplate.Height = 21;
            this.dgvDiagram.Size = new System.Drawing.Size(1008, 627);
            this.dgvDiagram.TabIndex = 3;
            // 
            // lblLineInfo
            // 
            this.lblLineInfo.AutoSize = true;
            this.lblLineInfo.Location = new System.Drawing.Point(23, 15);
            this.lblLineInfo.Name = "lblLineInfo";
            this.lblLineInfo.Size = new System.Drawing.Size(47, 12);
            this.lblLineInfo.TabIndex = 4;
            this.lblLineInfo.Text = "路線名：";
            // 
            // lblDiaList
            // 
            this.lblDiaList.AutoSize = true;
            this.lblDiaList.Location = new System.Drawing.Point(7, 44);
            this.lblDiaList.Name = "lblDiaList";
            this.lblDiaList.Size = new System.Drawing.Size(63, 12);
            this.lblDiaList.TabIndex = 5;
            this.lblDiaList.Text = "ダイヤ選択：";
            // 
            // tboxLineName
            // 
            this.tboxLineName.Location = new System.Drawing.Point(76, 12);
            this.tboxLineName.Name = "tboxLineName";
            this.tboxLineName.ReadOnly = true;
            this.tboxLineName.Size = new System.Drawing.Size(444, 19);
            this.tboxLineName.TabIndex = 6;
            // 
            // cboxDiaList
            // 
            this.cboxDiaList.FormattingEnabled = true;
            this.cboxDiaList.Location = new System.Drawing.Point(76, 41);
            this.cboxDiaList.Name = "cboxDiaList";
            this.cboxDiaList.Size = new System.Drawing.Size(332, 20);
            this.cboxDiaList.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(414, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 51);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "読み込み";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(11, 73);
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
            this.cboxFor.Location = new System.Drawing.Point(76, 70);
            this.cboxFor.Name = "cboxFor";
            this.cboxFor.Size = new System.Drawing.Size(332, 20);
            this.cboxFor.TabIndex = 12;
            // 
            // pn_menu1
            // 
            this.pn_menu1.Controls.Add(this.btn_saystation);
            this.pn_menu1.Controls.Add(this.btn_saytrain);
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
            this.pn_menu1.Size = new System.Drawing.Size(899, 102);
            this.pn_menu1.TabIndex = 13;
            // 
            // pn_menu2
            // 
            this.pn_menu2.Controls.Add(this.btn_newfile);
            this.pn_menu2.Controls.Add(this.btnOpen);
            this.pn_menu2.Controls.Add(this.btnExit);
            this.pn_menu2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_menu2.Location = new System.Drawing.Point(905, 0);
            this.pn_menu2.Name = "pn_menu2";
            this.pn_menu2.Size = new System.Drawing.Size(103, 102);
            this.pn_menu2.TabIndex = 14;
            // 
            // btn_newfile
            // 
            this.btn_newfile.Enabled = false;
            this.btn_newfile.Location = new System.Drawing.Point(16, 8);
            this.btn_newfile.Name = "btn_newfile";
            this.btn_newfile.Size = new System.Drawing.Size(75, 23);
            this.btn_newfile.TabIndex = 15;
            this.btn_newfile.Text = "新規作成";
            this.btn_newfile.UseVisualStyleBackColor = true;
            // 
            // btn_saytrain
            // 
            this.btn_saytrain.Location = new System.Drawing.Point(582, 24);
            this.btn_saytrain.Name = "btn_saytrain";
            this.btn_saytrain.Size = new System.Drawing.Size(266, 23);
            this.btn_saytrain.TabIndex = 16;
            this.btn_saytrain.Text = "選択した列車のアナウンスを読む";
            this.btn_saytrain.UseVisualStyleBackColor = true;
            // 
            // btn_saystation
            // 
            this.btn_saystation.Location = new System.Drawing.Point(582, 52);
            this.btn_saystation.Name = "btn_saystation";
            this.btn_saystation.Size = new System.Drawing.Size(266, 23);
            this.btn_saystation.TabIndex = 17;
            this.btn_saystation.Text = "選択した駅のアナウンスを読む";
            this.btn_saystation.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btn_saystation;
        private System.Windows.Forms.Button btn_saytrain;
        private System.Windows.Forms.Button btn_newfile;
    }
}

