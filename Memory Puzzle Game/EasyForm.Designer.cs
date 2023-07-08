
namespace Memory_Puzzle_Game
{
    partial class EasyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            statusLabel = new System.Windows.Forms.Label();
            GameTImer = new System.Windows.Forms.Timer(components);
            txtCountDown = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Maroon;
            button1.Location = new System.Drawing.Point(347, 252);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(109, 31);
            button1.TabIndex = 0;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            statusLabel.ForeColor = System.Drawing.Color.Maroon;
            statusLabel.Location = new System.Drawing.Point(315, 47);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(45, 19);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "status";
            // 
            // GameTImer
            // 
            GameTImer.Enabled = true;
            GameTImer.Interval = 1000;
            GameTImer.Tick += TimerEvent;
            // 
            // txtCountDown
            // 
            txtCountDown.AutoSize = true;
            txtCountDown.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCountDown.ForeColor = System.Drawing.Color.Maroon;
            txtCountDown.Location = new System.Drawing.Point(336, 9);
            txtCountDown.Name = "txtCountDown";
            txtCountDown.Size = new System.Drawing.Size(134, 23);
            txtCountDown.TabIndex = 1;
            txtCountDown.Text = "Time Left: 45";
            // 
            // btnExit
            // 
            btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.Color.Maroon;
            btnExit.Location = new System.Drawing.Point(347, 312);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(109, 31);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // EasyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(478, 459);
            Controls.Add(btnExit);
            Controls.Add(txtCountDown);
            Controls.Add(statusLabel);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "EasyForm";
            Text = "Memory Puzzle Game [Easy]";
            Load += EasyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer GameTImer;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Button btnExit;
    }
}

