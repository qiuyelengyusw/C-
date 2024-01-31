namespace MDI窗体应用
{
    partial class frm1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.显示子窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.横向排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.总想排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示子窗体ToolStripMenuItem,
            this.横向排列ToolStripMenuItem,
            this.总想排列ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 显示子窗体ToolStripMenuItem
            // 
            this.显示子窗体ToolStripMenuItem.Name = "显示子窗体ToolStripMenuItem";
            this.显示子窗体ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.显示子窗体ToolStripMenuItem.Text = "显示子窗体";
            this.显示子窗体ToolStripMenuItem.Click += new System.EventHandler(this.显示子窗体ToolStripMenuItem_Click);
            // 
            // 横向排列ToolStripMenuItem
            // 
            this.横向排列ToolStripMenuItem.Name = "横向排列ToolStripMenuItem";
            this.横向排列ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.横向排列ToolStripMenuItem.Text = "横向排列";
            this.横向排列ToolStripMenuItem.Click += new System.EventHandler(this.横向排列ToolStripMenuItem_Click);
            // 
            // 总想排列ToolStripMenuItem
            // 
            this.总想排列ToolStripMenuItem.Name = "总想排列ToolStripMenuItem";
            this.总想排列ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.总想排列ToolStripMenuItem.Text = "总想排列";
            this.总想排列ToolStripMenuItem.Click += new System.EventHandler(this.总想排列ToolStripMenuItem_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1190, 812);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示子窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 横向排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 总想排列ToolStripMenuItem;
    }
}

