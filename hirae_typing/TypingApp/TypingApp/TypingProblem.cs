using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TypingApp
{
    public class TypingProblem
    {
        // ファイルパス
        private string fileName = "C: /Users/User/Desktop/hirae_typing/TypingApp/TypingSheet.csv";

        /// <summary>
        /// 引数のリストをシャッフルして配列で返すメソッド
        /// </summary>
        /// <param name="list"> すべての問題が入ったリストの引数</param>
        /// <returns></returns>
        public string[][] Random(List<string[]> list)
        {
            // シャッフル
            string[][] ary1 = list.OrderBy(i => Guid.NewGuid()).ToArray();

            return ary1;
        }

        /// <summary>
        /// ファイルのパスをゲットるためのメソッド
        /// </summary>
        /// <returns></returns>
        public string GetFileName()
        {
            return fileName;
        }

        /// <summary>
        /// csvファイル読み込み関数
        /// </summary>
        /// <param name="fileName"> 引数のファイルパスを読み込む</param>
        /// <returns></returns>
        public List<string[]> CsvReader(string fileName)
        {
            // ファイル読み込み
            StreamReader sr = new StreamReader(@fileName);
            List<string[]> lists = new List<string[]>();

            // 末尾まで繰り返す
            while (!sr.EndOfStream)
            {
                // CSVファイルの一行を読み込む
                string line = sr.ReadLine();

                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                string[] values = line.Split(',');

                // 配列からリストに格納する
                lists.Add(values);
            }
            return lists;
        }
    }
}
