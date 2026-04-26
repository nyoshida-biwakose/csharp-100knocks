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


    }
}
