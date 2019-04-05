using Xunit;

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
		[InlineData(new int[] { 1, 1, 2, 3, 4, 4,3,2,3,4,5,6,7,8,9,10,9,8,9,8,7,6,5,4,3,2,1,0 }, new int[] { 7, 3, 4 })]
		public void PeakValleyDetect(int[] ints, int[] expected)
		{
			Assert.Equal(expected, new PeakValley().PeakValleyDetect(ints));
		}
	}
}
