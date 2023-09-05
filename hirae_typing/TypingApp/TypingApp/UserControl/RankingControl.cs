using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class RankingControl : UserControl
    {
        TypingProblem typing;

        // csv代入用list
        private List<string[]> lists;

        // ファイルパス
        private readonly string filePath;

        private string rankText;

        public RankingControl()
        {
            InitializeComponent();

            typing = new TypingProblem();

            filePath = "./CsvFile/Ranking.csv";
            // CSV取得(ランキング)
            lists = typing.PathCsvReader(filePath);

            rankText = "位";

            RankView();
        }

        /// <summary>
        /// csv書き込み
        /// </summary>
        /// <param name="score"></param>
        /// <param name="date"></param>
        public void RegistScore(double score, DateTime date)
        {
            // 昇順でソート
            var sorted = lists.OrderBy(e => e[0]);
            int rank = 1;
            foreach (var row in sorted)
            {
                if (score < double.Parse(row[0])) break;
                rank++;
            }
            // 10番以内なら
            if (rank <= 10)
            {
                //.\Ranking.csv
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    // 「スコア,日付」の形式で書き込む
                    sw.WriteLine(score + "," + date);
                }
                // CSV取得
                lists = typing.PathCsvReader(filePath);
                RankView();
            }
        }

        /// <summary>
        /// リストにcsvから登録
        /// </summary>
        public void RankView()
        {
            // リストのサブアイテムをクリア
            RankingList.Items.Clear();
            // Listをスコア昇順でソート
            var sorted = lists.OrderBy(e => e[0]);
            int rank = 0;
            try
            {
                // ソートしたものを上から登録
                foreach (var row in sorted)
                {
                    if (rank > 9) break;

                    // 新しいListViewItemを作成
                    var item = new ListViewItem((rank + 1).ToString() + rankText); // ランキング順位
                    item.SubItems.Add(row[0]); // スコア
                    item.SubItems.Add(row[1]); // 日付

                    // リストに登録
                    RankingList.Items.Add(item);
                    rank++;
                }
                // リストビューのフォントサイズを変更
                RankingList.Font = new Font("Arial", 12); // ここでフォントとサイズを調整
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException をキャッチ");
                Console.WriteLine(e.Message);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
