using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputString = File.ReadAllText(@"C:\Users\nilsl\Documents\Repos\AdventOfCode2021\AdventOfCodeDay1\PuzzleData.txt");
			var p = new Program();
			int[] arr = p.CleanInputData(inputString);

			//LINQ version
			int result = Enumerable.Range(1, arr.Count() - 1).Select(i => i).Where(i => arr[i] > arr[i-1] ).Count();
            Console.WriteLine(result);

			//Readable version
            int counter = 0;
			for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i-1]) counter++;
			}
			Console.WriteLine(counter);

			//Readable version 2
			int counter2 = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				try
				{
					int sum1 = arr[i] + arr[i + 1] + arr[i + 2];
					int sum2 = arr[i + 1] + arr[i + 2] + arr[i + 3];
					if (sum1 < sum2) counter2++;
				}
				catch
				{
					break;
				}
			}
			Console.WriteLine(counter2);
		}

		public int[] CleanInputData(string inputData)
		{
			string[] arr = inputData.Split(Environment.NewLine);
			return Enumerable.Range(0, arr.Length).Select(i => int.Parse(arr[i].Trim())).ToArray();
		}
	}
}
