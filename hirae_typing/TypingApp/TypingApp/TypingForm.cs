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
        string str;

        // コンストラクタ
        public TypingForm()
        {
            InitializeComponent();
            // ラベル非表示
            MissLabel.Visible = false;
            // インスタンス化
            TypingProblem typPro = new TypingProblem();       
            // ファイル読み込み
            List<string[]> lists = typPro.CsvReader(typPro.GetFileName());

            // 読み込んだファイルをシャッフルする
            randomAry = typPro.Random(lists);

            // 問題表示
            Problem(randomAry[progression]);
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
        /// keyを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypingText_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                    // キー反映が遅いため問題切り替え時は表示させない
                    e.Handled = true;
                    // 初期化
                    num = 0;
                    TypingText.ResetText();
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
    }
}
