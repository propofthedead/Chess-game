using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		struct Corrdinate
		{
			char x;
			int y;
		};

		struct Piece
		{
			Corrdinate location;
			string pieceName;
			string pieceType;
		};
	}
}
