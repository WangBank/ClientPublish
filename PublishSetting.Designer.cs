namespace 自动发布dll程序
{
    partial class PublishSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.localtionSetting = new System.Windows.Forms.DataGridView();
            this.pathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ensureBtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.MainVersiontxt = new System.Windows.Forms.TextBox();
            this.MaxSubVersiontxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinSubVersiontxt = new System.Windows.Forms.TextBox();
            this.currentlabel = new System.Windows.Forms.Label();
            this.nowsublabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localtionSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // localtionSetting
            // 
            this.localtionSetting.AllowDrop = true;
            this.localtionSetting.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.localtionSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localtionSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathName,
            this.PathLocation});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localtionSetting.DefaultCellStyle = dataGridViewCellStyle1;
            this.localtionSetting.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.localtionSetting.Location = new System.Drawing.Point(12, 12);
            this.localtionSetting.Name = "localtionSetting";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.localtionSetting.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.localtionSetting.RowTemplate.Height = 23;
            this.localtionSetting.Size = new System.Drawing.Size(446, 251);
            this.localtionSetting.TabIndex = 0;
            // 
            // pathName
            // 
            this.pathName.HeaderText = "描述";
            this.pathName.Name = "pathName";
            // 
            // PathLocation
            // 
            this.PathLocation.HeaderText = "位置";
            this.PathLocation.Name = "PathLocation";
            this.PathLocation.Width = 300;
            // 
            // ensureBtn
            // 
            this.ensureBtn.Location = new System.Drawing.Point(584, 239);
            this.ensureBtn.Name = "ensureBtn";
            this.ensureBtn.Size = new System.Drawing.Size(75, 23);
            this.ensureBtn.TabIndex = 1;
            this.ensureBtn.Text = "保存";
            this.ensureBtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(488, 239);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // MainVersiontxt
            // 
            this.MainVersiontxt.Location = new System.Drawing.Point(575, 34);
            this.MainVersiontxt.Name = "MainVersiontxt";
            this.MainVersiontxt.Size = new System.Drawing.Size(59, 21);
            this.MainVersiontxt.TabIndex = 3;
            // 
            // MaxSubVersiontxt
            // 
            this.MaxSubVersiontxt.Location = new System.Drawing.Point(577, 157);
            this.MaxSubVersiontxt.Name = "MaxSubVersiontxt";
            this.MaxSubVersiontxt.Size = new System.Drawing.Size(59, 21);
            this.MaxSubVersiontxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "主版本号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "次版本最大值:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "次版本最小值:";
            // 
            // MinSubVersiontxt
            // 
            this.MinSubVersiontxt.Location = new System.Drawing.Point(575, 95);
            this.MinSubVersiontxt.Name = "MinSubVersiontxt";
            this.MinSubVersiontxt.Size = new System.Drawing.Size(59, 21);
            this.MinSubVersiontxt.TabIndex = 7;
            // 
            // currentlabel
            // 
            this.currentlabel.AutoSize = true;
            this.currentlabel.Location = new System.Drawing.Point(488, 194);
            this.currentlabel.Name = "currentlabel";
            this.currentlabel.Size = new System.Drawing.Size(41, 12);
            this.currentlabel.TabIndex = 9;
            this.currentlabel.Text = "label4";
            this.currentlabel.Visible = false;
            // 
            // nowsublabel
            // 
            this.nowsublabel.AutoSize = true;
            this.nowsublabel.Location = new System.Drawing.Point(573, 194);
            this.nowsublabel.Name = "nowsublabel";
            this.nowsublabel.Size = new System.Drawing.Size(41, 12);
            this.nowsublabel.TabIndex = 10;
            this.nowsublabel.Text = "label4";
            this.nowsublabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "双击\"位置\"下面可以选择文件夹，请选择包含\"bin\"与\"UpdateFiles\"子文件夹的文件夹";
            // 
            // PublishSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nowsublabel);
            this.Controls.Add(this.currentlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinSubVersiontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxSubVersiontxt);
            this.Controls.Add(this.MainVersiontxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.ensureBtn);
            this.Controls.Add(this.localtionSetting);
            this.Name = "PublishSetting";
            this.Text = "发布信息设置";
            ((System.ComponentModel.ISupportInitialize)(this.localtionSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView localtionSetting;
        private System.Windows.Forms.Button ensureBtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox MainVersiontxt;
        private System.Windows.Forms.TextBox MaxSubVersiontxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinSubVersiontxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathLocation;
        private System.Windows.Forms.Label currentlabel;
        private System.Windows.Forms.Label nowsublabel;
        private System.Windows.Forms.Label label4;
    }
}