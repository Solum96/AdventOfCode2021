var inputString = File.ReadAllText(@"C:\Users\nilsl\Documents\Repos\AdventOfCode2021\AdventOfCodeDay3\PuzzleData.txt");
string[] arr = CleanInputData(inputString);

Console.WriteLine(PuzzleOne(arr));

int PuzzleOne(string[] arr)
{
	string gammaRate = "";
	string epsilonRate = "";
    for (int i = 0; i < arr[0].Length; i++)
    {
		gammaRate += arr.GroupBy(x => x[i])
			.OrderByDescending(x => x.Count())
			.Select(x => x).First().Key.ToString();

		epsilonRate += arr.GroupBy(x => x[i])
			.OrderBy(x => x.Count())
			.Select(x => x).First().Key.ToString();
	}
	return Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2);
}

string[] CleanInputData(string inputData)
{
	string[] arr = inputData.Split(Environment.NewLine);
	return Enumerable.Range(0, arr.Length).Select(i => arr[i].Trim()).ToArray();
}