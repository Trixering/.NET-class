using System;


class Homework2
{
    static void Main(string[] args)
    {
        float sum_ch = 0.0f, sum_en = 0.0f, sum_ma = 0.0f;
        int count = 0;
        List<int[]> avg_list = new List<int[]>();
        string? sid_input;

        while (true)
        {
            int sid;

            while (true)
            {
                Console.Write("\n請輸入學號 (輸入0結束): ");
                sid_input = Console.ReadLine();

                if (int.TryParse(sid_input, out sid))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("輸入錯誤，請輸入整數學號。");
                }
            }

            if (sid == 0) break;

            while (true)
            {
                Console.Write("請輸入國文、英文、數學成績 (以空白分隔): ");
                string? input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("請一次輸入三個成績，用空白分隔。");
                    continue;
                }

                string[] scores = input.Split();

                if (scores.Length == 3)
                {
                    if (float.TryParse(scores[0], out float ch) &&
                       float.TryParse(scores[1], out float en) &&
                       float.TryParse(scores[2], out float ma))
                    {
                        float avg = (ch + en + ma) / 3;

                        avg_list.Add(new int[] { sid, (int)Math.Round(avg) });
                        count++;
                        sum_ch += ch;
                        sum_en += en;
                        sum_ma += ma;
                        break;
                    }
                }
                Console.WriteLine("請一次輸入三個成績，用空白分隔。");
            }
        }

        if (count > 0)
        {
            Console.WriteLine("\n=== 班級統計 ===");
            Console.WriteLine($"國文平均: {sum_ch / count:F2}");
            Console.WriteLine($"英文平均: {sum_en / count:F2}");
            Console.WriteLine($"數學平均: {sum_ma / count:F2}");

            Console.WriteLine("\n個人平均成績列表:");
            foreach (int[] item in avg_list)
            {
                Console.WriteLine($"學生{item[0]}  平均: {item[1]:F2}");
            }
        }
        else
        {
            Console.WriteLine("未輸入任何資料。");
        }
    }
}
