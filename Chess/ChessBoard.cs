using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public class ChessBoard
	{
		private string[,] chessBoard;
		public const int DIMENSION = 8; // orginal 8x8 board

		private Pawn pawn;
		private Move move;

		public ChessBoard()
		{
			pawn = new Pawn();
			move = new Move();
			chessBoard = new string[DIMENSION, DIMENSION];
			ChessBoardHorizontalSymbol = "+---";
			ChessBoardVerticalSymbol = "| ";

		}

		public string ChessBoardHorizontalSymbol { get; set; }
		public string ChessBoardVerticalSymbol { get; set; }
	}
}
