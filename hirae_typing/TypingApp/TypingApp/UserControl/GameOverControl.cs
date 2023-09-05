using System;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class GameOverControl : UserControl
    {
        public GameOverControl()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Paint(object sender, PaintEventArgs e)
        {
            // アニメーション要素の描画
            // 例: ピクチャーボックスに画像を描画する
            //e.Graphics.DrawImage(image, pictureBox1.Left, pictureBox1.Top, pictureBox1.Width, pictureBox1.Height);
        }
    }
}
