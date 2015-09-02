namespace InterestCalculator
{
    partial class FormMain
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
            this.textBoxPrinciple = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelPrinciple = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPrinciple
            // 
            this.textBoxPrinciple.Location = new System.Drawing.Point(92, 54);
            this.textBoxPrinciple.Name = "textBoxPrinciple";
            this.textBoxPrinciple.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrinciple.TabIndex = 0;
            this.textBoxPrinciple.Text = "Enter principle";
            this.textBoxPrinciple.Click += new System.EventHandler(this.textBoxPrinciple_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(92, 101);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 1;
            this.textBoxTime.Text = "Enter Time";
            this.textBoxTime.Click += new System.EventHandler(this.textBoxTime_Click);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(92, 151);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRate.TabIndex = 2;
            this.textBoxRate.Text = "Enter Rate";
            this.textBoxRate.Click += new System.EventHandler(this.textBoxRate_Click);
            // 
            // labelPrinciple
            // 
            this.labelPrinciple.AutoSize = true;
            this.labelPrinciple.Location = new System.Drawing.Point(33, 57);
            this.labelPrinciple.Name = "labelPrinciple";
            this.labelPrinciple.Size = new System.Drawing.Size(50, 13);
            this.labelPrinciple.TabIndex = 3;
            this.labelPrinciple.Text = "Principle:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(14, 104);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time in years:";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(50, 154);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(33, 13);
            this.labelRate.TabIndex = 5;
            this.labelRate.Text = "Rate:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(321, 101);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(106, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(120, 231);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 352);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelPrinciple);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxPrinciple);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrinciple;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelPrinciple;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
    }
}

