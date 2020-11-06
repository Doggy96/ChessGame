using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessExersice.Models
{
	class ChessMatch2
	{
		int Ttime = 600;

		public ChessMatch2()
		{

		}

		public void Game2()
		{
			while (Ttime > 0)
			{
				Console.WriteLine("Player2 plays");
				Ttime = Ttime - 15;

				Console.WriteLine("Grand master playes");
				Ttime = Ttime - 15;

			}

			Console.WriteLine("_________________________");

		}
	}
}
