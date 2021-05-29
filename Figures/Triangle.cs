using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
	class Triangle : Shape
	{
		public Triangle(Point[] points)
		{
			if (points.Length != 3)
			{
				throw new Exception("Для создания треугольника необходимо указать 3 вершины");
			}
		}
		public Triangle(Point p1, Point p2, Point p3)
		{
			points = new Point[3];
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
		}
	}
}
