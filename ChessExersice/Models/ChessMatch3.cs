using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessExersice.Models
{
	class ChessMatch3
	{
		int Ttime = 600;

		public ChessMatch3()
		{

		}

		public void Game3()
		{
			while (Ttime > 0)
			{
				Console.WriteLine("Player3 plays");
				Ttime = Ttime - 15;

				Console.WriteLine("Grand master playes");
				Ttime = Ttime - 15;

			}

			
		}
	}
}
