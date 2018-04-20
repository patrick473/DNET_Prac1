using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeEngine;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ticTacToeEngine t = new ticTacToeEngine();
        public Form1()
        {
            
            InitializeComponent();
            label2.Text = t.Gamestate.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //RESET
        private void button10_Click(object sender, EventArgs e) {
            t.reset();
            label2.Text = t.Gamestate.ToString();
            resetgrid();
        }
        //GRID
        private void button_Click(object sender, EventArgs e) {
            Button button = sender as Button;
            int cell;
            if(Int32.TryParse(button.Text,out cell)) {
                if (t.ChooseCell(cell)) {
                    button.Text = t.AssignCell(cell);


                    t.CheckWinner();
                    label2.Text = t.Gamestate.ToString();
                }
            }
        }
        private String formatBoard() {
            StringBuilder sb = new StringBuilder();
            foreach (object obj in t.BoardState) sb.Append(obj + ",");
            return sb.ToString();
        }
        private void resetgrid() {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";


        }
    }
}
