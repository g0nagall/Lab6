using System;
using System.Collections.Generic;

using System.Text;


namespace Protected6_1
{
	class Circle : Figure
	{
		public Circle() { }
		public Circle(double radius) : base(radius, 0) { }

		public override void CalculatePerimeter()
		{
			Console.WriteLine($"The perimeter of circle: {2 * Math.PI * xLength:f3}");
		}

		public override void CalculateSquare()
		{
			Console.WriteLine($"The square of circle: {Math.PI * Math.Pow(xLength, 2):f3}");
		}
	}
}
