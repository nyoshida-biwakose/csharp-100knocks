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

    /// <summary>
    /// Q24: Dictionary で英和辞書を1件作成せよ (学習: Dictionary)
    /// </summary>
    public static void HandleKnock024()
    {
        Dictionary<string, string> englishToJapanese = new Dictionary<string, string>
        {
            { "Hello", "こんにちは" }
        };
        Console.WriteLine("英和辞書の内容:");
        foreach (var kvp in englishToJapanese)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }
    }

    /// <summary>
    /// Q25: Queue の Enqueue/Dequeue を実行せよ (学習: Queue)
    /// </summary>
    public static void HandleKnock025()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        Console.WriteLine("Queueの内容:");
        while (queue.Count > 0)
        {
            string item = queue.Dequeue();
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// Q26: Stack の Push/Pop を実行せよ (学習: Stack)
    /// </summary>
    public static void HandleKnock026()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        Console.WriteLine("Stackの内容:");
        while (stack.Count > 0)
        {
            string item = stack.Pop();
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// Q27: 配列を逆順にせよ (学習: Array.Reverse)
    /// </summary>
    public static void HandleKnock027()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("元の配列:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
        Array.Reverse(array);
        Console.WriteLine("逆順の配列:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Q28: 配列をソートせよ (学習: Array.Sort)
    /// </summary>
    public static void HandleKnock028()
    {
        int[] array = { 5, 3, 1, 4, 2 };
        Console.WriteLine("元の配列:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
        Array.Sort(array);
        Console.WriteLine("ソート後の配列:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Q29: List に 3 が含まれるか確認せよ (学習: Contains)
    /// </summary>
    public static void HandleKnock029()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        List<int> list = new List<int>(array);
        bool containsThree = list.Contains(3);
        Console.WriteLine($"Listに3が含まれるか: {containsThree}");
    }

    /// <summary>
    /// Q30: TryGetValue を使用した安全なDictionary操作 (学習: TryGetValue)
    /// </summary>
    public static void HandleKnock030()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "Hello", "こんにちは" }
        };

        if (dictionary.TryGetValue("Hello", out var value))
        {
            Console.WriteLine($"キー 'Hello' の値: {value}");
        }
        else
        {
            Console.WriteLine("キー 'Hello' は存在しません。");
        }
    }

    /// <summary>
    /// Q31: HashSet で重複排除を行え (学習: HashSet)
    /// </summary>
    public static void HandleKnock031()
    {
        List<int> listWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        HashSet<int> uniqueSet = new HashSet<int>(listWithDuplicates);
        Console.WriteLine("重複排除後の要素:");
        foreach (int element in uniqueSet)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Q32: 最大値を求めよ (学習: Max拡張メソッド)
    /// </summary>
    public static void HandleKnock032()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        int maxValue = list.Max();
        Console.WriteLine($"Listの最大値: {maxValue}");
    }

    /// <summary>
    /// Q33: 最小値を求めよ (学習: Min拡張メソッド)
    /// </summary>
    public static void HandleKnock033()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        int minValue = list.Min();
        Console.WriteLine($"Listの最小値: {minValue}");
    }

    /// <summary>
    /// Q34: List を配列に変換せよ (学習: ToArray)
    /// </summary>
    public static void HandleKnock034()
    {
        List<int> list = [1, 2, 3, 4, 5];
        int[] array = [.. list];
        Console.WriteLine("Listを配列に変換した結果:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Q35: 配列を List に変換せよ (学習: ToList)
    /// </summary>
    public static void HandleKnock035()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        List<int> list = [.. array];
        Console.WriteLine("配列をListに変換した結果:");
        foreach (int element in list)
        {
            Console.WriteLine(element);
        }
    }
}
