using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeEngine {

    public enum GameState { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }
    public class ticTacToeEngine {

        public GameState Gamestate { get; private set; } = GameState.PlayerOPlays;

        public ArrayList BoardState { get; set; } = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private int turn = 0;

        public String Board() {

        }
        public void changePlayer() {

            if (Gamestate == GameState.PlayerOPlays) {
                Gamestate = GameState.PlayerXPlays;
            }
            else if (Gamestate == GameState.PlayerXPlays) {
                Gamestate = GameState.PlayerOPlays;
            }


        }

      
        public bool ChooseCell(int cell) {
           
            if (BoardState.Contains(cell)) {
                return true;
               
            }
            else {
                return false;
            }
        }
        public String AssignCell(int cell) {
            String player = ""; 
            if (Gamestate == GameState.PlayerOPlays) {
                player = "O";
            }
            else if (Gamestate == GameState.PlayerXPlays) {
                player = "X";
            }
            if (player != "") {
                BoardState[BoardState.IndexOf(cell)] = player;
            }
            
            return player;
        }
        public bool CheckWinner() {
            turn++;
            if (decideWinner(0, 1, 2) ||
            decideWinner(3, 4, 5) ||
            decideWinner(6, 7, 8) ||
            decideWinner(0, 4, 8) ||
            decideWinner(2, 4, 6) ||
            decideWinner(0, 3, 6) ||
            decideWinner(1, 4, 7) ||
            decideWinner(2, 5, 8)) {
                setWinner();
                return true;
            }
            else if (turn == 9) {
                Gamestate = GameState.Equal;
                return true;
            }
            else {

                changePlayer();
                return false;
            }
          
        }
        public bool decideWinner(int a,int b, int c) {
            
            return BoardState[a] == BoardState[b] && BoardState[a] == BoardState[c];
        }
        public void setWinner() {
            if (Gamestate == GameState.PlayerOPlays) {
                Gamestate = GameState.PlayerOWins;
            }
            else if (Gamestate == GameState.PlayerXPlays) {
                Gamestate = GameState.PlayerXWins;
            }
        }
        public void reset() {
            BoardState = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Gamestate = GameState.PlayerOPlays;
        }

    }
}   
