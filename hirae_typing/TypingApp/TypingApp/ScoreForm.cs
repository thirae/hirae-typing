using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class ScoreForm : Form
    {
        // コンストラクタ
        public ScoreForm()
        {
            InitializeComponent();
            // スコアを代入
            string scoreTime;
            scoreTime = TypingForm.getTime();
            ScoreLabel.Text += scoreTime;
        }

        /// <summary>
        /// ランキングボタンを押した際のイベント、コントロール表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingButton_Click(object sender, EventArgs e)
        {
            
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
