namespace A._2_动物运动会
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
            this.猫叫 = new System.Windows.Forms.Button();
            this.狗叫 = new System.Windows.Forms.Button();
            this.动物报名 = new System.Windows.Forms.Button();
            this.叫声比赛 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 猫叫
            // 
            this.猫叫.Location = new System.Drawing.Point(199, 132);
            this.猫叫.Name = "猫叫";
            this.猫叫.Size = new System.Drawing.Size(111, 56);
            this.猫叫.TabIndex = 0;
            this.猫叫.Text = "猫叫";
            this.猫叫.UseVisualStyleBackColor = true;
            this.猫叫.Click += new System.EventHandler(this.猫叫_Click);
            // 
            // 狗叫
            // 
            this.狗叫.Location = new System.Drawing.Point(497, 132);
            this.狗叫.Name = "狗叫";
            this.狗叫.Size = new System.Drawing.Size(111, 52);
            this.狗叫.TabIndex = 1;
            this.狗叫.Text = "狗叫";
            this.狗叫.UseVisualStyleBackColor = true;
            this.狗叫.Click += new System.EventHandler(this.狗叫_Click);
            // 
            // 动物报名
            // 
            this.动物报名.Location = new System.Drawing.Point(199, 239);
            this.动物报名.Name = "动物报名";
            this.动物报名.Size = new System.Drawing.Size(111, 50);
            this.动物报名.TabIndex = 2;
            this.动物报名.Text = "动物报名";
            this.动物报名.UseVisualStyleBackColor = true;
            this.动物报名.Click += new System.EventHandler(this.动物报名_Click);
            // 
            // 叫声比赛
            // 
            this.叫声比赛.Location = new System.Drawing.Point(497, 239);
            this.叫声比赛.Name = "叫声比赛";
            this.叫声比赛.Size = new System.Drawing.Size(111, 50);
            this.叫声比赛.TabIndex = 3;
            this.叫声比赛.Text = "叫声比赛";
            this.叫声比赛.UseVisualStyleBackColor = true;
            this.叫声比赛.Click += new System.EventHandler(this.叫声比赛_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.叫声比赛);
            this.Controls.Add(this.动物报名);
            this.Controls.Add(this.狗叫);
            this.Controls.Add(this.猫叫);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 猫叫;
        private System.Windows.Forms.Button 狗叫;
        private System.Windows.Forms.Button 动物报名;
        private System.Windows.Forms.Button 叫声比赛;
    }
}

