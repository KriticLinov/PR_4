using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Направление: ");
            String c = Console.ReadLine();
            Console.Write("Операция: ");
            int n = int.Parse(Console.ReadLine());

            switch (c)
            {
                case "С":

                    switch (n)
                    {
                        case 1:
                            c = "З";
                            break;
                        case 0:
                            c = "С";
                            break;
                        case -1:
                            c = "В";
                            break;
                    }
                    break;

                case "В":
                    switch (n)
                    {
                        case 1:
                            c = "С";
                            break;
                        case 0:
                            c = "В";
                            break;
                        case -1:
                            c = "Ю";
                            break;
                    }
                    break;
                case "Ю":
                    switch (n)
                    {
                        case 1:
                            c = "В";
                            break;
                        case 0:
                            c = "Ю";
                            break;
                        case -1:
                            c = "З";
                            break;
                    }
                    break;
                default:
                    switch (n)
                    {
                        case 1:
                            c = "Ю";
                            break;
                        case 0:
                            c = "З";
                            break;
                        case -1:
                            c = "С";
                            break;
                    }
                    break;
            }
            Console.Write("Результат: " + c);
            Console.ReadKey();
        }
    }
}
