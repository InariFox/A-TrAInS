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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCmain = new System.Windows.Forms.SplitContainer();
            this.stripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCmain)).BeginInit();
            this.sCmain.SuspendLayout();
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
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(188, 6);
            // 
            // stripMenuItemSave
            // 
            this.stripMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("stripMenuItemSave.Image")));
            this.stripMenuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripMenuItemSave.Name = "stripMenuItemSave";
            this.stripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stripMenuItemSave.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemSave.Text = "上書き保存(&S)";
            // 
            // stripMenuItemRename
            // 
            this.stripMenuItemRename.Name = "stripMenuItemRename";
            this.stripMenuItemRename.Size = new System.Drawing.Size(191, 22);
            this.stripMenuItemRename.Text = "名前を付けて保存(&A)";
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem1.Text = "オプション(&O)";
            // 
            // sCmain
            // 
            this.sCmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCmain.Location = new System.Drawing.Point(0, 25);
            this.sCmain.Name = "sCmain";
            this.sCmain.Size = new System.Drawing.Size(1008, 704);
            this.sCmain.SplitterDistance = 800;
            this.sCmain.TabIndex = 1;
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
            this.stripMain.ResumeLayout(false);
            this.stripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCmain)).EndInit();
            this.sCmain.ResumeLayout(false);
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
    }
}

