using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class ScoreControl : UserControl
    {
        // スコアを代入
        private double scoreTime;

        public ScoreControl()
        {
            InitializeComponent();
        }

        private void ScoreControl_Load(object sender, EventArgs e)
        {
            // 日付取得
            DateTime dt = DateTime.Now;
            scoreTime = MainForm.typingCtr.getTime();
            ScoreLabel.Text += scoreTime;
            // csv書き込み
            MainForm.rankCtr.RegistScore(scoreTime, dt);
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            // ランキングを表示
            MainForm.rankCtr.Visible = true;
            Visible = false;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
