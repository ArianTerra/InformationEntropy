namespace MainForm
{
    partial class CombineForm
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
            this.AlpA = new System.Windows.Forms.DataGridView();
            this.AlpB = new System.Windows.Forms.DataGridView();
            this.AlpAAlpB = new System.Windows.Forms.DataGridView();
            this.AlpBAlpA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlpA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpAAlpB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpBAlpA)).BeginInit();
            this.SuspendLayout();
            // 
            // AlpA
            // 
            this.AlpA.AllowUserToAddRows = false;
            this.AlpA.AllowUserToDeleteRows = false;
            this.AlpA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlpA.Location = new System.Drawing.Point(13, 13);
            this.AlpA.MultiSelect = false;
            this.AlpA.Name = "AlpA";
            this.AlpA.ReadOnly = true;
            this.AlpA.Size = new System.Drawing.Size(708, 34);
            this.AlpA.TabIndex = 0;
            // 
            // AlpB
            // 
            this.AlpB.AllowUserToAddRows = false;
            this.AlpB.AllowUserToDeleteRows = false;
            this.AlpB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlpB.Location = new System.Drawing.Point(12, 56);
            this.AlpB.MultiSelect = false;
            this.AlpB.Name = "AlpB";
            this.AlpB.ReadOnly = true;
            this.AlpB.Size = new System.Drawing.Size(709, 34);
            this.AlpB.TabIndex = 1;
            // 
            // AlpAAlpB
            // 
            this.AlpAAlpB.AllowUserToAddRows = false;
            this.AlpAAlpB.AllowUserToDeleteRows = false;
            this.AlpAAlpB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlpAAlpB.Location = new System.Drawing.Point(14, 96);
            this.AlpAAlpB.MultiSelect = false;
            this.AlpAAlpB.Name = "AlpAAlpB";
            this.AlpAAlpB.ReadOnly = true;
            this.AlpAAlpB.Size = new System.Drawing.Size(707, 239);
            this.AlpAAlpB.TabIndex = 2;
            // 
            // AlpBAlpA
            // 
            this.AlpBAlpA.AllowUserToAddRows = false;
            this.AlpBAlpA.AllowUserToDeleteRows = false;
            this.AlpBAlpA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlpBAlpA.Location = new System.Drawing.Point(14, 348);
            this.AlpBAlpA.MultiSelect = false;
            this.AlpBAlpA.Name = "AlpBAlpA";
            this.AlpBAlpA.ReadOnly = true;
            this.AlpBAlpA.Size = new System.Drawing.Size(707, 239);
            this.AlpBAlpA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(727, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alphabet A (prob.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(727, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alphabet B (prob.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(727, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Relative probability P(xi/yi)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(727, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Relative probability P(yi/xi)";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(899, 609);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 32);
            this.Close.TabIndex = 8;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(12, 590);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(288, 19);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Hartly: 0 Shennon: 0 Entropy: 0";
            // 
            // CombineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 653);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlpBAlpA);
            this.Controls.Add(this.AlpAAlpB);
            this.Controls.Add(this.AlpB);
            this.Controls.Add(this.AlpA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CombineForm";
            this.Text = "CombineForm";
            this.Load += new System.EventHandler(this.CombineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlpA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpAAlpB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpBAlpA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AlpA;
        private System.Windows.Forms.DataGridView AlpB;
        private System.Windows.Forms.DataGridView AlpAAlpB;
        private System.Windows.Forms.DataGridView AlpBAlpA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label infoLabel;
    }
}