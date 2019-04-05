using System;
using System.Linq;
namespace PeakValleyAnalysis
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = null;
			
			A = args.Length == 0 ?  new int[] { 1, 2, 3, 4 } : Array.ConvertAll(args[0].Split(',').ToArray(), s => int.Parse(s));
			
			var result = new PeakValley().PeakValleyDetect(A);
			Console.WriteLine($"Total: {result[0]}, Peaks: {result[1]}, Valleys: {result[2]}");
		}
	}
}
