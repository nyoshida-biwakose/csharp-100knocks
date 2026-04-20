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