﻿using System;
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
			ChessBoard game = new ChessBoard();
			game.displayChessBoard();

			Console.Read();
		}

		

	}
}
