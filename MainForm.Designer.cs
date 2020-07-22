namespace 自动发布dll程序
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editionLbl = new System.Windows.Forms.Label();
            this.publishBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bdCountLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "雨诺客户端文件发布工具";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本：";
            // 
            // editionLbl
            // 
            this.editionLbl.AutoSize = true;
            this.editionLbl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editionLbl.ForeColor = System.Drawing.Color.Red;
            this.editionLbl.Location = new System.Drawing.Point(91, 158);
            this.editionLbl.Name = "editionLbl";
            this.editionLbl.Size = new System.Drawing.Size(35, 14);
            this.editionLbl.TabIndex = 2;
            this.editionLbl.Text = "14.1";
            // 
            // publishBtn
            // 
            this.publishBtn.Location = new System.Drawing.Point(296, 162);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(112, 41);
            this.publishBtn.TabIndex = 3;
            this.publishBtn.Text = "发布";
            this.publishBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(414, 162);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 41);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // bdCountLbl
            // 
            this.bdCountLbl.AutoSize = true;
            this.bdCountLbl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bdCountLbl.ForeColor = System.Drawing.Color.Red;
            this.bdCountLbl.Location = new System.Drawing.Point(96, 185);
            this.bdCountLbl.Name = "bdCountLbl";
            this.bdCountLbl.Size = new System.Drawing.Size(28, 14);
            this.bdCountLbl.TabIndex = 6;
            this.bdCountLbl.Text = "5个";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "补丁文件：";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.toolStripSeparator1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "系统";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置ToolStripMenuItem.Text = "发布设置";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(13, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "发布之前，请将文件拷到目录下的UpdateFiles文件夹中";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bdCountLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.editionLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "雨诺客户端文件发布工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label editionLbl;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label bdCountLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
    }
}

