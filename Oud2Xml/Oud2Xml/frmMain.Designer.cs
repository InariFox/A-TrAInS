namespace Oud2Xml
{
    partial class frmMain
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
            this.tbox = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.btnConv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox
            // 
            this.tbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbox.Location = new System.Drawing.Point(0, 319);
            this.tbox.Multiline = true;
            this.tbox.Name = "tbox";
            this.tbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox.Size = new System.Drawing.Size(784, 242);
            this.tbox.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lbox1
            // 
            this.lbox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbox1.FormattingEnabled = true;
            this.lbox1.ItemHeight = 12;
            this.lbox1.Location = new System.Drawing.Point(0, 75);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(784, 244);
            this.lbox1.TabIndex = 3;
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(12, 41);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(75, 23);
            this.btnConv.TabIndex = 4;
            this.btnConv.Text = "convert";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnConv);
            this.Controls.Add(this.lbox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Oud2Xml";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ListBox lbox1;
        private System.Windows.Forms.Button btnConv;
    }
}

