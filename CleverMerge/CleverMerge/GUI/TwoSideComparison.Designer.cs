namespace CleverMerge.GUI
{
    partial class TwoSideComparison
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftBranch = new CleverMerge.GUI.DirectoryViewer();
            this.rightBranch = new CleverMerge.GUI.DirectoryViewer();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.leftBranch, 0, 0);
            this.mainLayout.Controls.Add(this.rightBranch, 2, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 488F));
            this.mainLayout.Size = new System.Drawing.Size(710, 488);
            this.mainLayout.TabIndex = 0;
            // 
            // leftBranch
            // 
            this.leftBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftBranch.Location = new System.Drawing.Point(3, 3);
            this.leftBranch.Name = "leftBranch";
            this.leftBranch.Size = new System.Drawing.Size(339, 482);
            this.leftBranch.TabIndex = 0;
            // 
            // rightBranch
            // 
            this.rightBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightBranch.Location = new System.Drawing.Point(368, 3);
            this.rightBranch.Name = "rightBranch";
            this.rightBranch.Size = new System.Drawing.Size(339, 482);
            this.rightBranch.TabIndex = 1;
            // 
            // TwoSideComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayout);
            this.Name = "TwoSideComparison";
            this.Size = new System.Drawing.Size(710, 488);
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private DirectoryViewer leftBranch;
        private DirectoryViewer rightBranch;
    }
}
