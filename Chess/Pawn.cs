using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public class Pawn
	{
		public const char PAWN_SYMBBOL = 'P';
		public const char SPACE = ' ';
		public static char[,] pawns;

		public Pawn()
		{
			pawns = new char[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
		}
	}
}
