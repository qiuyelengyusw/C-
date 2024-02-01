namespace 进程
{
    partial class Form1
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
            this.buta = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buta
            // 
            this.buta.Location = new System.Drawing.Point(103, 85);
            this.buta.Name = "buta";
            this.buta.Size = new System.Drawing.Size(106, 23);
            this.buta.TabIndex = 0;
            this.buta.Text = "打开系统程序";
            this.buta.UseVisualStyleBackColor = true;
            this.buta.Click += new System.EventHandler(this.buta_Click_1);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(347, 85);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(94, 23);
            this.but2.TabIndex = 1;
            this.but2.Text = "打开指定文件";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 209);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.buta);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buta;
        private System.Windows.Forms.Button but2;
    }
}

