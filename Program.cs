using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main()
		{
			var RNG = new Random();
			var laneButton= new ConsoleKey();
			var success=0;
			var fails=0;
			Console.WriteLine("Press buttons f1-f4, to switch camera on the lane you see");
			while(true)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Success: {success}");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine($"Fails: {fails}\n");
				Console.ForegroundColor = ConsoleColor.White;

				var Lane=RNG.Next(1 , 5);
				/*
				1 - top
				2 - jungle
				3 - mid
				4 - bot
				*/

				switch(Lane)
				{
					case 1:
					Console.WriteLine("Top");
					laneButton = ConsoleKey.F1;
					break;
					case 2:
					Console.WriteLine("Jungle");
					laneButton = ConsoleKey.F2;
					break;
					case 3:
					Console.WriteLine("Mid");
					laneButton = ConsoleKey.F3;
					break;
					case 4:
					Console.WriteLine("Bot");
					laneButton = ConsoleKey.F4;
					break;
					default:
					Console.WriteLine("PROBLEM");
					break;
				}

				if(Console.ReadKey(true).Key == laneButton) { success++; }
				else { fails++; }
				Console.Clear();
			}
		}
	}
}
