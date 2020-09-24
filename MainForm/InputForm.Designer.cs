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
            this.Close = new System.Windows.Forms.Button();
            this.Symbols = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MainInput
            // 
            this.MainInput.AllowDrop = true;
            this.MainInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainInput.Location = new System.Drawing.Point(13, 13);
            this.MainInput.Multiline = true;
            this.MainInput.Name = "MainInput";
            this.MainInput.Size = new System.Drawing.Size(745, 425);
            this.MainInput.TabIndex = 0;
            this.MainInput.TabStop = false;
            this.MainInput.Text = "Enter your text here...";
            // 
            // Process
            // 
            this.Process.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Process.Location = new System.Drawing.Point(632, 444);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(126, 32);
            this.Process.TabIndex = 1;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // TextFile
            // 
            this.TextFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFile.Location = new System.Drawing.Point(500, 444);
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(126, 32);
            this.TextFile.TabIndex = 2;
            this.TextFile.Text = "Open File";
            this.TextFile.UseVisualStyleBackColor = true;
            this.TextFile.Click += new System.EventHandler(this.TextFile_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(368, 444);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(126, 32);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Symbols
            // 
            this.Symbols.AutoSize = true;
            this.Symbols.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbols.Location = new System.Drawing.Point(13, 450);
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(325, 23);
            this.Symbols.TabIndex = 4;
            this.Symbols.Text = "Ignore any non-alphabetic symbols";
            this.Symbols.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.MainInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainInput;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Button TextFile;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.CheckBox Symbols;
    }
}

