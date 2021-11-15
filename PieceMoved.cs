using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Game
{
   public class PieceMoved
    {
        public const char PieceName = 'P'; 
        public const char Space = ' ';
        public static char[ , ] pawns;

        public PieceMoved()
        {
            pawns = new char[ChessBoard.Dimension, ChessBoard.Dimension];
        }
    }
}
