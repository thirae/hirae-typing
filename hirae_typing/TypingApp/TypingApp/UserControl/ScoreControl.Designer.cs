namespace TypingApp
{
    partial class ScoreControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
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
            this.FinishLabel.Location = new System.Drawing.Point(389, 42);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(255, 97);
            this.FinishLabel.TabIndex = 1;
            this.FinishLabel.Text = "終了!";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.ScoreLabel.Location = new System.Drawing.Point(417, 162);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 33);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score:";
            // 
            // RankingButton
            // 
            this.RankingButton.Location = new System.Drawing.Point(441, 230);
            this.RankingButton.Name = "RankingButton";
            this.RankingButton.Size = new System.Drawing.Size(169, 71);
            this.RankingButton.TabIndex = 3;
            this.RankingButton.Text = "ランキング";
            this.RankingButton.UseVisualStyleBackColor = true;
            this.RankingButton.Click += new System.EventHandler(this.RankingButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(441, 316);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(169, 71);
            this.ReturnButton.TabIndex = 4;
            this.ReturnButton.Text = "タイトルに戻る";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(441, 402);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(169, 71);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RankingButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.FinishLabel);
            this.Name = "ScoreControl";
            this.Size = new System.Drawing.Size(1080, 500);
            this.Load += new System.EventHandler(this.ScoreControl_Load);
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
