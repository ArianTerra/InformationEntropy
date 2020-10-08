namespace MainForm
{
    partial class InputForm
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
            this.MainInput = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.Button();
            this.TextFile = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Symbols = new System.Windows.Forms.CheckBox();
            this.SpacesIgnore = new System.Windows.Forms.CheckBox();
            this.URLbutton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.charactersLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacelessLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lettersLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Combine = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainInput
            // 
            this.MainInput.AllowDrop = true;
            this.MainInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainInput.Location = new System.Drawing.Point(13, 12);
            this.MainInput.Multiline = true;
            this.MainInput.Name = "MainInput";
            this.MainInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainInput.Size = new System.Drawing.Size(846, 413);
            this.MainInput.TabIndex = 0;
            this.MainInput.TabStop = false;
            this.MainInput.Text = "Enter your text here...";
            this.MainInput.TextChanged += new System.EventHandler(this.MainInput_TextChanged);
            // 
            // Process
            // 
            this.Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Process.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Process.Location = new System.Drawing.Point(760, 434);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(100, 32);
            this.Process.TabIndex = 1;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // TextFile
            // 
            this.TextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFile.Location = new System.Drawing.Point(654, 434);
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(100, 32);
            this.TextFile.TabIndex = 2;
            this.TextFile.Text = "Open File";
            this.TextFile.UseVisualStyleBackColor = true;
            this.TextFile.Click += new System.EventHandler(this.TextFile_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(442, 434);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 32);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Close_Click);
            // 
            // Symbols
            // 
            this.Symbols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Symbols.AutoSize = true;
            this.Symbols.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbols.Location = new System.Drawing.Point(14, 440);
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(136, 23);
            this.Symbols.TabIndex = 4;
            this.Symbols.Text = "Letters only";
            this.Symbols.UseVisualStyleBackColor = true;
            // 
            // SpacesIgnore
            // 
            this.SpacesIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpacesIgnore.AutoSize = true;
            this.SpacesIgnore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpacesIgnore.Location = new System.Drawing.Point(165, 440);
            this.SpacesIgnore.Name = "SpacesIgnore";
            this.SpacesIgnore.Size = new System.Drawing.Size(145, 23);
            this.SpacesIgnore.TabIndex = 5;
            this.SpacesIgnore.Text = "Ignore spaces";
            this.SpacesIgnore.UseVisualStyleBackColor = true;
            // 
            // URLbutton
            // 
            this.URLbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.URLbutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.URLbutton.Location = new System.Drawing.Point(548, 434);
            this.URLbutton.Name = "URLbutton";
            this.URLbutton.Size = new System.Drawing.Size(100, 32);
            this.URLbutton.TabIndex = 6;
            this.URLbutton.Text = "Open URL";
            this.URLbutton.UseVisualStyleBackColor = true;
            this.URLbutton.Click += new System.EventHandler(this.URLbutton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label12,
            this.charactersLabel,
            this.toolStripStatusLabel2,
            this.spacelessLabel,
            this.toolStripStatusLabel1,
            this.lettersLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 466);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(871, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // label12
            // 
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.Text = "Characters:";
            // 
            // charactersLabel
            // 
            this.charactersLabel.Name = "charactersLabel";
            this.charactersLabel.Size = new System.Drawing.Size(13, 17);
            this.charactersLabel.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel2.Text = "Exept spaces:";
            // 
            // spacelessLabel
            // 
            this.spacelessLabel.Name = "spacelessLabel";
            this.spacelessLabel.Size = new System.Drawing.Size(13, 17);
            this.spacelessLabel.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Letters:";
            // 
            // lettersLabel
            // 
            this.lettersLabel.Name = "lettersLabel";
            this.lettersLabel.Size = new System.Drawing.Size(13, 17);
            this.lettersLabel.Text = "0";
            // 
            // Combine
            // 
            this.Combine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Combine.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Combine.Location = new System.Drawing.Point(336, 434);
            this.Combine.Name = "Combine";
            this.Combine.Size = new System.Drawing.Size(100, 32);
            this.Combine.TabIndex = 8;
            this.Combine.Text = "Combine";
            this.Combine.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 488);
            this.Controls.Add(this.Combine);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.URLbutton);
            this.Controls.Add(this.SpacesIgnore);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.MainInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.Text = "Entropy";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Button TextFile;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox Symbols;
        private System.Windows.Forms.CheckBox SpacesIgnore;
        private System.Windows.Forms.Button URLbutton;
        public System.Windows.Forms.TextBox MainInput;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel label12;
        private System.Windows.Forms.ToolStripStatusLabel charactersLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel spacelessLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lettersLabel;
        private System.Windows.Forms.Button Combine;
    }
}

