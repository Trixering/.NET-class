using System;

class Program1
{
    static void Main(string[] args)
    {
        string[] data = { "\u5B78\u865F：11244151", "\u59D3\u540D：\u5289\u9053\u5143" };

        foreach (string item in data)
        {
            Console.WriteLine(item);
        }
    }
}
