using System;

namespace TicTacToe
{
    internal class Game
    {
        private string currentToken;
        private string[,] matrixWinner = new string[,] { 
            { "X", "X","X" },
            { "", "",""},
            { "", "", "" } };

        private string[,] matrix = new string[,] {
            { "", "","" },
            { "O", "O",""},
            { "", "", "" } };
        public void Play(int x, int y,string token)
        {
            currentToken = token;
            matrix[x, y] = currentToken;
        }
        
        public bool IsGameOver()
        {
            var pos1 = matrix.GetValue(0, 0).ToString();
            var pos2 = matrix.GetValue(0, 1).ToString();
            var pos3 = matrix.GetValue(0, 2).ToString();
            var pos4 = matrix.GetValue(1, 0).ToString();
            var pos5 = matrix.GetValue(1, 1).ToString();
            var pos6 = matrix.GetValue(1, 2).ToString();
            var pos7 = matrix.GetValue(2, 0).ToString();
            var pos8 = matrix.GetValue(2, 1).ToString();
            var pos9 = matrix.GetValue(2, 2).ToString();

            return (String.Compare(pos1,pos2)==0)&& (String.Compare(pos1, pos3) == 0);
        }

        public string GetCurrentPlayer()
        {
            return currentToken == "X" ? "O" : "X";
        }
    }
}