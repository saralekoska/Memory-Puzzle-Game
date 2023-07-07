namespace Memory_Puzzle_Game
{
    partial class MediumForm
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
            button1 = new System.Windows.Forms.Button();
            statusLabel = new System.Windows.Forms.Label();
            txtCountDown = new System.Windows.Forms.Label();
            GameTImer = new System.Windows.Forms.Timer(components);
            txtCountDown2 = new System.Windows.Forms.Label();
            statusLabel2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            btnExit2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(588, 32);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(588, 92);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 20);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "status";
            // 
            // txtCountDown
            // 
            txtCountDown.AutoSize = true;
            txtCountDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCountDown.Location = new System.Drawing.Point(588, 157);
            txtCountDown.Name = "txtCountDown";
            txtCountDown.Size = new System.Drawing.Size(145, 28);
            txtCountDown.TabIndex = 3;
            txtCountDown.Text = "Timer Left: 30";
            // 
            // GameTImer
            // 
            GameTImer.Interval = 1000;
            GameTImer.Tick += Timer_Event;
            // 
            // txtCountDown2
            // 
            txtCountDown2.AutoSize = true;
            txtCountDown2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCountDown2.ForeColor = System.Drawing.Color.Maroon;
            txtCountDown2.Location = new System.Drawing.Point(436, 22);
            txtCountDown2.Name = "txtCountDown2";
            txtCountDown2.Size = new System.Drawing.Size(134, 23);
            txtCountDown2.TabIndex = 4;
            txtCountDown2.Text = "Time Left: 75";
            // 
            // statusLabel2
            // 
            statusLabel2.AutoSize = true;
            statusLabel2.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            statusLabel2.ForeColor = System.Drawing.Color.Maroon;
            statusLabel2.Location = new System.Drawing.Point(416, 70);
            statusLabel2.Name = "statusLabel2";
            statusLabel2.Size = new System.Drawing.Size(45, 19);
            statusLabel2.TabIndex = 5;
            statusLabel2.Text = "status";
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Maroon;
            button2.Location = new System.Drawing.Point(436, 323);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(109, 31);
            button2.TabIndex = 6;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnExit2
            // 
            btnExit2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit2.ForeColor = System.Drawing.Color.Maroon;
            btnExit2.Location = new System.Drawing.Point(436, 380);
            btnExit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new System.Drawing.Size(109, 31);
            btnExit2.TabIndex = 7;
            btnExit2.Text = "Exit";
            btnExit2.UseVisualStyleBackColor = true;
            btnExit2.Click += btnExit2_Click;
            // 
            // MediumForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(582, 503);
            Controls.Add(btnExit2);
            Controls.Add(button2);
            Controls.Add(statusLabel2);
            Controls.Add(txtCountDown2);
            Controls.Add(txtCountDown);
            Controls.Add(statusLabel);
            Controls.Add(button1);
            Name = "MediumForm";
            Text = "Memory Puzzle Game [Medium]";
            Load += MediumForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Timer GameTImer;
        private System.Windows.Forms.Label txtCountDown2;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit2;
    }
}
