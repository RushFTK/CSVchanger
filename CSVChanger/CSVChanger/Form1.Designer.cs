namespace CSVChanger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenSrcFile = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenDestFile = new System.Windows.Forms.FolderBrowserDialog();
            this.SrcPath = new System.Windows.Forms.TextBox();
            this.DestPath = new System.Windows.Forms.TextBox();
            this.SelectSrc = new System.Windows.Forms.Button();
            this.SelectDest = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标CSV";
            // 
            // SrcPath
            // 
            this.SrcPath.Location = new System.Drawing.Point(106, 16);
            this.SrcPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SrcPath.Name = "SrcPath";
            this.SrcPath.Size = new System.Drawing.Size(346, 27);
            this.SrcPath.TabIndex = 2;
            // 
            // DestPath
            // 
            this.DestPath.Location = new System.Drawing.Point(106, 60);
            this.DestPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DestPath.Name = "DestPath";
            this.DestPath.Size = new System.Drawing.Size(346, 27);
            this.DestPath.TabIndex = 3;
            // 
            // SelectSrc
            // 
            this.SelectSrc.Location = new System.Drawing.Point(459, 15);
            this.SelectSrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectSrc.Name = "SelectSrc";
            this.SelectSrc.Size = new System.Drawing.Size(124, 31);
            this.SelectSrc.TabIndex = 4;
            this.SelectSrc.Text = "选择文件...";
            this.SelectSrc.UseVisualStyleBackColor = true;
            // 
            // SelectDest
            // 
            this.SelectDest.Location = new System.Drawing.Point(459, 58);
            this.SelectDest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectDest.Name = "SelectDest";
            this.SelectDest.Size = new System.Drawing.Size(124, 31);
            this.SelectDest.TabIndex = 5;
            this.SelectDest.Text = "选择文件...";
            this.SelectDest.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "转换";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 147);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SelectDest);
            this.Controls.Add(this.SelectSrc);
            this.Controls.Add(this.DestPath);
            this.Controls.Add(this.SrcPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "平凡项集转换为CSV表格";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog OpenSrcFile;
        private System.Windows.Forms.FolderBrowserDialog OpenDestFile;
        private System.Windows.Forms.TextBox SrcPath;
        private System.Windows.Forms.TextBox DestPath;
        private System.Windows.Forms.Button SelectSrc;
        private System.Windows.Forms.Button SelectDest;
        private System.Windows.Forms.Button button3;
    }
}

