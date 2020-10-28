namespace MainForm
{
    partial class ShennonFanoForm
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WriteButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NearLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(13, 13);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.Size = new System.Drawing.Size(359, 333);
            this.Grid.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(272, 355);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 32);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadButton.Location = new System.Drawing.Point(60, 355);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(100, 32);
            this.ReadButton.TabIndex = 10;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WriteButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteButton.Location = new System.Drawing.Point(166, 355);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(100, 32);
            this.WriteButton.TabIndex = 11;
            this.WriteButton.Text = "Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.NearLabel,
            this.SpeedLabel});
            this.Status.Location = new System.Drawing.Point(0, 390);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(386, 22);
            this.Status.TabIndex = 12;
            this.Status.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 17);
            this.StatusLabel.Text = "Mean: ";
            // 
            // NearLabel
            // 
            this.NearLabel.Name = "NearLabel";
            this.NearLabel.Size = new System.Drawing.Size(35, 17);
            this.NearLabel.Text = "Near:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(67, 17);
            this.SpeedLabel.Text = "SpeedLabel";
            // 
            // ShennonFanoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 412);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShennonFanoForm";
            this.Text = "ShennonFanoForm";
            this.Load += new System.EventHandler(this.ShennonFanoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NearLabel;
        private System.Windows.Forms.ToolStripStatusLabel SpeedLabel;
    }
}