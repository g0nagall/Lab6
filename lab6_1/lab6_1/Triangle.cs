using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected6_1
{
	class Triange : Figure
	{
		public Triange() { }
		public Triange(double xLength, double yLength, double zLength) : base(xLength, yLength)
		{
			this.zLength = zLength;
		}

		public double zLength { get; set; }

		public override void CalculatePerimeter()
		{
			Console.WriteLine($"The perimeter of triangle: {xLength + yLength + zLength:f3}");
		}

		public override void CalculateSquare()
		{
			double p = (xLength + yLength + zLength) / 2;
			Console.WriteLine($"The square of triangle: {Math.Sqrt(p * (p - xLength) * (p - yLength) * (p - yLength)):f3}");
		}
	}
}