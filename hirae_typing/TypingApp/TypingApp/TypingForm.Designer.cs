namespace TypingApp
{
    partial class TypingForm
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
            this.JapaneseLabel = new System.Windows.Forms.Label();
            this.RomajiLabel = new System.Windows.Forms.Label();
            this.MissLabel = new System.Windows.Forms.Label();
            this.TypingText = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JapaneseLabel
            // 
            this.JapaneseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JapaneseLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JapaneseLabel.Location = new System.Drawing.Point(118, 105);
            this.JapaneseLabel.Name = "JapaneseLabel";
            this.JapaneseLabel.Size = new System.Drawing.Size(800, 120);
            this.JapaneseLabel.TabIndex = 0;
            this.JapaneseLabel.Text = "日本語";
            this.JapaneseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RomajiLabel
            // 
            this.RomajiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomajiLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RomajiLabel.Location = new System.Drawing.Point(120, 225);
            this.RomajiLabel.Name = "RomajiLabel";
            this.RomajiLabel.Size = new System.Drawing.Size(800, 120);
            this.RomajiLabel.TabIndex = 2;
            this.RomajiLabel.Text = "Romaji";
            this.RomajiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MissLabel
            // 
            this.MissLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MissLabel.ForeColor = System.Drawing.Color.Red;
            this.MissLabel.Location = new System.Drawing.Point(476, 391);
            this.MissLabel.Name = "MissLabel";
            this.MissLabel.Size = new System.Drawing.Size(100, 30);
            this.MissLabel.TabIndex = 3;
            this.MissLabel.Text = "Miss!";
            this.MissLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypingText
            // 
            this.TypingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypingText.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TypingText.Location = new System.Drawing.Point(303, 327);
            this.TypingText.Name = "TypingText";
            this.TypingText.Size = new System.Drawing.Size(458, 39);
            this.TypingText.TabIndex = 4;
            this.TypingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypingText_KeyPress);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(898, 24);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(111, 24);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "0.0000000";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(348, 441);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(356, 65);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "タイトルに戻る";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // TypingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 584);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TypingText);
            this.Controls.Add(this.MissLabel);
            this.Controls.Add(this.RomajiLabel);
            this.Controls.Add(this.JapaneseLabel);
            this.Name = "TypingForm";
            this.Text = "TypingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JapaneseLabel;
        private System.Windows.Forms.Label RomajiLabel;
        private System.Windows.Forms.Label MissLabel;
        private System.Windows.Forms.TextBox TypingText;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button ReturnButton;
    }
}