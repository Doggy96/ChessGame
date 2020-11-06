using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessExersice.Models
{
	class ChessMatch1
	{
		
		int Ttime = 600;

		public ChessMatch1()
		{

		}

		public void Game1()
		{
			while (Ttime > 0)
			{
				Console.WriteLine("Player1 plays");
				Ttime = Ttime - 15;

				Console.WriteLine("Grand master playes");
				Ttime = Ttime - 15;

			}

			Console.WriteLine("_________________________");
		}

	}
}
