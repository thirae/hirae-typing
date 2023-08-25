using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using System.Timers;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class TypingForm : Form
    {
        // 現在何問目かの変数
        private static int progression = 0;
        // シャッフルしたファイルを保存しておく配列
        private static string[][] randomAry;
        // 判定用char型の配列
        private char[] judgeAry;
        // 現在何文字目か用の変数
        private int num = 0;
        // 文字を置き換えるかどうか判断する変数
        private bool judge = false;
        // 一時的にテキストを保存しておくための変数
        private string str;
        // Stopwatchオブジェクトを作成する
        readonly private Stopwatch stopWatch = new Stopwatch();
        // Timer作成
        private System.Timers.Timer timer;
        // 時間保存用
        private static double keepTime;
        // fileパス
        private readonly string filePath;

        // コンストラクタ
        public TypingForm()
        {
            InitializeComponent();
            // ラベル非表示
            MissLabel.Visible = false;
            // インスタンス化
            TypingProblem typPro = new TypingProblem();
            // ファイル読み込み
            filePath = "TypingApp.CsvFile.TypingSheet.csv";
            List<string[]> lists = typPro.CsvReader(filePath);
            // 読み込んだファイルをシャッフルする
            randomAry = typPro.Random(lists);
            // 問題表示
            Problem(randomAry[progression]);

            // イベント間隔1000ミリ秒でタイマーを初期化
            timer = new System.Timers.Timer(1000);
            // タイマーにイベントを登録
            timer.Elapsed += OnTimedEvent;
            // タイマーを開始する
            timer.Start();
            // ストップウォッチを開始する
            stopWatch.Start();

            ContextMenu = new ContextMenu();
        }

        /// <summary>
        /// timeTextを返す
        /// </summary>
        /// <returns></returns>
        public static double getTime()
        {
            return keepTime;
        }

        /// <summary>
        /// 問題表示メソッド、引数の配列から表示させる
        /// </summary>
        /// <param name="ary">日本語とローマ字が入ってる配列</param>
        private void Problem(string[] ary)
        {
            // text書き換え
            JapaneseLabel.Text = ary[1];
            RomajiLabel.Text = ary[2];
            // stringをchar型の配列に
            judgeAry = RomajiLabel.Text.ToCharArray();
            // 次の問題
            progression++;
        }

        /// <summary>
        /// テキストを更新する。
        /// </summary>
        /// <param name="text">表示するテキスト。</param>
        private void UpdateText()
        {
            // ラベル更新
            TimeLabel.Text = stopWatch.Elapsed.TotalSeconds.ToString();
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

        [SecurityPermission(SecurityAction.Demand,
            Flags = SecurityPermissionFlag.UnmanagedCode)]
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
            /// keyを押した際のイベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void TypingText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // バックスペースの時は、イベントをキャンセルする
            if (e.KeyChar == '\b')
            {
                e.Handled = true;
                return;
            }

            // 文字を置き換える
            if (judge == true)
            {
                // 一時的に保存したテキストを代入
                TypingText.Text = str;
                // カーソルの位置を末尾に
                TypingText.Select(TypingText.Text.Length, 0);
                judge = false;
            }

            // 入力されたキーと同じなら
            if (e.KeyChar == judgeAry[num])
            {
                // missラベル非表示
                MissLabel.Visible = false;

                // 最後の文字なら
                if (judgeAry.Length == num + 1)
                {
                    // キー反映が切り替え後のため切り替え時は表示させない
                    e.Handled = true;
                    // 初期化
                    num = 0;
                    TypingText.ResetText();

                    // 最後の問題なら
                    if (progression == randomAry.Length)
                    {
                        // ストップウォッチを止める
                        stopWatch.Stop();
                        // タイマーを止める
                        timer.Stop();
                        // 最後にラベル更新
                        UpdateText();
                        // 保存
                        keepTime = double.Parse(TimeLabel.Text);
                        // 現画面を非表示
                        Visible = false;

                        // ScoreFormを表示
                        ScoreForm scr = new ScoreForm();
                        scr.Show();

                        return;
                    }

                    // 次の問題へ
                    Problem(randomAry[progression]);
                    return;
                }

                // 次の文字へ
                num++;
            }
            else
            {
                // 文字入力前のテキストを保存しておく
                str = TypingText.Text;
                // 次入力時置き換えるように
                judge = true;
                // missラベル表示
                MissLabel.Visible = true;
            }
        }

        /// <summary>
        /// スタートに戻るボタンを押す際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
