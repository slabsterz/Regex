using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"(?<day>\d{2})(?<sep>[\.\-\/])(?<month>[A-Z][a-z]+)(\k<sep>)(?<year>\d{4})\b";

Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(text);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}

int[] arr = new int[2];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}