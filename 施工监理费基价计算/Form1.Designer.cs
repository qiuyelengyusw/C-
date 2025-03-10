namespace 施工监理费基价计算
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGczj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJlf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZKl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(129, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "工程造价（万元）:";
            // 
            // txtGczj
            // 
            this.txtGczj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGczj.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGczj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtGczj.Location = new System.Drawing.Point(465, 60);
            this.txtGczj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGczj.Multiline = true;
            this.txtGczj.Name = "txtGczj";
            this.txtGczj.Size = new System.Drawing.Size(247, 45);
            this.txtGczj.TabIndex = 0;
            this.txtGczj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGczj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGczj_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(93, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "监理费基价（万元）:";
            // 
            // txtJlf
            // 
            this.txtJlf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJlf.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJlf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtJlf.Location = new System.Drawing.Point(465, 154);
            this.txtJlf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJlf.Multiline = true;
            this.txtJlf.Name = "txtJlf";
            this.txtJlf.ReadOnly = true;
            this.txtJlf.Size = new System.Drawing.Size(247, 45);
            this.txtJlf.TabIndex = 1;
            this.txtJlf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(33, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "折  前   计   算";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butclear
            // 
            this.butclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butclear.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butclear.ForeColor = System.Drawing.Color.Red;
            this.butclear.Location = new System.Drawing.Point(757, 60);
            this.butclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butclear.Name = "butclear";
            this.butclear.Size = new System.Drawing.Size(123, 320);
            this.butclear.TabIndex = 3;
            this.butclear.Text = "清\r\n\r\n除";
            this.butclear.UseVisualStyleBackColor = false;
            this.butclear.Click += new System.EventHandler(this.butclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(246, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "折扣率(%):";
            // 
            // txtZKl
            // 
            this.txtZKl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZKl.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZKl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtZKl.Location = new System.Drawing.Point(465, 242);
            this.txtZKl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZKl.MaxLength = 4;
            this.txtZKl.Multiline = true;
            this.txtZKl.Name = "txtZKl";
            this.txtZKl.Size = new System.Drawing.Size(247, 45);
            this.txtZKl.TabIndex = 2;
            this.txtZKl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZKl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtZKl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZK_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(24, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "折后监理费基价（万元）:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtZK
            // 
            this.txtZK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZK.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtZK.Location = new System.Drawing.Point(465, 334);
            this.txtZK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZK.Multiline = true;
            this.txtZK.Name = "txtZK";
            this.txtZK.ReadOnly = true;
            this.txtZK.Size = new System.Drawing.Size(247, 45);
            this.txtZK.TabIndex = 1;
            this.txtZK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(471, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(411, 108);
            this.button2.TabIndex = 2;
            this.button2.Text = "折   扣   计   算";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(918, 564);
            this.Controls.Add(this.butclear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtZK);
            this.Controls.Add(this.txtJlf);
            this.Controls.Add(this.txtZKl);
            this.Controls.Add(this.txtGczj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "施工监理费基价计算";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGczj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJlf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZKl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZK;
        private System.Windows.Forms.Button button2;
    }
}

