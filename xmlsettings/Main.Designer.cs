namespace xmlsettings
{
    partial class Main
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
            this.propGrid = new System.Windows.Forms.PropertyGrid();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // propGrid
            // 
            this.propGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propGrid.Location = new System.Drawing.Point(12, 131);
            this.propGrid.Name = "propGrid";
            this.propGrid.Size = new System.Drawing.Size(300, 250);
            this.propGrid.TabIndex = 0;
            // 
            // lstBox
            // 
            this.lstBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(13, 13);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(299, 108);
            this.lstBox.TabIndex = 1;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 393);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.propGrid);
            this.Name = "Main";
            this.Text = "XML Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propGrid;
        private System.Windows.Forms.ListBox lstBox;
    }
}

