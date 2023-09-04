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
            this.RomajiLabel = new System.Windows.Forms.Label();
            this.TypingText = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MissLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.TimeTextLabel = new System.Windows.Forms.Label();
            this.RomajiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // JapaneseLabel
            // 
            this.JapaneseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JapaneseLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JapaneseLabel.Location = new System.Drawing.Point(77, 43);
            this.JapaneseLabel.Name = "JapaneseLabel";
            this.JapaneseLabel.Size = new System.Drawing.Size(910, 120);
            this.JapaneseLabel.TabIndex = 1;
            this.JapaneseLabel.Text = "日本語";
            this.JapaneseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RomajiLabel
            // 
            this.RomajiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomajiLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RomajiLabel.Location = new System.Drawing.Point(79, 163);
            this.RomajiLabel.Name = "RomajiLabel";
            this.RomajiLabel.Size = new System.Drawing.Size(910, 120);
            this.RomajiLabel.TabIndex = 3;
            this.RomajiLabel.Text = "Romaji";
            this.RomajiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TypingText
            // 
            this.TypingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypingText.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TypingText.Location = new System.Drawing.Point(255, 310);
            this.TypingText.Name = "TypingText";
            this.TypingText.Size = new System.Drawing.Size(568, 39);
            this.TypingText.TabIndex = 5;
            this.TypingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypingText_KeyPress);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(921, 43);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(22, 24);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "0";
            // 
            // MissLabel
            // 
            this.MissLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MissLabel.ForeColor = System.Drawing.Color.Red;
            this.MissLabel.Location = new System.Drawing.Point(435, 235);
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
            // TimeTextLabel
            // 
            this.TimeTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTextLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeTextLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeTextLabel.Location = new System.Drawing.Point(815, 43);
            this.TimeTextLabel.Name = "TimeTextLabel";
            this.TimeTextLabel.Size = new System.Drawing.Size(73, 30);
            this.TimeTextLabel.TabIndex = 9;
            this.TimeTextLabel.Text = "Time :";
            this.TimeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RomajiRichTextBox
            // 
            this.RomajiRichTextBox.Location = new System.Drawing.Point(54, 76);
            this.RomajiRichTextBox.Name = "RomajiRichTextBox";
            this.RomajiRichTextBox.ReadOnly = true;
            this.RomajiRichTextBox.Size = new System.Drawing.Size(255, 159);
            this.RomajiRichTextBox.TabIndex = 10;
            this.RomajiRichTextBox.Text = "";
            // 
            // TypingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RomajiRichTextBox);
            this.Controls.Add(this.TimeTextLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.MissLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TypingText);
            this.Controls.Add(this.RomajiLabel);
            this.Controls.Add(this.JapaneseLabel);
            this.Name = "TypingControl";
            this.Size = new System.Drawing.Size(1080, 500);
            this.Load += new System.EventHandler(this.TypingControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JapaneseLabel;
        private System.Windows.Forms.Label RomajiLabel;
        private System.Windows.Forms.TextBox TypingText;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MissLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label TimeTextLabel;
        private System.Windows.Forms.RichTextBox RomajiRichTextBox;
    }
}
