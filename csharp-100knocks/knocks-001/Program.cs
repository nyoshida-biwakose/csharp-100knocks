using System;
using System.Linq;

Console.Write("1から100 の整数を入力してください: ");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.Error.WriteLine("入力がありません。プログラムを終了します。");
    return;
}

if (!int.TryParse(input.Trim(), out var n) || n < 1 || n > 100)
{
    Console.Error.WriteLine("エラー: 1 から 100 の整数で入力してください。例: 42");
    return;
}

switch (n)
{
    case 1:
        HandleKnock001();
        break;
    case 2:
        HandleKnock002();
        break;
    case 3:
        HandleKnock003();
        break;
    case 4:
        HandleKnock004();
        break;
    case 5:
        HandleKnock005();
        break;
    case 6:
        HandleKnock006();
        break;
    case 7:
        HandleKnock007();
        break;
    case 8:
        HandleKnock008();
        break;
    case 9:
        HandleKnock009();
        break;
    case 10:
        HandleKnock010();
        break;
    case 11:
        HandleKnock011();
        break;
    case 12:
        HandleKnock012();
        break;
    case 13:
        HandleKnock013();
        break;
    case 14:
        HandleKnock014();
        break;
    case 15:
        HandleKnock015();
        break;
    case 16:
        HandleKnock016();
        break;
    case 17:
        HandleKnock017();
        break;
    case 18:
        HandleKnock018();
        break;
    case 19:
        HandleKnock019();
        break;
    case 20:
        HandleKnock020();
        break;
    case <= 100:
        Console.Error.WriteLine("処理未定義です。");
        break;
    default:
        Console.Error.WriteLine("想定外の値です。");
        break;
}

static void HandleKnock001()
{
    // Knock 001: Hello, World!
    Console.WriteLine("Hello, World!");
}

static void HandleKnock002()
{
    // Knock 002: int型の変数xに10を代入し出力せよ
    int x = 10;
    Console.WriteLine($"x = {x}");
}
static void HandleKnock003()
{
    // Knock 003: 2つの数の和を出力せよ（3と5）
    int a = 3;
    int b = 5;
    Console.WriteLine($"{a} + {b} = {a + b}");
}

// Knock 004 double型で割り算の結果を出力せよ（7 ÷ 2）	浮動小数点演算
static void HandleKnock004()
{
    double result = 7.0 / 2.0;
    Console.WriteLine($"7 ÷ 2 = {result}");
}

// knock 005 bool型でtrueを出力せよ	ブール型
static void HandleKnock005()
{
    bool isTrue = true;
    Console.WriteLine($"bool型の値: {isTrue}");
}

// Knock 006 Q6 if文でxが正なら「Positive」と出力せよ 条件分岐
static void HandleKnock006()
{
    int x = 5; // 例として5を使用
    if (x > 0)
    {
        Console.WriteLine("Positive");
    }
}

// knock 007 Q7 偶数/奇数を判定せよ 剰余演算子
static void HandleKnock007()
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
static void HandleKnock008()
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
static void HandleKnock009()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
    }
}

// Knock 010 Q10 whileで1から5を出力せよ while文
static void HandleKnock010()
{
    int i = 1;
    while (i <= 5)
    {
        Console.WriteLine(i);
        i++;
    }
}

// Knock 011 Q11 do-whileで1から5を出力せよ do-while文
static void HandleKnock011()
{
    int i = 1;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 5);
}

// Knock 012 Q12 三項演算子：x>=10なら"OK"、それ以外"NG" 三項演算子
static void HandleKnock012()
{
    int x = 15; // 例として15を使用
    string result = x >= 10 ? "OK" : "NG";
    Console.WriteLine(result);
}

// Knock 013 Q13 AND演算子で「5以上かつ10以下」 論理AND演算子
static void HandleKnock013()
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
static void HandleKnock014()
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
static void HandleKnock015()
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
static void HandleKnock016()
{
    bool flag = false; // 例としてfalseを使用
    Console.WriteLine(flag ? "ON" : "OFF");
}

// Knock 017 Q17 文字列連結 文字列操作
static void HandleKnock017()
{
    string str1 = "Hello";
    string str2 = "World";
    string result = str1 + " " + str2;
    Console.WriteLine(result);
}

// Knock 018 Q18 文字列補間 文字列補間
static void HandleKnock018()
{
    string name = "Alice";
    int age = 30;
    string result = $"Name: {name}, Age: {age}";
    Console.WriteLine(result);
}

// Knock 019 Q19 null合体 ??（nullなら"Default"） null合体演算子
static void HandleKnock019()
{
    string? input = null; // 例としてnullを使用
    string result = input ?? "Default";
    Console.WriteLine(result);
}

// Knock 020 Q20 is演算子でstring型判定 is演算子
static void HandleKnock020()
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