using System.Linq;
using NUnit.Framework;
using Rectangle.Impl;

namespace Rectangle.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			var rectangle = Service.FindRectangle(new[] { new Point() }.ToList());
			Assert.IsNotNull(rectangle);
		}

		[Test]
		public void Test2()
		{
			var rectangle = Service.FindRectangle(new[] { new Point() { X = 2, Y = 4 },  new Point() { X = 2, Y = 6 } }.ToList());
			Assert.IsNotNull(rectangle);
		}
		[Test]
		public void Test3()
		{
			var rectangle = Service.FindRectangle(new[] { new Point() { X = 2, Y = 4 }, new Point() { X = 11, Y = 12 }, new Point() { X = 2, Y = 6 }, new Point() { X = 11, Y = 9 }, new Point() { X = 6, Y = 6 }, new Point() { X = 9, Y = 12 }, new Point() { X = 6, Y = 4 }, new Point() { X = 8, Y = 6 }, new Point() { X = 9, Y = 9 }, new Point() { X = 8, Y = 4 }, new Point() { X = 2, Y = 8 }, new Point() { X = 6, Y = 8 }, new Point() { X = 6, Y = 13 } }.ToList());
			Assert.IsNotNull(rectangle);
		}
	}
}