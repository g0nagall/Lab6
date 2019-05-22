using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Protected6_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = new int();
			int y = new int();
			int z = new int();
			using (StreamReader sr = new StreamReader("InputValues.txt"))
			{
				x = int.Parse(sr.ReadLine());
				Console.WriteLine(x);
				y = int.Parse(sr.ReadLine());
				Console.WriteLine(y);
				z = int.Parse(sr.ReadLine());
				Console.WriteLine(z);
			}

			Figure[] figures = new Figure[3];

			figures[0] = new Rectangle(x, y);
			figures[1] = new Circle(x);
			figures[2] = new Triange(x, y, z);


			foreach (Figure figure in figures)
			{
				figure.CalculatePerimeter();
				figure.CalculateSquare();
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
