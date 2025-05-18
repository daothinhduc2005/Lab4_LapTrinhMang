namespace WindowsFormsApp4
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.RichTextBox rtbHTML;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.rtbHTML = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(16, 15);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(732, 22);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "https://";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(16, 49);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(732, 22);
            this.txtData.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(776, 15);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(100, 28);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // rtbHTML
            // 
            this.rtbHTML.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbHTML.Location = new System.Drawing.Point(16, 92);
            this.rtbHTML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbHTML.Name = "rtbHTML";
            this.rtbHTML.Size = new System.Drawing.Size(1012, 627);
            this.rtbHTML.TabIndex = 3;
            this.rtbHTML.Text = "";
            this.rtbHTML.WordWrap = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.rtbHTML);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtURL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Demo POST Only";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
