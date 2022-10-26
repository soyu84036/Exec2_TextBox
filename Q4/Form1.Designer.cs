namespace Q4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.peopleLabel = new System.Windows.Forms.Label();
            this.peopleTextBox = new System.Windows.Forms.TextBox();
            this.carsLabel = new System.Windows.Forms.Label();
            this.carsTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(27, 36);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(32, 12);
            this.peopleLabel.TabIndex = 0;
            this.peopleLabel.Text = "人數:";
            // 
            // peopleTextBox
            // 
            this.peopleTextBox.Location = new System.Drawing.Point(88, 33);
            this.peopleTextBox.Name = "peopleTextBox";
            this.peopleTextBox.Size = new System.Drawing.Size(100, 22);
            this.peopleTextBox.TabIndex = 0;
            // 
            // carsLabel
            // 
            this.carsLabel.AutoSize = true;
            this.carsLabel.Location = new System.Drawing.Point(27, 96);
            this.carsLabel.Name = "carsLabel";
            this.carsLabel.Size = new System.Drawing.Size(32, 12);
            this.carsLabel.TabIndex = 0;
            this.carsLabel.Text = "車輛:";
            // 
            // carsTextBox
            // 
            this.carsTextBox.Location = new System.Drawing.Point(88, 93);
            this.carsTextBox.Name = "carsTextBox";
            this.carsTextBox.Size = new System.Drawing.Size(100, 22);
            this.carsTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(212, 43);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(56, 12);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "resultLabel";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(145, 148);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "計算";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 184);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.carsTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.carsLabel);
            this.Controls.Add(this.peopleTextBox);
            this.Controls.Add(this.peopleLabel);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.TextBox peopleTextBox;
        private System.Windows.Forms.Label carsLabel;
        private System.Windows.Forms.TextBox carsTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

