namespace A_TrAInS
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.stripMain = new System.Windows.Forms.MenuStrip();
            this.stripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.stripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sCmain = new System.Windows.Forms.SplitContainer();
            this.sCDg = new System.Windows.Forms.SplitContainer();
            this.cboxDgList = new System.Windows.Forms.ComboBox();
            this.dgvDg = new System.Windows.Forms.DataGridView();
            this.btnSettingText = new System.Windows.Forms.Button();
            this.btnSettingStation = new System.Windows.Forms.Button();
            this.lblPn2Option = new System.Windows.Forms.Label();
            this.btnPlayAnnounce = new System.Windows.Forms.Button();
            this.rbtnTrain = new System.Windows.Forms.RadioButton();
            this.rbtnStation = new System.Windows.Forms.RadioButton();
            this.lblPn2Head = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.stripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCmain)).BeginInit();
            this.sCmain.Panel1.SuspendLayout();
            this.sCmain.Panel2.SuspendLayout();
            this.sCmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCDg)).BeginInit();
            this.sCDg.Panel1.SuspendLayout();
            this.sCDg.Panel2.SuspendLayout();
            this.sCDg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDg)).BeginInit();
            this.SuspendLayout();
            // 
            // stripMain
            // 
            this.stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemFile,
            this.stripMenuItemHelp});
            this.stripMain.Location = new System.Drawing.Point(0, 0);
            this.stripMain.Name = "stripMain";
            this.stripMain.Size = new System.Drawing.Size(1008, 25);
            this.stripMain.TabIndex = 0;
            this.stripMain.Text = "menuStrip1";
            // 
            // stripItemFile
            // 
            this.stripItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuItemNew,
            this.stripMenuItemOpen,
            this.toolStripSeparator,
            this.stripMenuItemSave,
            this.stripMenuItemRename,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.stripMenuItemExit});
            this.stripItemFile.Name = "stripItemFile";
            this.stripItemFile.Size = new System.Drawing.Size(80, 21);
            this.stripItemFile.Text = "ファイル(&F)";
            // 
            // stripMenuItemNew
            // 
            this.stripMenuItemNew.Enabled = false;
            this.stripMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("stripMenuItemNew.Image")));
            this.stripMenuItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripMenuItemNew.Name = "stripMenuItemNew";
            this.stripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.stripMenuItemNew.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemNew.Text = "新規作成(&N)";
            // 
            // stripMenuItemOpen
            // 
            this.stripMenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("stripMenuItemOpen.Image")));
            this.stripMenuItemOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripMenuItemOpen.Name = "stripMenuItemOpen";
            this.stripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.stripMenuItemOpen.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemOpen.Text = "開く(&O)";
            this.stripMenuItemOpen.Click += new System.EventHandler(this.stripMenuItemOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(188, 6);
            // 
            // stripMenuItemSave
            // 
            this.stripMenuItemSave.Enabled = false;
            this.stripMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("stripMenuItemSave.Image")));
            this.stripMenuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripMenuItemSave.Name = "stripMenuItemSave";
            this.stripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stripMenuItemSave.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemSave.Text = "上書き保存(&S)";
            // 
            // stripMenuItemRename
            // 
            this.stripMenuItemRename.Enabled = false;
            this.stripMenuItemRename.Name = "stripMenuItemRename";
            this.stripMenuItemRename.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemRename.Text = "名前を付けて保存(&A)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem1.Text = "オプション(&O)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // stripMenuItemExit
            // 
            this.stripMenuItemExit.Name = "stripMenuItemExit";
            this.stripMenuItemExit.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemExit.Text = "終了(&X)";
            this.stripMenuItemExit.Click += new System.EventHandler(this.stripMenuItemExit_Click);
            // 
            // stripMenuItemHelp
            // 
            this.stripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemHelp,
            this.stripMenuItemAbout});
            this.stripMenuItemHelp.Name = "stripMenuItemHelp";
            this.stripMenuItemHelp.Size = new System.Drawing.Size(71, 21);
            this.stripMenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // stripItemHelp
            // 
            this.stripItemHelp.Enabled = false;
            this.stripItemHelp.Name = "stripItemHelp";
            this.stripItemHelp.Size = new System.Drawing.Size(182, 22);
            this.stripItemHelp.Text = "ヘルプ(&H)";
            // 
            // stripMenuItemAbout
            // 
            this.stripMenuItemAbout.Name = "stripMenuItemAbout";
            this.stripMenuItemAbout.Size = new System.Drawing.Size(182, 22);
            this.stripMenuItemAbout.Text = "バージョン情報(&A)...";
            // 
            // sCmain
            // 
            this.sCmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCmain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sCmain.IsSplitterFixed = true;
            this.sCmain.Location = new System.Drawing.Point(0, 25);
            this.sCmain.Name = "sCmain";
            // 
            // sCmain.Panel1
            // 
            this.sCmain.Panel1.Controls.Add(this.sCDg);
            // 
            // sCmain.Panel2
            // 
            this.sCmain.Panel2.Controls.Add(this.btnSettingText);
            this.sCmain.Panel2.Controls.Add(this.btnSettingStation);
            this.sCmain.Panel2.Controls.Add(this.lblPn2Option);
            this.sCmain.Panel2.Controls.Add(this.btnPlayAnnounce);
            this.sCmain.Panel2.Controls.Add(this.rbtnTrain);
            this.sCmain.Panel2.Controls.Add(this.rbtnStation);
            this.sCmain.Panel2.Controls.Add(this.lblPn2Head);
            this.sCmain.Size = new System.Drawing.Size(1008, 704);
            this.sCmain.SplitterDistance = 800;
            this.sCmain.TabIndex = 1;
            // 
            // sCDg
            // 
            this.sCDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCDg.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sCDg.IsSplitterFixed = true;
            this.sCDg.Location = new System.Drawing.Point(0, 0);
            this.sCDg.Name = "sCDg";
            this.sCDg.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCDg.Panel1
            // 
            this.sCDg.Panel1.Controls.Add(this.cboxDgList);
            // 
            // sCDg.Panel2
            // 
            this.sCDg.Panel2.Controls.Add(this.dgvDg);
            this.sCDg.Size = new System.Drawing.Size(800, 704);
            this.sCDg.SplitterDistance = 25;
            this.sCDg.TabIndex = 0;
            // 
            // cboxDgList
            // 
            this.cboxDgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxDgList.FormattingEnabled = true;
            this.cboxDgList.Location = new System.Drawing.Point(0, 0);
            this.cboxDgList.Name = "cboxDgList";
            this.cboxDgList.Size = new System.Drawing.Size(800, 20);
            this.cboxDgList.TabIndex = 0;
            // 
            // dgvDg
            // 
            this.dgvDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDg.Location = new System.Drawing.Point(0, 0);
            this.dgvDg.Name = "dgvDg";
            this.dgvDg.RowTemplate.Height = 21;
            this.dgvDg.Size = new System.Drawing.Size(800, 675);
            this.dgvDg.TabIndex = 0;
            // 
            // btnSettingText
            // 
            this.btnSettingText.Location = new System.Drawing.Point(2, 39);
            this.btnSettingText.Name = "btnSettingText";
            this.btnSettingText.Size = new System.Drawing.Size(199, 30);
            this.btnSettingText.TabIndex = 9;
            this.btnSettingText.Text = "アナウンス設定";
            this.btnSettingText.UseVisualStyleBackColor = true;
            // 
            // btnSettingStation
            // 
            this.btnSettingStation.Location = new System.Drawing.Point(2, 3);
            this.btnSettingStation.Name = "btnSettingStation";
            this.btnSettingStation.Size = new System.Drawing.Size(199, 30);
            this.btnSettingStation.TabIndex = 8;
            this.btnSettingStation.Text = "駅設定";
            this.btnSettingStation.UseVisualStyleBackColor = true;
            // 
            // lblPn2Option
            // 
            this.lblPn2Option.AutoSize = true;
            this.lblPn2Option.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPn2Option.Location = new System.Drawing.Point(2, 148);
            this.lblPn2Option.Name = "lblPn2Option";
            this.lblPn2Option.Size = new System.Drawing.Size(60, 15);
            this.lblPn2Option.TabIndex = 7;
            this.lblPn2Option.Text = "オプション";
            // 
            // btnPlayAnnounce
            // 
            this.btnPlayAnnounce.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlayAnnounce.Location = new System.Drawing.Point(2, 661);
            this.btnPlayAnnounce.Name = "btnPlayAnnounce";
            this.btnPlayAnnounce.Size = new System.Drawing.Size(202, 40);
            this.btnPlayAnnounce.TabIndex = 5;
            this.btnPlayAnnounce.Text = "読み上げ";
            this.btnPlayAnnounce.UseVisualStyleBackColor = true;
            // 
            // rbtnTrain
            // 
            this.rbtnTrain.AutoSize = true;
            this.rbtnTrain.Location = new System.Drawing.Point(7, 124);
            this.rbtnTrain.Name = "rbtnTrain";
            this.rbtnTrain.Size = new System.Drawing.Size(138, 16);
            this.rbtnTrain.TabIndex = 4;
            this.rbtnTrain.Text = "車内アナウンス読み上げ";
            this.rbtnTrain.UseVisualStyleBackColor = true;
            // 
            // rbtnStation
            // 
            this.rbtnStation.AutoSize = true;
            this.rbtnStation.Checked = true;
            this.rbtnStation.Location = new System.Drawing.Point(7, 102);
            this.rbtnStation.Name = "rbtnStation";
            this.rbtnStation.Size = new System.Drawing.Size(126, 16);
            this.rbtnStation.TabIndex = 2;
            this.rbtnStation.TabStop = true;
            this.rbtnStation.Text = "駅アナウンス読み上げ";
            this.rbtnStation.UseVisualStyleBackColor = true;
            // 
            // lblPn2Head
            // 
            this.lblPn2Head.AutoSize = true;
            this.lblPn2Head.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPn2Head.Location = new System.Drawing.Point(3, 77);
            this.lblPn2Head.Name = "lblPn2Head";
            this.lblPn2Head.Size = new System.Drawing.Size(92, 15);
            this.lblPn2Head.TabIndex = 1;
            this.lblPn2Head.Text = "読み上げ設定";
            // 
            // ofd
            // 
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.sCmain);
            this.Controls.Add(this.stripMain);
            this.MainMenuStrip = this.stripMain;
            this.Name = "mainWindow";
            this.Text = "A-TrAInS";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.stripMain.ResumeLayout(false);
            this.stripMain.PerformLayout();
            this.sCmain.Panel1.ResumeLayout(false);
            this.sCmain.Panel2.ResumeLayout(false);
            this.sCmain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCmain)).EndInit();
            this.sCmain.ResumeLayout(false);
            this.sCDg.Panel1.ResumeLayout(false);
            this.sCDg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCDg)).EndInit();
            this.sCDg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stripMain;
        private System.Windows.Forms.ToolStripMenuItem stripItemFile;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem stripItemHelp;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemAbout;
        private System.Windows.Forms.SplitContainer sCmain;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnPlayAnnounce;
        private System.Windows.Forms.RadioButton rbtnTrain;
        private System.Windows.Forms.RadioButton rbtnStation;
        private System.Windows.Forms.Label lblPn2Head;
        private System.Windows.Forms.Label lblPn2Option;
        private System.Windows.Forms.SplitContainer sCDg;
        private System.Windows.Forms.ComboBox cboxDgList;
        private System.Windows.Forms.DataGridView dgvDg;
        private System.Windows.Forms.Button btnSettingText;
        private System.Windows.Forms.Button btnSettingStation;
    }
}

