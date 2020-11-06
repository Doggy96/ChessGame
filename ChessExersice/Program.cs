using ChessExersice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessExersice
{
	class Program
	{
		static void Main(string[] args)
		{
			ChessMatch1 chessMatch1 = new ChessMatch1();
			ChessMatch2 chessMatch2 = new ChessMatch2();
			ChessMatch3 chessMatch3 = new ChessMatch3();

			chessMatch1.Game1();
			chessMatch2.Game2();
			chessMatch3.Game3();
		}
	}
}
