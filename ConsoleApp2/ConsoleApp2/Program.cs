using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1;
           switch()
            {
                case 'W':
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y);
                    break;
                case 'A':
                    Console.Write(" ");
                    break;
            }
        }
    }
}
