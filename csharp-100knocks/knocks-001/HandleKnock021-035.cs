using System;

static class KnockHandlers2
{
    // Q21: 配列 {1, 2, 3} を出力せよ (学習: 配列とforeach)
    public static void HandleKnock021()
    {
        int[] array = { 1, 2, 3 };
        Console.WriteLine("配列の要素:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Q22: 長さ5の配列（初期値0）を作成せよ (学習: 配列初期化)
    /// </summary>
    public static void HandleKnock022()
    {
        int[] array = new int[5] { 0, 0, 0, 0, 0 }; // 長さ5の配列を作成（初期値は0）
        Console.WriteLine("長さ5の配列の要素:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Q23: List の平均を求めよ (学習: ListとLINQ)
    /// </summary>
    public static void HandleKnock023()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        double average = list.Average();
        Console.WriteLine($"Listの平均: {average}");
    }

    public static void HandleKnock024()
    {
    }

    public static void HandleKnock025()
    {
    }

    public static void HandleKnock026()
    {
    }

    public static void HandleKnock027()
    {
    }

    public static void HandleKnock028()
    {
    }

    public static void HandleKnock029()
    {
    }

    public static void HandleKnock030()
    {
    }

    public static void HandleKnock031()
    {
    }

    public static void HandleKnock032()
    {
    }

    public static void HandleKnock033()
    {
    }

    public static void HandleKnock034()
    {
    }

    public static void HandleKnock035()
    {
    }
}
