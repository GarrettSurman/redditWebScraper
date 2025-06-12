namespace webScraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnScrape = new Button();
            rtbDisplay = new RichTextBox();
            txtSubreddit = new TextBox();
            txtSearchTerm1 = new TextBox();
            txtSearchTerm2 = new TextBox();
            txtSearchTerm3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnScrape
            // 
            btnScrape.Location = new Point(1032, 413);
            btnScrape.Name = "btnScrape";
            btnScrape.Size = new Size(75, 23);
            btnScrape.TabIndex = 0;
            btnScrape.Text = "Scrape";
            btnScrape.UseVisualStyleBackColor = true;
            btnScrape.Click += btnScrape_Click;
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(12, 13);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.Size = new Size(1095, 396);
            rtbDisplay.TabIndex = 1;
            rtbDisplay.Text = "";
            // 
            // txtSubreddit
            // 
            txtSubreddit.Location = new Point(173, 413);
            txtSubreddit.Name = "txtSubreddit";
            txtSubreddit.Size = new Size(100, 25);
            txtSubreddit.TabIndex = 2;
            // 
            // txtSearchTerm1
            // 
            txtSearchTerm1.Location = new Point(357, 413);
            txtSearchTerm1.Name = "txtSearchTerm1";
            txtSearchTerm1.Size = new Size(100, 25);
            txtSearchTerm1.TabIndex = 3;
            // 
            // txtSearchTerm2
            // 
            txtSearchTerm2.Location = new Point(463, 413);
            txtSearchTerm2.Name = "txtSearchTerm2";
            txtSearchTerm2.Size = new Size(100, 25);
            txtSearchTerm2.TabIndex = 4;
            // 
            // txtSearchTerm3
            // 
            txtSearchTerm3.Location = new Point(569, 413);
            txtSearchTerm3.Name = "txtSearchTerm3";
            txtSearchTerm3.Size = new Size(100, 25);
            txtSearchTerm3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 418);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 6;
            label1.Text = "Subreddit: reddit.com/r/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 416);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 7;
            label2.Text = "Key Terms";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchTerm3);
            Controls.Add(txtSearchTerm2);
            Controls.Add(txtSearchTerm1);
            Controls.Add(txtSubreddit);
            Controls.Add(rtbDisplay);
            Controls.Add(btnScrape);
            Name = "Form1";
            Text = "REDDIT WEB SCRAPER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScrape;
        private RichTextBox rtbDisplay;
        private TextBox txtSubreddit;
        private TextBox txtSearchTerm1;
        private TextBox txtSearchTerm2;
        private TextBox txtSearchTerm3;
        private Label label1;
        private Label label2;
    }
}
