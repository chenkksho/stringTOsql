namespace stringTOsql
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
            this.sourTxt = new System.Windows.Forms.RichTextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourTxt
            // 
            this.sourTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.sourTxt.Location = new System.Drawing.Point(0, 0);
            this.sourTxt.Name = "sourTxt";
            this.sourTxt.Size = new System.Drawing.Size(638, 395);
            this.sourTxt.TabIndex = 0;
            this.sourTxt.Text = "";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(33, 412);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(184, 46);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "替换";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 480);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.sourTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox sourTxt;
        private System.Windows.Forms.Button btnChange;
    }
}

