using System.Linq;

var inputString = File.ReadAllText(@"C:\Users\nilsl\Documents\Repos\AdventOfCode2021\AdventOfCodeDay2\PuzzleData.txt");
string[] arr = CleanInputData(inputString);

Console.WriteLine(PuzzleOne(arr));
Console.WriteLine(PuzzleTwo(arr));



string[] CleanInputData(string inputData)
{
    string[] arr = inputData.Split(Environment.NewLine);
    return Enumerable.Range(0, arr.Length).Select(i => arr[i].Trim()).ToArray();
}

int PuzzleOne(string[] arr)
{
    var xAxis = 0;
    var yAxis = 0;

    foreach (string item in arr)
    {
        if (item.Contains("forward"))
        {
            xAxis += int.Parse(item.Substring(item.Length - 1, 1));
        }
        else if (item.Contains("back"))
        {
            xAxis -= int.Parse(item.Substring(item.Length - 1, 1));
        }
        else if (item.Contains("up"))
        {
            yAxis -= int.Parse(item.Substring(item.Length - 1, 1));
        }
        else if (item.Contains("down"))
        {
            yAxis += int.Parse(item.Substring(item.Length - 1, 1));
        }
    }
    return (xAxis * yAxis);
}

int PuzzleTwo(string[] arr)
{
    var xAxis = 0;
    var yAxis = 0;
    var aim = 0;

    foreach (string item in arr)
    {
        if (item.Contains("forward"))
        {
            xAxis += int.Parse(item.Substring(item.Length - 1, 1));
            yAxis += int.Parse(item.Substring(item.Length - 1, 1)) * aim;
        }
        else if (item.Contains("back"))
        {
            xAxis -= int.Parse(item.Substring(item.Length - 1, 1));
            yAxis -= int.Parse(item.Substring(item.Length - 1, 1)) * aim;
        }
        else if (item.Contains("up"))
        {
            aim -= int.Parse(item.Substring(item.Length - 1, 1));
        }
        else if (item.Contains("down"))
        {
            aim += int.Parse(item.Substring(item.Length - 1, 1));
        }
    }
    return (xAxis * yAxis);
}