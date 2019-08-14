namespace StringJudge
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtJudgeStr = new System.Windows.Forms.TextBox();
            this.txtStartInt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "JudgeString:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(14, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 447);
            this.lblResult.TabIndex = 4;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(72, 18);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(191, 21);
            this.txtSN.TabIndex = 5;
            this.txtSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSN_KeyDown);
            // 
            // txtJudgeStr
            // 
            this.txtJudgeStr.Location = new System.Drawing.Point(432, 56);
            this.txtJudgeStr.Name = "txtJudgeStr";
            this.txtJudgeStr.Size = new System.Drawing.Size(100, 21);
            this.txtJudgeStr.TabIndex = 8;
            // 
            // txtStartInt
            // 
            this.txtStartInt.Location = new System.Drawing.Point(432, 3);
            this.txtStartInt.Name = "txtStartInt";
            this.txtStartInt.Size = new System.Drawing.Size(100, 21);
            this.txtStartInt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "StartInt:";
            // 
            // txtEndInt
            // 
            this.txtEndInt.Location = new System.Drawing.Point(432, 29);
            this.txtEndInt.Name = "txtEndInt";
            this.txtEndInt.Size = new System.Drawing.Size(100, 21);
            this.txtEndInt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "EndInt:";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(639, 34);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 13;
            this.btnLock.Text = "锁定|解锁";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.txtEndInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJudgeStr);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "StringJudge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtJudgeStr;
        private System.Windows.Forms.TextBox txtStartInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLock;
    }
}

