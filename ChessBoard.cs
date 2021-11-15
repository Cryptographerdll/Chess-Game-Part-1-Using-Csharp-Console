using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Game
{
    public class ChessBoard
    {
        private String[,] chessBoard;

        public const int Dimension = 8;

        private PieceMoved pieceMoved;
        private Move move;

        public ChessBoard()
        {
            pieceMoved = new PieceMoved();
            move = new Move();

            chessBoard = new string[Dimension, Dimension];
            this.ChessBoardHorizoontalSymbol = "+---";
            this.ChessBoardVerticalSymbol = "| ";
        }

        public String ChessBoardHorizoontalSymbol { get; set; }
        public String ChessBoardVerticalSymbol { get; set; }
    }
}
