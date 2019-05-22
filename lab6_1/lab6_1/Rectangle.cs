using System;
using System.Collections.Generic;
using System.Text;

namespace Protected6_1
{
	class Rectangle : Figure
	{
		public Rectangle() { }
		public Rectangle(double xLength, double yLength) : base(xLength, yLength) { }

		public override void CalculatePerimeter()
		{
			Console.WriteLine($"The perimeter of rectangle is {(xLength + yLength) * 2:f3}");
		}

		public override void CalculateSquare()
		{
			Console.WriteLine($"The square of rectangle is {xLength * yLength:f3}");
		}
	}
}
