namespace Figures
{
	class Shape
	{
		// Вершины фигуры
		protected Point[] points;
		// Центр фигуры
		protected Point center;
		// Параметры линии
		protected Line line;

		protected void DefaultLine()
		{
			line.Color = "#000";
			line.Width = 1.0f;
		}

		public Shape()
		{
			points = null;
			DefaultLine();
		}
		public Shape(Point center, Point[] points)
		{
			this.center = center;
			this.points = points;
			DefaultLine();
		}
		public Shape(Point[] points)
		{
			this.points = points;
			DefaultLine();
		}

		public virtual bool Intersection(Shape other) { return false; }
		public virtual double Perimeter() { return 0.0; }
		public virtual double Square() { return 0.0; }
		public virtual void Draw()
		{
			if (points == null) return;

			// draw logic
		}
	}
}
