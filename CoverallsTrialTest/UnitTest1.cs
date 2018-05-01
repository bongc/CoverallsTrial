using System;
using CoverallsTrialLibrary;
using Xunit;

namespace CoverallsTrialTest
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var test = new Class1();
			test.Method1(true);
		}
	}
}
