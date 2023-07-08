namespace Memory_Puzzle_Game
{
    partial class Form1
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
            btnEasyLevel = new System.Windows.Forms.Button();
            btnMediumLevel = new System.Windows.Forms.Button();
            btnHardLevel = new System.Windows.Forms.Button();
            cbTheme = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnEasyLevel
            // 
            btnEasyLevel.BackColor = System.Drawing.Color.MistyRose;
            btnEasyLevel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEasyLevel.ForeColor = System.Drawing.Color.Maroon;
            btnEasyLevel.Location = new System.Drawing.Point(275, 277);
            btnEasyLevel.Name = "btnEasyLevel";
            btnEasyLevel.Size = new System.Drawing.Size(185, 29);
            btnEasyLevel.TabIndex = 0;
            btnEasyLevel.Text = "Easy";
            btnEasyLevel.UseVisualStyleBackColor = false;
            btnEasyLevel.Click += btnEasyLevel_Click;
            // 
            // btnMediumLevel
            // 
            btnMediumLevel.BackColor = System.Drawing.Color.MistyRose;
            btnMediumLevel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMediumLevel.ForeColor = System.Drawing.Color.Maroon;
            btnMediumLevel.Location = new System.Drawing.Point(275, 328);
            btnMediumLevel.Name = "btnMediumLevel";
            btnMediumLevel.Size = new System.Drawing.Size(185, 29);
            btnMediumLevel.TabIndex = 1;
            btnMediumLevel.Text = "Medium";
            btnMediumLevel.UseVisualStyleBackColor = false;
            btnMediumLevel.Click += btnMediumLevel_Click;
            // 
            // btnHardLevel
            // 
            btnHardLevel.BackColor = System.Drawing.Color.MistyRose;
            btnHardLevel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHardLevel.ForeColor = System.Drawing.Color.Maroon;
            btnHardLevel.Location = new System.Drawing.Point(275, 378);
            btnHardLevel.Name = "btnHardLevel";
            btnHardLevel.Size = new System.Drawing.Size(185, 29);
            btnHardLevel.TabIndex = 2;
            btnHardLevel.Text = "Hard";
            btnHardLevel.UseVisualStyleBackColor = false;
            btnHardLevel.Click += btnHardLevel_Click;
            // 
            // cbTheme
            // 
            cbTheme.BackColor = System.Drawing.Color.MistyRose;
            cbTheme.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbTheme.FormattingEnabled = true;
            cbTheme.Items.AddRange(new object[] { "Fruits", "Animals", "Halloween" });
            cbTheme.Location = new System.Drawing.Point(275, 199);
            cbTheme.Name = "cbTheme";
            cbTheme.Size = new System.Drawing.Size(185, 27);
            cbTheme.TabIndex = 3;
            cbTheme.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Location = new System.Drawing.Point(275, 170);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 26);
            label1.TabIndex = 4;
            label1.Text = "Choose a theme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.MistyRose;
            label2.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(177, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(440, 41);
            label2.TabIndex = 5;
            label2.Text = "Memory Puzzle Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Maroon;
            label3.Location = new System.Drawing.Point(303, 248);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 26);
            label3.TabIndex = 6;
            label3.Text = "Select level";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.IndianRed;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTheme);
            Controls.Add(btnHardLevel);
            Controls.Add(btnMediumLevel);
            Controls.Add(btnEasyLevel);
            Name = "Form1";
            Text = "Memory Puzzle Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEasyLevel;
        private System.Windows.Forms.Button btnMediumLevel;
        private System.Windows.Forms.Button btnHardLevel;
        public System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
