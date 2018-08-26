namespace ExtendedTextEditor
{
    partial class FindReplaceForm
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
            this.FindWhatComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceWithComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchWholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.FindNextButton = new System.Windows.Forms.Button();
            this.ReplaceCurrentButton = new System.Windows.Forms.Button();
            this.ReplaceAllButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FindPrevButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindWhatComboBox
            // 
            this.FindWhatComboBox.FormattingEnabled = true;
            this.FindWhatComboBox.Location = new System.Drawing.Point(110, 11);
            this.FindWhatComboBox.Name = "FindWhatComboBox";
            this.FindWhatComboBox.Size = new System.Drawing.Size(234, 21);
            this.FindWhatComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find what:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replace with:";
            // 
            // ReplaceWithComboBox
            // 
            this.ReplaceWithComboBox.FormattingEnabled = true;
            this.ReplaceWithComboBox.Location = new System.Drawing.Point(110, 42);
            this.ReplaceWithComboBox.Name = "ReplaceWithComboBox";
            this.ReplaceWithComboBox.Size = new System.Drawing.Size(234, 21);
            this.ReplaceWithComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MatchCaseCheckBox);
            this.groupBox1.Controls.Add(this.MatchWholeWordCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match options";
            // 
            // MatchCaseCheckBox
            // 
            this.MatchCaseCheckBox.AutoSize = true;
            this.MatchCaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchCaseCheckBox.Location = new System.Drawing.Point(181, 19);
            this.MatchCaseCheckBox.Name = "MatchCaseCheckBox";
            this.MatchCaseCheckBox.Size = new System.Drawing.Size(99, 21);
            this.MatchCaseCheckBox.TabIndex = 6;
            this.MatchCaseCheckBox.Text = "Match case";
            this.MatchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchWholeWordCheckBox
            // 
            this.MatchWholeWordCheckBox.AutoSize = true;
            this.MatchWholeWordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchWholeWordCheckBox.Location = new System.Drawing.Point(6, 19);
            this.MatchWholeWordCheckBox.Name = "MatchWholeWordCheckBox";
            this.MatchWholeWordCheckBox.Size = new System.Drawing.Size(169, 21);
            this.MatchWholeWordCheckBox.TabIndex = 5;
            this.MatchWholeWordCheckBox.Text = "Match whole word only";
            this.MatchWholeWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindNextButton
            // 
            this.FindNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindNextButton.Location = new System.Drawing.Point(361, 9);
            this.FindNextButton.Name = "FindNextButton";
            this.FindNextButton.Size = new System.Drawing.Size(77, 23);
            this.FindNextButton.TabIndex = 5;
            this.FindNextButton.Text = "Find Next";
            this.FindNextButton.UseVisualStyleBackColor = true;
            this.FindNextButton.Click += new System.EventHandler(this.FindNextButton_Click);
            // 
            // ReplaceCurrentButton
            // 
            this.ReplaceCurrentButton.Enabled = false;
            this.ReplaceCurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceCurrentButton.Location = new System.Drawing.Point(361, 40);
            this.ReplaceCurrentButton.Name = "ReplaceCurrentButton";
            this.ReplaceCurrentButton.Size = new System.Drawing.Size(160, 23);
            this.ReplaceCurrentButton.TabIndex = 6;
            this.ReplaceCurrentButton.Text = "Replace Current";
            this.ReplaceCurrentButton.UseVisualStyleBackColor = true;
            this.ReplaceCurrentButton.Click += new System.EventHandler(this.ReplaceCurrentButton_Click);
            // 
            // ReplaceAllButton
            // 
            this.ReplaceAllButton.Enabled = false;
            this.ReplaceAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceAllButton.Location = new System.Drawing.Point(361, 69);
            this.ReplaceAllButton.Name = "ReplaceAllButton";
            this.ReplaceAllButton.Size = new System.Drawing.Size(160, 23);
            this.ReplaceAllButton.TabIndex = 7;
            this.ReplaceAllButton.Text = "Replace All";
            this.ReplaceAllButton.UseVisualStyleBackColor = true;
            this.ReplaceAllButton.Click += new System.EventHandler(this.ReplaceAllButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(361, 99);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(160, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FindPrevButton
            // 
            this.FindPrevButton.Enabled = false;
            this.FindPrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindPrevButton.Location = new System.Drawing.Point(444, 9);
            this.FindPrevButton.Name = "FindPrevButton";
            this.FindPrevButton.Size = new System.Drawing.Size(77, 23);
            this.FindPrevButton.TabIndex = 9;
            this.FindPrevButton.Text = "Find Prev";
            this.FindPrevButton.UseVisualStyleBackColor = true;
            this.FindPrevButton.Click += new System.EventHandler(this.FindPrevButton_Click);
            // 
            // FindReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 131);
            this.Controls.Add(this.FindPrevButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ReplaceAllButton);
            this.Controls.Add(this.ReplaceCurrentButton);
            this.Controls.Add(this.FindNextButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReplaceWithComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindWhatComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindReplaceForm";
            this.Text = "Find / Replace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FindWhatComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReplaceWithComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox MatchCaseCheckBox;
        private System.Windows.Forms.CheckBox MatchWholeWordCheckBox;
        private System.Windows.Forms.Button FindNextButton;
        private System.Windows.Forms.Button ReplaceCurrentButton;
        private System.Windows.Forms.Button ReplaceAllButton;
        new private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FindPrevButton;
    }
}