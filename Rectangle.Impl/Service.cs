using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static Rectangle FindRectangle(List<Point> points)
		{
			if (points.Count < 2) throw new Exception("Массив точек содержит менее двух точек");

            for (int i = 0; i < points.Count; i++)
            {
				if(points[i]==null) throw new Exception("Массив точек содержит NULL");
				for (int j = i; j < points.Count; j++)
                {
                    if (j!=i && points[i].X == points[j].X && points[i].Y == points[j].Y)
                    {
						throw new Exception("Массив содержит одинаковые точки");
					}
                }
            }

			Rectangle rectangle = new Rectangle();
			int xMax = points.Max(point => point.X);
			int xMin = points.Min(point => point.X);
			int yMax = points.Max(point => point.Y);
			int yMin = points.Min(point => point.Y);

			if (MethX(xMin, points))
			{
				for (int i = 0; i < points.Count; i++)
				{
					if (points[i].X == xMin)
					{
						rectangle.X = points[i].X;
						rectangle.Y = points[i].Y;
					}
				}
				xMin++;
				rectangle.Height = ++yMax - yMin;
				rectangle.Width = ++xMax - xMin;
				return rectangle;
			}
			if (MethX(xMax, points))
			{
				for (int i = 0; i < points.Count; i++)
				{
					if (points[i].X == xMax)
					{
						rectangle.X = points[i].X;
						rectangle.Y = points[i].Y;
					}
				}
				xMax--;
				rectangle.Height = yMax - --yMin;
				rectangle.Width = xMax - --xMin;
				return rectangle;
			}
			if (MethY(yMin, points))
			{
				for (int i = 0; i < points.Count; i++)
				{
					if (points[i].Y == yMin)
					{
						rectangle.X = points[i].X;
						rectangle.Y = points[i].Y;
						break;
					}
				}
				yMin++;
				rectangle.Height = ++yMax - yMin;
				rectangle.Width = ++xMax - xMin;
				return rectangle;
			}
			if (MethY(yMax, points))
			{
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i].Y == yMax)
                    {
						rectangle.X = points[i].X;
						rectangle.Y = points[i].Y;
					}
                }
				yMax--;
				rectangle.Height = yMax - --yMin;
				rectangle.Width = xMax - --xMin;
				return rectangle;
			}
			Exception ex = new Exception("Невозможно найти построить прямоугольник с одной точкой снаружи");
            Console.WriteLine(ex.Message);
			throw ex;
		}
		public static bool MethX(int value, List<Point> points)
        {
			int count = 0;
            foreach (var item in points)
				if (item.X == value) count++;
			if (count == 1) return true;
			return false;
        }
		public static bool MethY(int value, List<Point> points)
		{
			int count = 0;
			foreach (var item in points)
				if (item.Y == value) count++;
			if (count == 1) return true;
			return false;
		}
	}
}
