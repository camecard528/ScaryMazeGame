namespace ScaryMazeGame
{
    partial class gameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.quitLabel = new System.Windows.Forms.Label();
            this.contLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(147, 358);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(100, 50);
            this.yesButton.TabIndex = 17;
            this.yesButton.Text = "Start";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(752, 358);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(100, 50);
            this.noButton.TabIndex = 16;
            this.noButton.Text = "Exit";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Location = new System.Drawing.Point(783, 342);
            this.quitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(39, 13);
            this.quitLabel.TabIndex = 15;
            this.quitLabel.Text = "QUIT?";
            // 
            // contLabel
            // 
            this.contLabel.AutoSize = true;
            this.contLabel.Location = new System.Drawing.Point(163, 342);
            this.contLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contLabel.Name = "contLabel";
            this.contLabel.Size = new System.Drawing.Size(69, 13);
            this.contLabel.TabIndex = 14;
            this.contLabel.Text = "CONTINUE?";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.contLabel);
            this.DoubleBuffered = true;
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(1024, 720);
            this.Load += new System.EventHandler(this.gameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.Label contLabel;
    }
}
