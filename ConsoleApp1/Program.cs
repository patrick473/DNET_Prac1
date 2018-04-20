using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeEngine;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            ticTacToeEngine t = new ticTacToeEngine();

            Console.WriteLine(t.Board());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
