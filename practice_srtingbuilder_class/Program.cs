using System;
using System.Text;

namespace practice_srtingbuilder_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder("ABC");
            //普通に出力
            Console.WriteLine(sb);
            sb.Append("DE");
            //配列の中身を追加できる
            sb.Append(new char[] { 'F', 'G' });
            Console.WriteLine(sb);
            //書式を指定して追加
            sb.AppendFormat("HI{0}{1}","J","K");
            Console.WriteLine(sb);
            //KをLに変換
            sb.Replace("K","L"); 
            Console.WriteLine(sb);
            //最初から３文字を削除
            sb.Remove(0,3);
            Console.WriteLine(sb);
            //長さはプロパティなのでそのまま呼び出してもOK
            var len = sb.Length;
            Console.WriteLine($"文字列は{sb}で長さは{len}です");
            Console.WriteLine("文字列は{0}で長さは{1}です",sb,sb.Length);
            //３番目に文字を挿入
            sb.Insert(2,"挿入");
            Console.WriteLine(sb);
            //全ての文字を削除
            sb.Clear();
            Console.WriteLine(sb);
        }
    }
}
