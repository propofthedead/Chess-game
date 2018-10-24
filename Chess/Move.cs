using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public class Move: Pawn
	{
		private int targetX;
		private int targetY;
		private int destinationX;
		private int destinationY;

		public Move()
		{
			targetX = 0;
			targetY = 0;
			destinationX = 0;
			destinationY = 0;

			Exit = false;

		}

		public bool Exit { get; set; }
	}
}
