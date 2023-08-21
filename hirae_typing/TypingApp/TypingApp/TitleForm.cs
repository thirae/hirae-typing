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
    public partial class TitleForm : Form
    {
        // コンストラクタ
        public TitleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ランキングボタンを押した際のイベント、画面表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingButton_Click(object sender, EventArgs e)
        {
            //後々
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

            // Form2を表示
            TypingForm typ = new TypingForm();
            typ.Show();
        }
    }
}
