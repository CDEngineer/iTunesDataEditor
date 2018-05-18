namespace CDE.iTunesDataEditor
{
    partial class MainForm
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
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.PlaylistLabel = new System.Windows.Forms.Label();
            this.PlaylistComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 57);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.Size = new System.Drawing.Size(776, 381);
            this.MainDataGridView.TabIndex = 0;
            this.MainDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MainDataGridView_CellBeginEdit);
            this.MainDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGridView_CellEndEdit);
            this.MainDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MainDataGridView_DataBindingComplete);
            // 
            // PlaylistLabel
            // 
            this.PlaylistLabel.AutoSize = true;
            this.PlaylistLabel.Location = new System.Drawing.Point(13, 13);
            this.PlaylistLabel.Name = "PlaylistLabel";
            this.PlaylistLabel.Size = new System.Drawing.Size(39, 13);
            this.PlaylistLabel.TabIndex = 1;
            this.PlaylistLabel.Text = "Playlist";
            // 
            // PlaylistComboBox
            // 
            this.PlaylistComboBox.FormattingEnabled = true;
            this.PlaylistComboBox.Location = new System.Drawing.Point(13, 30);
            this.PlaylistComboBox.Name = "PlaylistComboBox";
            this.PlaylistComboBox.Size = new System.Drawing.Size(440, 21);
            this.PlaylistComboBox.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(713, 28);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.PlaylistComboBox);
            this.Controls.Add(this.PlaylistLabel);
            this.Controls.Add(this.MainDataGridView);
            this.Name = "MainForm";
            this.Text = "iTunes Data Editor ( 2018-05-17 )";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Label PlaylistLabel;
        private System.Windows.Forms.ComboBox PlaylistComboBox;
        private System.Windows.Forms.Button GoButton;
    }
}

