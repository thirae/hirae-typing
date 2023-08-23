using System;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class TitleForm : Form
    {
        // ランキングフォームを固定
        public static RankingForm rank;
        
        // コンストラクタ
        public TitleForm()
        {
            InitializeComponent();

            rank = new RankingForm();
            rank.Visible = false;
        }

        /// <summary>
        /// ランキングボタンを押した際のイベント、画面表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingButton_Click(object sender, EventArgs e)
        {
            // ランキングを表示
            rank.Visible = true;
        }

        /// <summary>
        /// プレイボタンを押した際のイベント、画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // 現画面を非表示
            Visible = false;

            // 次のformを表示
            TypingForm typ = new TypingForm();
            typ.Show();
        }
    }
}
