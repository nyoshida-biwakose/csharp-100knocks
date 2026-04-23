using System;

static class KnockHandlers1
{
    public static void HandleKnock001()
    {
        // Knock 001: Hello, World!
        Console.WriteLine("Hello, World!");
    }

    public static void HandleKnock002()
    {
        // Knock 002: int型の変数xに10を代入し出力せよ
        int x = 10;
        Console.WriteLine($"x = {x}");
    }

    public static void HandleKnock003()
    {
        // Knock 003: 2つの数の和を出力せよ（3と5）
        int a = 3;
        int b = 5;
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    // Knock 004 double型で割り算の結果を出力せよ（7 ÷ 2）	浮動小数点演算
    public static void HandleKnock004()
    {
        double result = 7.0 / 2.0;
        Console.WriteLine($"7 ÷ 2 = {result}");
    }

    // knock 005 bool型でtrueを出力せよ	ブール型
    public static void HandleKnock005()
    {
        bool isTrue = true;
        Console.WriteLine($"bool型の値: {isTrue}");
    }

    // Knock 006 Q6 if文でxが正なら「Positive」と出力せよ 条件分岐
    public static void HandleKnock006()
    {
        int x = 5; // 例として5を使用
        if (x > 0)
        {
            Console.WriteLine("Positive");
        }
    }

    // knock 007 Q7 偶数/奇数を判定せよ 剰余演算子
    public static void HandleKnock007()
    {
        int number = 10; // 例として10を使用
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} は偶数です。");
        }
        else
        {
            Console.WriteLine($"{number} は奇数です。");
        }
    }

    // knock 008 Q8 switchで 1→"One", 2→"Two", その他→"Other" switch文
    public static void HandleKnock008()
    {
        int n = 2; // 例として2を使用
        switch (n)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            default:
                Console.WriteLine("Other");
                break;
        }
    }

    // Knock 009 Q9 forで1から5を出力せよ for文
    public static void HandleKnock009()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Knock 010 Q10 whileで1から5を出力せよ while文
    public static void HandleKnock010()
    {
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    // Knock 011 Q11 do-whileで1から5を出力せよ do-while文
    public static void HandleKnock011()
    {
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 5);
    }

    // Knock 012 Q12 三項演算子：x>=10なら"OK"、それ以外"NG" 三項演算子
    public static void HandleKnock012()
    {
        int x = 15; // 例として15を使用
        string result = x >= 10 ? "OK" : "NG";
        Console.WriteLine(result);
    }

    // Knock 013 Q13 AND演算子で「5以上かつ10以下」 論理AND演算子
    public static void HandleKnock013()
    {
        int x = 7; // 例として7を使用
        if (x >= 5 && x <= 10)
        {
            Console.WriteLine($"{x} は5以上かつ10以下です。");
        }
        else
        {
            Console.WriteLine($"{x} は条件を満たしません。");
        }
    }

    // Knock 014 Q14 OR演算子で「0または10」 論理OR演算子
    public static void HandleKnock014()
    {
        int x = 0; // 例として0を使用
        if (x == 0 || x == 10)
        {
            Console.WriteLine($"{x} は0または10です。");
        }
        else
        {
            Console.WriteLine($"{x} は条件を満たしません。");
        }
    }

    // Knock 015 Q15 NOT演算子：flagがfalseなら"OFF" 論理NOT演算子
    public static void HandleKnock015()
    {
        bool flag = false; // 例としてfalseを使用
        if (!flag)
        {
            Console.WriteLine("OFF");
        }
        else
        {
            Console.WriteLine("ON");
        }
    }

    // Knock 016 Q15 NOT演算子：flagがfalseなら"OFF" 論理NOT演算子
    public static void HandleKnock016()
    {
        bool flag = false; // 例としてfalseを使用
        Console.WriteLine(flag ? "ON" : "OFF");
    }

    // Knock 017 Q17 文字列連結 文字列操作
    public static void HandleKnock017()
    {
        string str1 = "Hello";
        string str2 = "World";
        string result = str1 + " " + str2;
        Console.WriteLine(result);
    }

    // Knock 018 Q18 文字列補間 文字列補間
    public static void HandleKnock018()
    {
        string name = "Alice";
        int age = 30;
        string result = $"Name: {name}, Age: {age}";
        Console.WriteLine(result);
    }

    // Knock 019 Q19 null合体 ??（nullなら"Default"） null合体演算子
    public static void HandleKnock019()
    {
        string? input = null; // 例としてnullを使用
        string result = input ?? "Default";
        Console.WriteLine(result);
    }

    // Knock 020 Q20 is演算子でstring型判定 is演算子
    public static void HandleKnock020()
    {
        object obj = "This is a string"; // 例としてstringを使用
        if (obj is string str)
        {
            Console.WriteLine($"objはstring型で、値は: {str}");
        }
        else
        {
            Console.WriteLine("objはstring型ではありません。");
        }
    }
}
