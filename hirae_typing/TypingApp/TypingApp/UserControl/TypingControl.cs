using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Security.Permissions;
using System.Timers;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class TypingControl : UserControl
    {
        #region 変数
        // 現在何問目かの変数
        private static int progression = 0;
        // シャッフルしたファイルを保存しておく配列
        private static string[][] randomAry;
        // Timer作成
        private System.Timers.Timer timer;
        // 時間保存用
        private static int keepTime;
        // fileパス
        private string filePath;
        // 時刻用変数
        DateTime startDT;
        // 現在の文字のインデックス
        private int currentIndex = 0;
        // ライフ設定
        private int life = 3;
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TypingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 問題表示メソッド、引数の配列から表示させる
        /// </summary>
        /// <param name="ary">日本語とローマ字が入ってる配列</param>
        private void Problem(string[] ary)
        {
            // text書き換え
            JapaneseLabel.Text = ary[1];
            RomajiRichTextBox.Text = ary[2];
            // 文字を中央に
            RomajiRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // 次の問題
            progression++;
        }

        /// <summary>
        /// timeTextを返す
        /// </summary>
        /// <returns></returns>
        public int GetTime()
        {
            return keepTime;
        }

        /// <summary>
        /// テキストを更新する。
        /// </summary>
        /// <param name="text">表示するテキスト。</param>
        private void UpdateText()
        {
            TimeSpan timeSpan = DateTime.Now - startDT;
            keepTime = (int)timeSpan.TotalSeconds;
            // 経過時間をラベルに表示
            TimeLabel.Text = "Time : " + keepTime.ToString() + " 秒";
        }

        /// <summary>
        /// loadイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypingControl_Load(object sender, EventArgs e)
        {
            // フォーカスをあてる
            RomajiRichTextBox.Focus();
            // ラベル非表示
            MissLabel.Visible = false;
            // インスタンス化
            TypingProblem typPro = new TypingProblem();
            // ファイル読み込み
            filePath = "TypingApp.CsvFile.TypingSheet.csv";
            List<string[]> lists = typPro.CsvReader(filePath);

            ContextMenu = new ContextMenu();

            // 読み込んだファイルをシャッフルする
            randomAry = typPro.Random(lists);
            // 問題表示
            Problem(randomAry[progression]);
            // イベント間隔1000ミリ秒でタイマーを初期化
            timer = new System.Timers.Timer(1000);
            // 現在の時刻を取得
            startDT = DateTime.Now;
            // タイマーにイベントを登録
            timer.Elapsed += OnTimedEvent;
            // タイマーを開始する
            timer.Start();
            // リソースから画像を読み込む
            Image image = Properties.Resources.oneheart;
            HeartPictureBox1.Image = image;
            HeartPictureBox2.Image = image;
            HeartPictureBox3.Image = image;
        }

        /// <summary>
        /// タイマーに呼び出されるイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {

            // 違うスレッドのためInvokeメソッドを使用
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateText));
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 貼り付け無効
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        [SecurityPermission(SecurityAction.Demand,Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Ctrl+VとShift+Insertを無効にする
            if (((keyData & Keys.Control) == Keys.Control &&
            (keyData & Keys.KeyCode) == Keys.V) ||
            ((keyData & Keys.Shift) == Keys.Shift &&
            (keyData & Keys.KeyCode) == Keys.Insert))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        /// <summary>
        /// 入力イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RomajiRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // バックスペースとエンターキーのキーイベントを無効にする
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                return;
            }

            if (currentIndex < RomajiRichTextBox.Text.Length && e.KeyChar == RomajiRichTextBox.Text[currentIndex])
            {
                // MissLabelが表示されているなら
                if (MissLabel.Visible) MissLabel.Visible = false;
                // 正しい文字を打った場合、文字の色を変更
                RomajiRichTextBox.SelectionStart = currentIndex;
                RomajiRichTextBox.SelectionLength = 1;
                RomajiRichTextBox.SelectionColor = Color.Green; // 正しい文字の色
                currentIndex++;
                e.Handled = true;

                // 全ての文字を正しく打った場合
                if (currentIndex == RomajiRichTextBox.Text.Length)
                {
                    // 初期化
                    currentIndex = 0;
                    RomajiRichTextBox.ResetText();

                    // 最後の問題なら
                    if (progression == randomAry.Length)
                    {
                        // タイマーを止める
                        timer.Stop();
                        // 最後に更新
                        UpdateText();
                        // 現画面を非表示
                        Visible = false;
                        // ScoreFormを表示
                        MainForm.scoreCtr.Visible = true;

                        return;
                    }
                    // 次の問題へ
                    Problem(randomAry[progression]);
                    return;
                }
            }
            else
            {
                switch (life)
                {
                    case 3:
                        HeartPictureBox1.Visible = false;
                        break;
                    case 2:
                        HeartPictureBox2.Visible = false;
                        break;
                    case 1:
                        HeartPictureBox3.Visible = false;
                        break;
                    default:
                        break;
                }
                life--;
                e.Handled = true;
                // missラベル表示
                MissLabel.Visible = true;
                if (life <= 0)
                {
                    Visible = false;
                    MainForm.overCtr.Visible = true;
                    return;
                }
            }
        }

        /// <summary>
        /// 再起動イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }
    }
}
