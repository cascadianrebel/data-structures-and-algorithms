using System;
using System.Collections.Generic;

namespace MultiBracketValidation
{
    public class Program
    {
        public static string bracket1 = "{}{Code}[Fellows](())";
        public static string bracket2 = "[({}]";

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBracketValidation(bracket1);
        }

        
       public static List<string> SquareList = new List<string>();
       public static  List<string> CurlyList = new List<string>();
       public static List<string> RoundList = new List<string>();

        public static void SeparateBrackets(string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() is "(" || input[i].ToString() is ")")
                {
                    RoundList.Add(input[i].ToString());
                }
                if (input[i].ToString() is "{" || input[i].ToString() is "}")
                {
                    CurlyList.Add(input[i].ToString());
                }
                if (input[i].ToString() is "[" || input[i].ToString() is "]")
                {
                    SquareList.Add(input[i].ToString());
                }
            }
            ;
        }
        public static bool SameReversed (string input)
        {
            SeparateBrackets(input);

            string SquareStrings = string.Join("", SquareList.ToArray());

            string CurlyStrings = string.Join("", CurlyList.ToArray());

            string RoundStrings = string.Join("", RoundList.ToArray());

            RoundList.Reverse();
            SquareList.Reverse();
            CurlyList.Reverse();

            string SquareStringsReverse = string.Join("", SquareList.ToArray());

            string CurlyStringsReverse = string.Join("", CurlyList.ToArray());

            string RoundStringsReverse = string.Join("", RoundList.ToArray());

            if (RoundStrings == RoundStringsReverse && SquareStrings == SquareStringsReverse && CurlyStrings == CurlyStringsReverse)
            {
                 return true;                   
            }
            return false;
        }

        public static bool MultiBracketValidation(string input)
        {

            Console.WriteLine(SquareList);
            Console.WriteLine(RoundList);
            Console.WriteLine(CurlyList);


            Console.Read();
            return true;
        }
    }
}
