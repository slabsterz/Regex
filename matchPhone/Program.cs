using System.Text.RegularExpressions;

string text = Console.ReadLine();

string expression = @"\+359(?<sep>[\ \-])2(\k<sep>)\d{3}(\k<sep>)\d{4}\b";

Regex regex = new Regex(expression);

MatchCollection matches = regex.Matches(text);

Console.WriteLine(string.Join(", ", matches));