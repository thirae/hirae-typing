using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TypingApp
{
    public class TypingProblem
    {
        private Assembly assembly;
        public TypingProblem()
        {
            // 現在の実行ファイル取得
            assembly = Assembly.GetExecutingAssembly();
        }
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
        /// 指定したファイル読み込み
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Stream GetStream(string filePath)
        {
            return assembly.GetManifestResourceStream(filePath);
        }

        /// <summary>
        /// csvファイル読み込み関数
        /// </summary>
        /// <param name="filePath"> 引数のファイルを読み込む</param>
        /// <returns></returns>
        public List<string[]> CsvReader(string filePath)
        {
            var stream = GetStream(filePath);
            List<string[]> lists = new List<string[]>();

            try
            {   // ファイル読み込み
                using (StreamReader sr = new StreamReader(stream))
                {
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
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException をキャッチ");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ArgumentException をキャッチ");
                Console.WriteLine(e.Message);
            }
            return lists;
        }

        /// <summary>
        /// csvファイル読み込み関数,パス指定
        /// </summary>
        /// <param name="filePath"> 引数のファイルを読み込む</param>
        /// <returns></returns>
        public List<string[]> PathCsvReader(string filePath)
        {
            List<string[]> lists = new List<string[]>();

            try
            {   // ファイル読み込み
                using (StreamReader sr = new StreamReader(filePath))
                {
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
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException をキャッチ");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ArgumentException をキャッチ");
                Console.WriteLine(e.Message);
            }
            return lists;
        }
    }
}
