using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class RankingForm : Form
    {
        // ファイルパス
        private string filePath = 
            "C: /Users/User/Desktop/hirae_typing/TypingApp/Ranking.csv";

        // csv代入用list
        List<string[]> lists;

        public RankingForm()
        {
            InitializeComponent();
            TypingProblem typing = new TypingProblem();

            // CSV取得
            lists = typing.CsvReader(filePath);
        }

        /// <summary>
        /// 順位登録
        /// </summary>
        /// <param name="score"></param>
        /// <param name="date"></param>
        public void RegistScore(double score, DateTime date)
        {
            if (score > 0.0f)
            {
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    // 「スコア,日付」の形式で書き込む
                    sw.WriteLine(score + "," + date);
                }
            }
        }

        public void RankView()
        {
            // Listをスコア昇順でソート
            var sorted = lists.OrderBy(e => e[1]);
            int rank = 0;
            foreach (var row in sorted)
            {
                // リストに登録
                RankingList.Items[rank].SubItems.Add(row[0]);
                RankingList.Items[rank].SubItems.Add(row[1]);
            }
        }
    }
}
