using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class TitleControl : UserControl
    {
        public TitleControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ランキングボタンを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingButton_Click(object sender, EventArgs e)
        {
            MainForm.rankCtr.Visible = true;
            Visible = false;
        }

        /// <summary>
        /// プレイボタンを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            MainForm.typingCtr.Visible = true;
            Visible = false;
        }
    }
}
