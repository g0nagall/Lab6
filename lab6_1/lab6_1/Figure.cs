using System;
using System.Linq;
using System.Text;


namespace Protected6_1
{
	abstract class Figure
	{
		public Figure() { }

		public Figure(double xLength, double yLength)
		{
			this.xLength = xLength;
			this.yLength = yLength;
		}

		public double xLength { get; set; }
		public double yLength { get; set; }

		public abstract void CalculateSquare();
		public abstract void CalculatePerimeter();

	}
}
