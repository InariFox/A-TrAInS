namespace A_TrAIns
{
    partial class frmSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSender));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lboxAnnounce = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTarget = new System.Windows.Forms.Label();
            this.rBtnYukari = new System.Windows.Forms.RadioButton();
            this.rBtnBouyomi = new System.Windows.Forms.RadioButton();
            this.pnlControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.panel1);
            this.pnlControl.Controls.Add(this.button1);
            this.pnlControl.Controls.Add(this.btnNext);
            this.pnlControl.Controls.Add(this.btnPlay);
            this.pnlControl.Controls.Add(this.btnExit);
            resources.ApplyResources(this.pnlControl, "pnlControl");
            this.pnlControl.Name = "pnlControl";
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lboxAnnounce
            // 
            resources.ApplyResources(this.lboxAnnounce, "lboxAnnounce");
            this.lboxAnnounce.FormattingEnabled = true;
            this.lboxAnnounce.Name = "lboxAnnounce";
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnBouyomi);
            this.panel1.Controls.Add(this.rBtnYukari);
            this.panel1.Controls.Add(this.lblTarget);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblTarget
            // 
            resources.ApplyResources(this.lblTarget, "lblTarget");
            this.lblTarget.Name = "lblTarget";
            // 
            // rBtnYukari
            // 
            resources.ApplyResources(this.rBtnYukari, "rBtnYukari");
            this.rBtnYukari.Name = "rBtnYukari";
            this.rBtnYukari.TabStop = true;
            this.rBtnYukari.UseVisualStyleBackColor = true;
            // 
            // rBtnBouyomi
            // 
            resources.ApplyResources(this.rBtnBouyomi, "rBtnBouyomi");
            this.rBtnBouyomi.Name = "rBtnBouyomi";
            this.rBtnBouyomi.TabStop = true;
            this.rBtnBouyomi.UseVisualStyleBackColor = true;
            // 
            // frmSender
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lboxAnnounce);
            this.Controls.Add(this.pnlControl);
            this.Name = "frmSender";
            this.Load += new System.EventHandler(this.frmSender_Load);
            this.pnlControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lboxAnnounce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtnBouyomi;
        private System.Windows.Forms.RadioButton rBtnYukari;
        private System.Windows.Forms.Label lblTarget;
    }
}