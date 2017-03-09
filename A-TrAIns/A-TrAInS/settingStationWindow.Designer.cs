namespace A_TrAInS
{
    partial class settingStationWindow
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
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlCanPlay = new System.Windows.Forms.Panel();
            this.cboxRead = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.pnlCanPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStations
            // 
            this.dgvStations.AllowUserToAddRows = false;
            this.dgvStations.AllowUserToDeleteRows = false;
            this.dgvStations.AllowUserToResizeRows = false;
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.ColumnHeadersVisible = false;
            this.dgvStations.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStations.Location = new System.Drawing.Point(0, 0);
            this.dgvStations.MultiSelect = false;
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            this.dgvStations.RowHeadersVisible = false;
            this.dgvStations.RowTemplate.Height = 21;
            this.dgvStations.Size = new System.Drawing.Size(384, 385);
            this.dgvStations.TabIndex = 0;
            this.dgvStations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStations_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(256, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 66);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(174, 48);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(71, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "適用";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pnlCanPlay
            // 
            this.pnlCanPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanPlay.Controls.Add(this.cboxRead);
            this.pnlCanPlay.Controls.Add(this.btnAccept);
            this.pnlCanPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCanPlay.Location = new System.Drawing.Point(0, 385);
            this.pnlCanPlay.Name = "pnlCanPlay";
            this.pnlCanPlay.Size = new System.Drawing.Size(250, 76);
            this.pnlCanPlay.TabIndex = 2;
            // 
            // cboxRead
            // 
            this.cboxRead.AutoSize = true;
            this.cboxRead.Location = new System.Drawing.Point(11, 5);
            this.cboxRead.Name = "cboxRead";
            this.cboxRead.Size = new System.Drawing.Size(78, 16);
            this.cboxRead.TabIndex = 3;
            this.cboxRead.Text = "読み上げる";
            this.cboxRead.UseVisualStyleBackColor = true;
            // 
            // settingStationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlCanPlay);
            this.Controls.Add(this.dgvStations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingStationWindow";
            this.Text = "駅設定";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.pnlCanPlay.ResumeLayout(false);
            this.pnlCanPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel pnlCanPlay;
        private System.Windows.Forms.CheckBox cboxRead;
    }
}