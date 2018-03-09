namespace ScaryMazeGame
{
    partial class startScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.gotyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cameron Cardiff! Copyright 2018.";
            // 
            // gotyLabel
            // 
            this.gotyLabel.AutoSize = true;
            this.gotyLabel.Location = new System.Drawing.Point(412, 245);
            this.gotyLabel.Name = "gotyLabel";
            this.gotyLabel.Size = new System.Drawing.Size(212, 13);
            this.gotyLabel.TabIndex = 10;
            this.gotyLabel.Text = "GOTY - Sahil Patel. Maze Game Aficionado";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(452, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "BY CAMERON CARDIFF";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(811, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 50);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(159, 226);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 50);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(387, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(251, 42);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "MAZE GAME";
            // 
            // startScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gotyLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "startScreen";
            this.Size = new System.Drawing.Size(1024, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gotyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
    }
}
