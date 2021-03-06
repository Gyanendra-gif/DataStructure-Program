using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structure_Programs.Utility
{
    class BalanceParanthesis
    {
        public static void Balance() 
        {
            string text = File.ReadAllText(@"E:\GitDemo\DataStructure-Program\Data Structure Programs\Data Structure Programs\Utility\Arithmatic.txt");
            string[] textArry = text.Split(" ");
            CustomStack<string> cs = new CustomStack<string>();
            foreach (var result in textArry)
            {
                if (result == "(")
                {
                    cs.Push("(");
                }
                else
                {
                    cs.Pop(")");
                }
                if (cs.Isempty())
                {
                    Console.WriteLine("Balaenced Parathensis");
                }
                else
                {
                    Console.WriteLine("Not a Balanced Parathensis");
                }
            }
        }
    }
}
