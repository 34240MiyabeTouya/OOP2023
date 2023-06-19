using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();　
            var lines = File.ReadAllLines(filePath); //ファイルからすべてのデータを読み込む
            foreach (string line in lines) {//すべての行から一行ずつ取り出す
                var items = line.Split(',');　//区切りで項目別に分ける
                //scoreインスタンスを生成
                var score = new Student { Name = items[0], Subject = items[1], Score = int.Parse(items[2]) };
                scores.Add(score);　//scoreインスタンスをコレクションに追加
            }
            return scores;
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {
                if (dict.ContainsKey(score.Subject)) {
                    dict[score.Subject] += score.Score;//教科が既に存在する
                } else {
                    dict[score.Subject] = score.Score;//教科が存在しない
                }
            }
            return dict;
        }
    }
}
