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
    case 37:
        KnockHandlers3.HandleKnock037();
        break;
    case 38:
        KnockHandlers3.HandleKnock038();
        break;
    case 39:
        KnockHandlers3.HandleKnock039();
        break;
    case 40:
        KnockHandlers3.HandleKnock040();
        break;
    case 41:
        KnockHandlers3.HandleKnock041();
        break;
    case 42:
        KnockHandlers3.HandleKnock042();
        break;
    case 43:
        KnockHandlers3.HandleKnock043();
        break;
    case 44:
        KnockHandlers3.HandleKnock044();
        break;
    case 45:
        KnockHandlers3.HandleKnock045();
        break;
    case 46:
        KnockHandlers3.HandleKnock046();
        break;
    case 47:
        KnockHandlers3.HandleKnock047();
        break;
    case 48:
        KnockHandlers3.HandleKnock048();
        break;
    case 49:
        KnockHandlers3.HandleKnock049();
        break;
    case 50:
        KnockHandlers3.HandleKnock050();
        break;
    //case 51:
    //    KnockHandlers3.HandleKnock051();
    //    break;
    //case 52:
    //    KnockHandlers3.HandleKnock052();
    //    break;
    //case 53:
    //    KnockHandlers3.HandleKnock053();
    //    break;
    //case 54:
    //    KnockHandlers3.HandleKnock054();
    //    break;
    //case 55:
    //    KnockHandlers3.HandleKnock055();
    //    break;
    //case 56:
    //    KnockHandlers3.HandleKnock056();
    //    break;
    //case 57:
    //    KnockHandlers3.HandleKnock057();
    //    break;
    //case 58:
    //    KnockHandlers3.HandleKnock058();
    //    break;
    //case 59:
    //    KnockHandlers3.HandleKnock059();
    //    break;
    //case 60:
    //    KnockHandlers3.HandleKnock060();
    //    break;
    //case 61:
    //    KnockHandlers3.HandleKnock061();
    //    break;
    //case 62:
    //    KnockHandlers3.HandleKnock062();
    //    break;
    //case 63:
    //    KnockHandlers3.HandleKnock063();
    //    break;
    //case 64:
    //    KnockHandlers3.HandleKnock064();
    //    break;
    //case 65:
    //    KnockHandlers3.HandleKnock065();
    //    break;
    //case 66:
    //    KnockHandlers3.HandleKnock066();
    //    break;
    //case 67:
    //    KnockHandlers3.HandleKnock067();
    //    break;
    //case 68:
    //    KnockHandlers3.HandleKnock068();
    //    break;
    //case 69:
    //    KnockHandlers3.HandleKnock069();
    //    break;
    //case 70:
    //    KnockHandlers3.HandleKnock070();
    //    break;
    //case 71:
    //    KnockHandlers3.HandleKnock071();
    //    break;
    //case 72:
    //    KnockHandlers3.HandleKnock072();
    //    break;
    //case 73:
    //    KnockHandlers3.HandleKnock073();
    //    break;
    //case 74:
    //    KnockHandlers3.HandleKnock074();
    //    break;
    //case 75:
    //    KnockHandlers3.HandleKnock075();
    //    break;
    //case 76:
    //    KnockHandlers3.HandleKnock076();
    //    break;
    //case 77:
    //    KnockHandlers3.HandleKnock077();
    //    break;
    //case 78:
    //    KnockHandlers3.HandleKnock078();
    //    break;
    //case 79:
    //    KnockHandlers3.HandleKnock079();
    //    break;
    //case 80:
    //    KnockHandlers3.HandleKnock080();
    //    break;
    //case 81:
    //    KnockHandlers3.HandleKnock081();
    //    break;
    //case 82:
    //    KnockHandlers3.HandleKnock082();
    //    break;
    //case 83:
    //    KnockHandlers3.HandleKnock083();
    //    break;
    //case 84:
    //    KnockHandlers3.HandleKnock084();
    //    break;
    //case 85:
    //    KnockHandlers3.HandleKnock085();
    //    break;
    //case 86:
    //    KnockHandlers3.HandleKnock086();
    //    break;
    //case 87:
    //    KnockHandlers3.HandleKnock087();
    //    break;
    //case 88:
    //    KnockHandlers3.HandleKnock088();
    //    break;
    //case 89:
    //    KnockHandlers3.HandleKnock089();
    //    break;
    //case 90:
    //    KnockHandlers3.HandleKnock090();
    //    break;
    //case 91:
    //    KnockHandlers3.HandleKnock091();
    //    break;
    //case 92:
    //    KnockHandlers3.HandleKnock092();
    //    break;
    //case 93:
    //    KnockHandlers3.HandleKnock093();
    //    break;
    //case 94:
    //    KnockHandlers3.HandleKnock094();
    //    break;
    //case 95:
    //    KnockHandlers3.HandleKnock095();
    //    break;
    //case 96:
    //    KnockHandlers3.HandleKnock096();
    //    break;
    //case 97:
    //    KnockHandlers3.HandleKnock097();
    //    break;
    //case 98:
    //    KnockHandlers3.HandleKnock098();
    //    break;
    //case 99:
    //    KnockHandlers3.HandleKnock099();
    //    break;
    //case 100:
    //    KnockHandlers3.HandleKnock100();
    //    break;
    default:
        Console.Error.WriteLine("想定外の値です。");
        break;
}