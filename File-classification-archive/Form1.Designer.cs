namespace 文件操作
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.dlg_penfile = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹路径";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(84, 10);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(321, 21);
            this.txt_path.TabIndex = 1;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(224, 47);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(63, 23);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "整理";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(411, 9);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(42, 21);
            this.btn_path.TabIndex = 3;
            this.btn_path.Text = "选择";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(459, 10);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(45, 21);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 82);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "文件分类存储";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.FolderBrowserDialog dlg_penfile;
    }
}

