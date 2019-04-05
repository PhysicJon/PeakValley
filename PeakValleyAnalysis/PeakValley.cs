using System;
using System.Collections.Generic;
using System.Text;

namespace PeakValleyAnalysis
{
	public class PeakValley
	{
		/// <summary>
		/// Checks for number of Peaks and Valleys in integer array
		/// </summary>
		/// <param name="A">Array of integers</param>
		/// <returns>int array containing { total, peaks, valleys }</returns>
		public int[] PeakValleyDetect(int[] A)
		{
			int peaks = 0;
			int valley = 0;
			int total = 0;
			bool increasing = false;
			bool descending = false;
			// Accounts for 0 length array
			if (A.Length == 0)
			{
				return new int[] { 0, 0, 0 };
			}
			// Accounts for 1 element array
			if (A.Length == 1)
			{
				return new int[] { 1, 1, 0 };
			}
			for (int i = 1; i < A.Length; i++)
			{
				// Set current value and previous value for comparisons
				int value = A[i];
				int previous = A[i - 1];

				if (value > previous)
				{
					// Check for valley conditions
					if (increasing == false)
					{
						Console.WriteLine("VALLEY!!!");
						valley++;
						total++;
						increasing = true;
						descending = false;
					}
				}
				if (value < previous)
				{
					// Check for peak conditions
					if (descending == false)
					{
						Console.WriteLine("PEAK!!!");
						peaks++;
						total++;
						descending = true;
						increasing = false;
					}
				}
				if (i == A.Length - 1)
				{
					// Check for end of data peak/valley conditions
					if (increasing)
					{
						Console.WriteLine("END PEAK");
						peaks++;
						total++;
					}
					if (descending)
					{
						Console.WriteLine("END VALLEY");
						valley++;
						total++;
					}
					// Ensure that fully flat data (all same value) increments peak count
					if (!increasing && !descending)
					{
						Console.WriteLine("Flat Terrain (Counts as Peak)");
						peaks++;
						total++;
					}
				}
			}

			return new int[] { total, peaks, valley };
		}
	}
}
