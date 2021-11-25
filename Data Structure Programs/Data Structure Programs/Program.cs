using System;

namespace Data_Structure_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Welcome to Data Structure Programs Press 1-Un Ordered List, 2-Exit");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
            case 1:
                    UnOrderedList.UnOrdered();
                break;
             case 2:
                    flag = false;
                    break;
            }
        }
    }
}
