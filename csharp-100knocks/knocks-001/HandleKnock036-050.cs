using System;
using System.Collections.Generic;
using System.Text;

namespace knocks_001
{
    internal static class KnockHandlers3
    {
        /// <summary>
        /// Q36: Add(a, b) メソッドを定義せよ(学習: メソッド定義)
        /// </summary>
        internal static void HandleKnock036()
        {
            int a = 5;
            int b = 10;
            int result = Add(a, b);
            Console.WriteLine($"Add({a}, {b}) = {result}");
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }


        //Q37: 既定値を持つ引数を作成せよ (学習: デフォルトパラメータ)
        internal static void HandleKnock037()
        {
            int result1 = Multiply(5); // bは既定値の2が使用される
            int result2 = Multiply(5, 3); // bに3を指定
            Console.WriteLine($"Multiply(5) = {result1}"); // 出力: 10
            Console.WriteLine($"Multiply(5, 3) = {result2}"); // 出力: 15
        }

        private static int Multiply(int a, int b = 2)
        {
            return a * b;
        }


        //Q38: out パラメータを使用して結果を返せ(学習: outパラメータ)
        internal static void HandleKnock038()
        {
            int a = 5;
            int b = 10;
            if (TryDivide(a, b, out double result))
            {
                Console.WriteLine($"TryDivide({a}, {b}) = {result}"); // 出力: 0.5
            }
            else
            {
                Console.WriteLine($"TryDivide({a}, {b}) は失敗しました。");
            }
        }

        private static bool TryDivide(int a, int b, out double result)
        {
            if (b == 0)
            {
                result = 0; // 失敗時の既定値
                return false;
            }
            result = (double)a / b;
            return true;
        }

        //Q39: ref パラメータを使用して値を2倍にせよ(学習: refパラメータ)

        internal static void HandleKnock039()
        {
            int value = 5;
            Console.WriteLine($"元の値: {value}"); // 出力: 5
            DoubleValue(ref value);
            Console.WriteLine($"2倍にした値: {value}"); // 出力: 10
        }

        private static void DoubleValue(ref int value)
        {
            value *= 2;
        }

        //Q40: static メソッドを定義せよ(学習: static修飾子)
        internal static void HandleKnock040()
        {
            int a = 5;
            int b = 10;
            int result = AddStatic(a, b);
            Console.WriteLine($"AddStatic({a}, {b}) = {result}");
        }

        private static int AddStatic(int a, int b)
        {
            return a + b;
        }

        //Q41: オーバーロードメソッドを実装せよ(学習: メソッドオーバーロード)
        internal static void HandleKnock041()
        {
            int a = 5;
            int b = 10;
            int result1 = Add(a, b);
            double result2 = Add(a, b, 2.5);
            Console.WriteLine($"Add({a}, {b}) = {result1}");
            Console.WriteLine($"Add({a}, {b}, 2.5) = {result2}");
        }
        private static double Add(int a, int b, double c)
        {
            return a + b + c;
        }

        //Q42: 名前付き引数を使用してメソッドを呼び出せ(学習: 名前付き引数)
        internal static void HandleKnock042()
        {
            int result = AddNumbers(number1: 5, number2: 10);
            Console.WriteLine($"AddNumbers(number1: 5, number2: 10) = {result}");
        }

        private static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        //Q43: params を使用して合計を求めよ(学習: 可変長引数)
        internal static void HandleKnock043()
        {
            int sum1 = Sum(1, 2, 3); // 出力: 6
            int sum2 = Sum(4, 5);    // 出力: 9
            Console.WriteLine($"Sum(1, 2, 3) = {sum1}");
            Console.WriteLine($"Sum(4, 5) = {sum2}");
        }
        private static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        //Q44: 式本体メンバーで記述せよ(学習: 式本体メンバー)
        internal static void HandleKnock044()
        {
            int a = 5;
            int b = 10;
            int result = AddExpressionBody(a, b);
            Console.WriteLine($"AddExpressionBody({a}, {b}) = {result}");
        }
        private static int AddExpressionBody(int a, int b) => a + b;

        //Q45: ローカル関数を定義せよ(学習: ローカル関数)
        internal static void HandleKnock045()
        {
            int a = 5;
            int b = 10;
            int result = AddWithLocalFunction(a, b);
            Console.WriteLine($"AddWithLocalFunction({a}, {b}) = {result}");
        }
        private static int AddWithLocalFunction(int a, int b)
        {
            int LocalAdd() => a + b; // ローカル関数
            return LocalAdd();
        }

        //Q46: Func を使用した加算器を作成せよ(学習: Funcデリゲート)
        internal static void HandleKnock046()
        {
            Func<int, int, int> addFunc = (x, y) => x + y; // Funcデリゲートを使用して加算器を作成
            int a = 5;
            int b = 10;
            int result = addFunc(a, b);
            Console.WriteLine($"addFunc({a}, {b}) = {result}"); // 出力: 15
        }

        //Q47: Action を使用して出力せよ(学習: Actionデリゲート)

        internal static void HandleKnock047()
        {
            Action<string> printAction = message => Console.WriteLine(message); // Actionデリゲートを使用して出力アクションを作成
            printAction("Hello, World!"); // 出力: Hello, World!
        }

        //Q48: Predicate と FindAll を使用せよ(学習: Predicateデリゲート)
        internal static void HandleKnock048()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Predicate<int> isEven = number => number % 2 == 0; // 偶数を判定するPredicateデリゲート
            List<int> evenNumbers = numbers.FindAll(isEven); // FindAllを使用して偶数を抽出
            Console.WriteLine("偶数のリスト:");
            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even); // 出力: 2, 4, 6
            }
        }

        //Q49: クロージャ（カウンタ）を実装せよ(学習: クロージャ)
        internal static void HandleKnock049()
        {
            Func<int> CreateCounter()
            {
                int count = 0; // クロージャでキャプチャされる変数
                return () => ++count; // カウンタをインクリメントして返すラムダ式
            }
            var counter = CreateCounter(); // カウンタを作成
            Console.WriteLine(counter()); // 出力: 1
            Console.WriteLine(counter()); // 出力: 2
            Console.WriteLine(counter()); // 出力: 3
        }


        //Q50: ref で Swap を実装し、値渡しとの違いを説明せよ(学習: 参照渡しの理解)
        internal static void HandleKnock050()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
