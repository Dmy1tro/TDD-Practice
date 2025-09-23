namespace TDD.Practice;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        var delimiters = new[] { ",", "\n" };

        if (numbers.StartsWith("//"))
        {
            var parts = numbers.Split('\n', 2);
            var customDelimiter = parts[0].Substring(2);
            delimiters = delimiters.Concat(new[] { customDelimiter }).ToArray();
            numbers = parts[1];
        }

        var tokens = numbers
            .Split(delimiters, StringSplitOptions.None)
            .Where(t => !string.IsNullOrWhiteSpace(t))
            .Select(int.Parse)
            .ToList();

        var negatives = tokens.Where(n => n < 0).ToList();
        if (negatives.Any())
            throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negatives)}");

        return tokens
            .Where(n => n <= 1000)
            .Sum();
    }
}
