namespace MagnetTrackerModifier
{
    partial class MegnetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MegnetForm));
            this.btnModify = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(655, 14);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(133, 163);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Generate";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(12, 12);
            this.textInput.MaxLength = 327671;
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(637, 165);
            this.textInput.TabIndex = 1;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(12, 208);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(637, 230);
            this.textOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(655, 208);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(133, 163);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelState.Location = new System.Drawing.Point(655, 423);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(69, 19);
            this.labelState.TabIndex = 5;
            this.labelState.Text = "label2";
            // 
            // MegnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.btnModify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MegnetForm";
            this.Text = "Magnet Tracker Modifer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label labelState;
    }
}

