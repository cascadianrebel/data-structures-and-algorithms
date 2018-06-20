using System;
using System.Collections.Generic;

namespace MultiBracketValidation
{
    class Program
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

        public static bool MultiBracketValidation(string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
               if (input[i].ToString() is "(" || input[i].ToString() is ")")
                {
                    SquareList.Add(input[i].ToString());
                }
                if (input[i].ToString() is "{" || input[i].ToString() is "}")
                {
                    CurlyList.Add(input[i].ToString());
                }
                if (input[i].ToString() is "[" || input[i].ToString() is "]")
                {
                    RoundList.Add(input[i].ToString());
                }
            }
            ;
            Console.WriteLine(SquareList);
            Console.WriteLine(RoundList);
            Console.WriteLine(CurlyList);


            Console.Read();
            return true;
        }
    }
}
