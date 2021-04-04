
namespace RRQMXML
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
            this.testGenerateXmlBtn = new System.Windows.Forms.Button();
            this.testReadXmlBtn = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testGenerateXmlBtn
            // 
            this.testGenerateXmlBtn.Location = new System.Drawing.Point(28, 21);
            this.testGenerateXmlBtn.Name = "testGenerateXmlBtn";
            this.testGenerateXmlBtn.Size = new System.Drawing.Size(95, 23);
            this.testGenerateXmlBtn.TabIndex = 0;
            this.testGenerateXmlBtn.Text = "测试生成XML";
            this.testGenerateXmlBtn.UseVisualStyleBackColor = true;
            this.testGenerateXmlBtn.Click += new System.EventHandler(this.testGenerateXmlBtn_Click);
            // 
            // testReadXmlBtn
            // 
            this.testReadXmlBtn.Location = new System.Drawing.Point(169, 21);
            this.testReadXmlBtn.Name = "testReadXmlBtn";
            this.testReadXmlBtn.Size = new System.Drawing.Size(95, 23);
            this.testReadXmlBtn.TabIndex = 1;
            this.testReadXmlBtn.Text = "测试读取XML";
            this.testReadXmlBtn.UseVisualStyleBackColor = true;
            this.testReadXmlBtn.Click += new System.EventHandler(this.testReadXmlBtn_Click);
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(28, 50);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(258, 212);
            this.txtXML.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 274);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.testReadXmlBtn);
            this.Controls.Add(this.testGenerateXmlBtn);
            this.Name = "Form1";
            this.Text = "RRQMXML实例";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testGenerateXmlBtn;
        private System.Windows.Forms.Button testReadXmlBtn;
        private System.Windows.Forms.TextBox txtXML;
    }
}

