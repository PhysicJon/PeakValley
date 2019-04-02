using System;
using Xunit;
using PeakValleyAnalysis;

namespace PeakValleyAnalysis.Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 1 })]
		public void PeakValleyDetect(int[] ints, int[] expected)
		{
			Assert.Equal(expected, new PeakValley().PeakValleyDetect(ints));
		}
	}
}
