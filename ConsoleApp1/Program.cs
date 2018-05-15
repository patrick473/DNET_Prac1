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

            String input = Console.ReadLine();

            while (input != "exit") {
                if (input != "reset") {


                    int value;
                    if (int.TryParse(input, out value)) {
                        if (t.ChooseCell(value)) {
                            t.AssignCell(value);


                            t.CheckWinner();
                            Console.WriteLine(t.Board());
                        }


                        
                        input = Console.ReadLine();
                    }


                }
                else {
                    t.reset();
                    Console.WriteLine(t.Board());
                    input = Console.ReadLine();
                }
            }
        }
    }
}
