using System;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class ScoreForm : Form
    {
        // 日付取得
        private DateTime dt = DateTime.Now;
        // スコアを代入
        private double scoreTime;
        // コンストラクタ
        public ScoreForm()
        {
            InitializeComponent();
            scoreTime = TypingForm.getTime();
            ScoreLabel.Text += scoreTime;
            // csv書き込み
            TitleForm.rank.RegistScore(scoreTime, dt);
            // ランキング書き込み
            TitleForm.rank.RankView();
        }

        /// <summary>
        /// ランキングボタンを押した際のイベント、コントロール表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingButton_Click(object sender, EventArgs e)
        {
            // ランキングを表示
            TitleForm.rank.ShowDialog();
        }

        /// <summary>
        /// スタートに戻るボタンを押した際のイベント、再起動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// 終了ボタンを押した際のイベント、アプリを終了させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
