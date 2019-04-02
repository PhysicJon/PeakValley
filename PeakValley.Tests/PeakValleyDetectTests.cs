using System;
using Xunit;
using PeakValleyAnalysis;

namespace PeakValleyAnalysis.Tests
{
	public class PeakValleyDetectTests
	{
		[Theory]
		[InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 1 })]
		[InlineData(new int[] { }, new int[] { 0, 0, 0 })]
		[InlineData(new int[] { 1 }, new int[] { 1, 1, 0 })]
		[InlineData(new int[] { -1, -2, -3, -4 }, new int[] { 2, 1, 1 })]
		[InlineData(new int[] { 1, 1, 2, 3, 4, 4 }, new int[] { 2, 1, 1 })]
		public void PeakValleyDetect(int[] ints, int[] expected)
		{
			Assert.Equal(expected, new PeakValley().PeakValleyDetect(ints));
		}
	}
}
