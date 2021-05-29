using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
	enum RectangleSide
	{
		SIDE_A,
		SIDE_B,
	}

	class Rectange : Shape
	{
		public Rectange(Point p1, Point p2, Point p3, Point p4)
		{
			points = new Point[4];
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
			points[3] = p4;
		}
		public Rectange(Point center, double width, double height)
		{
			points = new Point[4];

			double w = width * 0.5;
			double h = height * 0.5;

			points[0] = new Point(center.X - w, center.Y + h);
			points[1] = new Point(center.X + w, center.Y + h);
			points[2] = new Point(center.X + w, center.Y - h);
			points[3] = new Point(center.X - w, center.Y - h);
		}
		public override double Perimeter()
		{
			double p = 0.0;

			p += sideLength(RectangleSide.SIDE_A) * 2;
			p += sideLength(RectangleSide.SIDE_B) * 2;

			return p;
		}
		public override double Square()
		{
			return sideLength(RectangleSide.SIDE_A) * sideLength(RectangleSide.SIDE_B);
		}
		private double sideLength(RectangleSide side)
		{
			int sideNumber = side == RectangleSide.SIDE_A ? 1 : 2;
			return Math.Abs(Math.Sqrt(
				Math.Pow(points[sideNumber].X - points[sideNumber - 1].X, 2) +
				Math.Pow(points[sideNumber].Y - points[sideNumber - 1].Y, 2)
			));
		}
	}
}
