using System;
using System.Collections;
using System.Collections.Generic;

namespace Figures
{
	class Program
	{
		static void Main(string[] args)
		{		
			var rect = new Rectange(new Point(4, 3), 4, 2);

			

			Console.WriteLine("P = " + rect.Perimeter());
			Console.WriteLine("S = " + rect.Square());
		}
	}
}
