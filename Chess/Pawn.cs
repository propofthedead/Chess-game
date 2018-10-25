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
			initPawn(); //populate pawn array with spaces and P's

		}

		private void initPawn()
		{
			for (int r = 0; r < ChessBoard.DIMENSION; r++) {
				for(int c=0; c<ChessBoard.DIMENSION; c++) {
					//place Pawns in the first and last two rows of the array
					if (r == 0 || r == 1 || r == ChessBoard.DIMENSION - 2 || r == ChessBoard.DIMENSION - 1)
						pawns[r, c] = PAWN_SYMBBOL;
					else
						pawns[r, c] = SPACE;

					
				}
			}
		}
	}
}
