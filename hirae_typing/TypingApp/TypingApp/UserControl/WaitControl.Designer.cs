namespace TypingApp
{
    partial class WaitControl
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
            this.EnterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EnterLabel.Location = new System.Drawing.Point(216, 225);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(516, 97);
            this.EnterLabel.TabIndex = 0;
            this.EnterLabel.Text = "Press Enter";
            this.EnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnterLabel);
            this.Name = "WaitControl";
            this.Size = new System.Drawing.Size(1080, 500);
            this.Load += new System.EventHandler(this.WaitControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLabel;
    }
}
