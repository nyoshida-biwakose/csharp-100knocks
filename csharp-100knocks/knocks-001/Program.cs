using System;
using System.Linq;
using knocks_001;

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
        KnockHandlers1.HandleKnock001();
        break;
    case 2:
        KnockHandlers1.HandleKnock002();
        break;
    case 3:
        KnockHandlers1.HandleKnock003();
        break;
    case 4:
        KnockHandlers1.HandleKnock004();
        break;
    case 5:
        KnockHandlers1.HandleKnock005();
        break;
    case 6:
        KnockHandlers1.HandleKnock006();
        break;
    case 7:
        KnockHandlers1.HandleKnock007();
        break;
    case 8:
        KnockHandlers1.HandleKnock008();
        break;
    case 9:
        KnockHandlers1.HandleKnock009();
        break;
    case 10:
        KnockHandlers1.HandleKnock010();
        break;
    case 11:
        KnockHandlers1.HandleKnock011();
        break;
    case 12:
        KnockHandlers1.HandleKnock012();
        break;
    case 13:
        KnockHandlers1.HandleKnock013();
        break;
    case 14:
        KnockHandlers1.HandleKnock014();
        break;
    case 15:
        KnockHandlers1.HandleKnock015();
        break;
    case 16:
        KnockHandlers1.HandleKnock016();
        break;
    case 17:
        KnockHandlers1.HandleKnock017();
        break;
    case 18:
        KnockHandlers1.HandleKnock018();
        break;
    case 19:
        KnockHandlers1.HandleKnock019();
        break;
    case 20:
        KnockHandlers1.HandleKnock020();
        break;
    case 21:
        KnockHandlers2.HandleKnock021();
        break;
    case 22:
        KnockHandlers2.HandleKnock022();
        break;
    case 23:
        KnockHandlers2.HandleKnock023();
        break;
    case 24:
        KnockHandlers2.HandleKnock024();
        break;
    case 25:
        KnockHandlers2.HandleKnock025();
        break;
    case 26:
        KnockHandlers2.HandleKnock026();
        break;
    case 27:
        KnockHandlers2.HandleKnock027();
        break;
    case 28:
        KnockHandlers2.HandleKnock028();
        break;
    case 29:
        KnockHandlers2.HandleKnock029();
        break;
    case 30:
        KnockHandlers2.HandleKnock030();
        break;
    case 31:
        KnockHandlers2.HandleKnock031();
        break;
    case 32:
        KnockHandlers2.HandleKnock032();
        break;
    case 33:
        KnockHandlers2.HandleKnock033();
        break;
    case 34:
        KnockHandlers2.HandleKnock034();
        break;
    case 35:
        KnockHandlers2.HandleKnock035();
        break;
    case 36:
        KnockHandlers3.HandleKnock036();
        break;
    case <= 100:
        Console.Error.WriteLine("処理未定義です。");
        break;
    default:
        Console.Error.WriteLine("想定外の値です。");
        break;
}