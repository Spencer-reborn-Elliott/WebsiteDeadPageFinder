namespace WebsiteDeadPageFinder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Output = new System.Windows.Forms.RichTextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.timeOut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 94);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(1033, 408);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(955, 508);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 33);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(161, 32);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(884, 20);
            this.URL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Website Sitemap Location:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(859, 508);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timeOut
            // 
            this.timeOut.Location = new System.Drawing.Point(307, 59);
            this.timeOut.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.timeOut.Name = "timeOut";
            this.timeOut.Size = new System.Drawing.Size(52, 20);
            this.timeOut.TabIndex = 5;
            this.timeOut.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timeout in seconds before determining dead page or error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeOut);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.Output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Website Dead Page Finder v1.04";
            ((System.ComponentModel.ISupportInitialize)(this.timeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown timeOut;
        private System.Windows.Forms.Label label2;
    }
}

