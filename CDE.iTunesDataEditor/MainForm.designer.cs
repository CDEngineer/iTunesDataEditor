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
            this.MainDataGridView.Location = new System.Drawing.Point(14, 43);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowHeadersWidth = 51;
            this.MainDataGridView.Size = new System.Drawing.Size(596, 387);
            this.MainDataGridView.TabIndex = 4;
            this.MainDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MainDataGridView_CellBeginEdit);
            this.MainDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGridView_CellEndEdit);
            this.MainDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MainDataGridView_DataBindingComplete);
            // 
            // PlaylistLabel
            // 
            this.PlaylistLabel.AutoSize = true;
            this.PlaylistLabel.Location = new System.Drawing.Point(15, 15);
            this.PlaylistLabel.Name = "PlaylistLabel";
            this.PlaylistLabel.Size = new System.Drawing.Size(58, 20);
            this.PlaylistLabel.TabIndex = 1;
            this.PlaylistLabel.Text = "Playlist:";
            // 
            // PlaylistComboBox
            // 
            this.PlaylistComboBox.FormattingEnabled = true;
            this.PlaylistComboBox.Location = new System.Drawing.Point(71, 12);
            this.PlaylistComboBox.Name = "PlaylistComboBox";
            this.PlaylistComboBox.Size = new System.Drawing.Size(320, 28);
            this.PlaylistComboBox.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(523, 9);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(87, 27);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.PlaylistComboBox);
            this.Controls.Add(this.PlaylistLabel);
            this.Controls.Add(this.MainDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "iTunes Data Editor";
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

