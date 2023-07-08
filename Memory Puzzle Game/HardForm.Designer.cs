namespace Memory_Puzzle_Game
{
    partial class HardForm
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
            components = new System.ComponentModel.Container();
            button3 = new System.Windows.Forms.Button();
            statusLabel = new System.Windows.Forms.Label();
            txtCountDown = new System.Windows.Forms.Label();
            GameTImer = new System.Windows.Forms.Timer(components);
            btnExit3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.Maroon;
            button3.Location = new System.Drawing.Point(498, 366);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(109, 31);
            button3.TabIndex = 2;
            button3.Text = "Restart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            statusLabel.ForeColor = System.Drawing.Color.Maroon;
            statusLabel.Location = new System.Drawing.Point(415, 70);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(45, 19);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "status";
            // 
            // txtCountDown
            // 
            txtCountDown.AutoSize = true;
            txtCountDown.BackColor = System.Drawing.Color.MistyRose;
            txtCountDown.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCountDown.ForeColor = System.Drawing.Color.Maroon;
            txtCountDown.Location = new System.Drawing.Point(475, 21);
            txtCountDown.Name = "txtCountDown";
            txtCountDown.Size = new System.Drawing.Size(153, 23);
            txtCountDown.TabIndex = 4;
            txtCountDown.Text = "Timer Left: 120";
            // 
            // GameTImer
            // 
            GameTImer.Interval = 1000;
            GameTImer.Tick += Timer_Event;
            // 
            // btnExit3
            // 
            btnExit3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit3.ForeColor = System.Drawing.Color.Maroon;
            btnExit3.Location = new System.Drawing.Point(498, 416);
            btnExit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit3.Name = "btnExit3";
            btnExit3.Size = new System.Drawing.Size(109, 31);
            btnExit3.TabIndex = 5;
            btnExit3.Text = "Exit";
            btnExit3.UseVisualStyleBackColor = true;
            btnExit3.Click += btnExit3_Click;
            // 
            // HardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(632, 503);
            Controls.Add(btnExit3);
            Controls.Add(txtCountDown);
            Controls.Add(statusLabel);
            Controls.Add(button3);
            Name = "HardForm";
            Text = "Memory Puzzle Game [Hard]";
            Load += HardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Timer GameTImer;
        private System.Windows.Forms.Button btnExit3;
    }
}