namespace Marketplace
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonFirstEnter;
        private System.Windows.Forms.Button buttonSecondEnter;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListBox listBoxDisplay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonFirstEnter = new Button();
            buttonSecondEnter = new Button();
            buttonRefresh = new Button();
            listBoxDisplay = new ListBox();
            SuspendLayout();
            // 
            // buttonFirstEnter
            // 
            buttonFirstEnter.Location = new Point(12, 12);
            buttonFirstEnter.Name = "buttonFirstEnter";
            buttonFirstEnter.Size = new Size(100, 23);
            buttonFirstEnter.TabIndex = 0;
            buttonFirstEnter.Text = "Market Staff";
            buttonFirstEnter.UseVisualStyleBackColor = true;
            buttonFirstEnter.Click += buttonFirstEnter_Click;
            // 
            // buttonSecondEnter
            // 
            buttonSecondEnter.Location = new Point(172, 12);
            buttonSecondEnter.Name = "buttonSecondEnter";
            buttonSecondEnter.Size = new Size(100, 23);
            buttonSecondEnter.TabIndex = 1;
            buttonSecondEnter.Text = "Customer";
            buttonSecondEnter.UseVisualStyleBackColor = true;
            buttonSecondEnter.Click += buttonSecondEnter_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(329, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(100, 23);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.Location = new Point(12, 41);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(428, 304);
            listBoxDisplay.TabIndex = 3;
            listBoxDisplay.SelectedIndexChanged += listBoxDisplay_SelectedIndexChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(452, 353);
            Controls.Add(listBoxDisplay);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSecondEnter);
            Controls.Add(buttonFirstEnter);
            Name = "Form1";
            Text = "Marketplace";
            Load += Form1_Load;
            ResumeLayout(false);
        }
    }
}
