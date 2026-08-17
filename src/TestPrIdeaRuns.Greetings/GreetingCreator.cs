namespace TestPrIdeaRuns.Greetings;

public sealed class GreetingCreator
{
    public string CreateGreeting(string firstName, string lastName, int age)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(age);

        var normalizedFirstName = NormalizeName(firstName, nameof(firstName));
        var normalizedLastName = NormalizeName(lastName, nameof(lastName));
        var ageLabel = age == 1 ? "1 year old" : $"{age} years old";

        return $"Hello, {normalizedFirstName} {normalizedLastName}! At {ageLabel}, it is great to meet you.";
    }

    private static string NormalizeName(string value, string parameterName)
    {
        var normalized = value.Trim();

        if (normalized.Length == 0)
        {
            throw new ArgumentException("Name values must not be blank.", parameterName);
        }

        return normalized;
    }
}
