using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m4_lab_if敘述 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;

      int 降雨機率 = (int)(new Random().NextDouble() * 101); // 百分之
// fix #3  執行此程式, 觀察其執行結果
// fix #4  將下一行註解, 再執行此程式, 觀察其執行結果
      降雨機率 = (int)(new Random().NextDouble() * 50 + 50);
      Console.WriteLine();
      Console.WriteLine("如降雨機率 　達到 百分之50(含)以上, "
        + "put on the rain shoes");
      Console.WriteLine("還要 put on the rain coat ");
      Console.WriteLine("####################################################################");
      Console.Write("降雨機率 　為 百分之 ");
      Console.ForegroundColor = ConsoleColor.Yellow;
// fix #1  觀察下一行程式
      Console.WriteLine(降雨機率);
      Console.ForegroundColor = original;
      Console.WriteLine("????????????????????????????????????????????????????????????????????");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
// fix #2  觀察下面的if程式
      if (降雨機率 >= 50)
// fix #5  將下兩行變成一個block
// , 再執行此程式, 觀察其執行結果
        Console.WriteLine("套上雨鞋");
        Console.WriteLine("穿上雨衣");


      Console.ForegroundColor = original;
      Console.WriteLine();Console.WriteLine();
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("騎機車上班去");

      Console.ForegroundColor = original;
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
