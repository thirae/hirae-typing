namespace TypingApp
{
    partial class TypingControl
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
            this.JapaneseLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MissLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.RomajiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HeartPictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeartPictureBox2 = new System.Windows.Forms.PictureBox();
            this.HeartPictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeartPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // JapaneseLabel
            // 
            this.JapaneseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JapaneseLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JapaneseLabel.Location = new System.Drawing.Point(294, 57);
            this.JapaneseLabel.Name = "JapaneseLabel";
            this.JapaneseLabel.Size = new System.Drawing.Size(487, 78);
            this.JapaneseLabel.TabIndex = 1;
            this.JapaneseLabel.Text = "日本語";
            this.JapaneseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(813, 43);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(166, 33);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "Time : 0 秒";
            // 
            // MissLabel
            // 
            this.MissLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MissLabel.ForeColor = System.Drawing.Color.Red;
            this.MissLabel.Location = new System.Drawing.Point(437, 298);
            this.MissLabel.Name = "MissLabel";
            this.MissLabel.Size = new System.Drawing.Size(210, 30);
            this.MissLabel.TabIndex = 7;
            this.MissLabel.Text = "Miss!";
            this.MissLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(365, 381);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(356, 65);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.Text = "タイトルに戻る";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RomajiRichTextBox
            // 
            this.RomajiRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RomajiRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RomajiRichTextBox.Location = new System.Drawing.Point(212, 200);
            this.RomajiRichTextBox.Name = "RomajiRichTextBox";
            this.RomajiRichTextBox.ReadOnly = true;
            this.RomajiRichTextBox.Size = new System.Drawing.Size(645, 71);
            this.RomajiRichTextBox.TabIndex = 10;
            this.RomajiRichTextBox.Text = "Romaji";
            this.RomajiRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RomajiRichTextBox_KeyPress);
            // 
            // HeartPictureBox1
            // 
            this.HeartPictureBox1.Location = new System.Drawing.Point(191, 7);
            this.HeartPictureBox1.Name = "HeartPictureBox1";
            this.HeartPictureBox1.Size = new System.Drawing.Size(74, 69);
            this.HeartPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeartPictureBox1.TabIndex = 12;
            this.HeartPictureBox1.TabStop = false;
            // 
            // HeartPictureBox2
            // 
            this.HeartPictureBox2.Location = new System.Drawing.Point(111, 7);
            this.HeartPictureBox2.Name = "HeartPictureBox2";
            this.HeartPictureBox2.Size = new System.Drawing.Size(74, 69);
            this.HeartPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeartPictureBox2.TabIndex = 13;
            this.HeartPictureBox2.TabStop = false;
            // 
            // HeartPictureBox3
            // 
            this.HeartPictureBox3.Location = new System.Drawing.Point(31, 7);
            this.HeartPictureBox3.Name = "HeartPictureBox3";
            this.HeartPictureBox3.Size = new System.Drawing.Size(74, 69);
            this.HeartPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeartPictureBox3.TabIndex = 14;
            this.HeartPictureBox3.TabStop = false;
            // 
            // TypingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeartPictureBox3);
            this.Controls.Add(this.HeartPictureBox2);
            this.Controls.Add(this.HeartPictureBox1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.RomajiRichTextBox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.MissLabel);
            this.Controls.Add(this.JapaneseLabel);
            this.Name = "TypingControl";
            this.Size = new System.Drawing.Size(1080, 500);
            this.Load += new System.EventHandler(this.TypingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeartPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JapaneseLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MissLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.RichTextBox RomajiRichTextBox;
        private System.Windows.Forms.PictureBox HeartPictureBox1;
        private System.Windows.Forms.PictureBox HeartPictureBox2;
        private System.Windows.Forms.PictureBox HeartPictureBox3;
    }
}
