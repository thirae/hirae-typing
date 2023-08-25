namespace TypingApp
{
    partial class ScoreForm
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
            this.FinishLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.RankingButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FinishLabel.Location = new System.Drawing.Point(403, 30);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(255, 97);
            this.FinishLabel.TabIndex = 0;
            this.FinishLabel.Text = "終了!";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.ScoreLabel.Location = new System.Drawing.Point(375, 149);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 33);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score:";
            // 
            // RankingButton
            // 
            this.RankingButton.Location = new System.Drawing.Point(446, 222);
            this.RankingButton.Name = "RankingButton";
            this.RankingButton.Size = new System.Drawing.Size(169, 71);
            this.RankingButton.TabIndex = 2;
            this.RankingButton.Text = "ランキング";
            this.RankingButton.UseVisualStyleBackColor = true;
            this.RankingButton.Click += new System.EventHandler(this.RankingButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(446, 317);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(169, 71);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "タイトルに戻る";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(446, 414);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(169, 71);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 584);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RankingButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.FinishLabel);
            this.Name = "ScoreForm";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button RankingButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button EndButton;
    }
}