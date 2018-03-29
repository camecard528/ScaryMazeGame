namespace ScaryMazeGame
{
    partial class FailScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tryLabel = new System.Windows.Forms.Label();
            this.loserLabel = new System.Windows.Forms.Label();
            this.nomoreLabel = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tryLabel
            // 
            this.tryLabel.AutoSize = true;
            this.tryLabel.Location = new System.Drawing.Point(186, 296);
            this.tryLabel.Name = "tryLabel";
            this.tryLabel.Size = new System.Drawing.Size(90, 17);
            this.tryLabel.TabIndex = 0;
            this.tryLabel.Text = "TRY AGAIN?";
            // 
            // loserLabel
            // 
            this.loserLabel.AutoSize = true;
            this.loserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loserLabel.Location = new System.Drawing.Point(505, 19);
            this.loserLabel.Name = "loserLabel";
            this.loserLabel.Size = new System.Drawing.Size(282, 32);
            this.loserLabel.TabIndex = 1;
            this.loserLabel.Text = "You Lost! Already?!";
            // 
            // nomoreLabel
            // 
            this.nomoreLabel.AutoSize = true;
            this.nomoreLabel.Location = new System.Drawing.Point(1017, 296);
            this.nomoreLabel.Name = "nomoreLabel";
            this.nomoreLabel.Size = new System.Drawing.Size(77, 17);
            this.nomoreLabel.TabIndex = 3;
            this.nomoreLabel.Text = "NO MORE!";
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(989, 335);
            this.noButton.Margin = new System.Windows.Forms.Padding(4);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(133, 62);
            this.noButton.TabIndex = 8;
            this.noButton.Text = "OK.";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(164, 335);
            this.yesButton.Margin = new System.Windows.Forms.Padding(4);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(133, 62);
            this.yesButton.TabIndex = 9;
            this.yesButton.Text = "YES!";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // FailScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.nomoreLabel);
            this.Controls.Add(this.loserLabel);
            this.Controls.Add(this.tryLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FailScreen";
            this.Size = new System.Drawing.Size(1384, 1024);
            this.Load += new System.EventHandler(this.FailScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tryLabel;
        private System.Windows.Forms.Label loserLabel;
        private System.Windows.Forms.Label nomoreLabel;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
    }
}
