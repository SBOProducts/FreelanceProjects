namespace ZillowSpider
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartUrl = new System.Windows.Forms.TextBox();
            this.Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Url";
            // 
            // StartUrl
            // 
            this.StartUrl.Location = new System.Drawing.Point(92, 26);
            this.StartUrl.Name = "StartUrl";
            this.StartUrl.Size = new System.Drawing.Size(652, 20);
            this.StartUrl.TabIndex = 1;
            this.StartUrl.Text = "http://www.zillow.com/homes/recently_sold/house_type/1-_baths/120587-163147_price" +
    "/452-611_mp/12m_days/1315-1779_size/days_sort/28.381282,-81.258059,28.311635,-81" +
    ".481218_rect/12_zm/";
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(92, 52);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(110, 30);
            this.Download.TabIndex = 2;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 358);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.StartUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StartUrl;
        private System.Windows.Forms.Button Download;
    }
}

