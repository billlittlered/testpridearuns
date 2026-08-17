using TestPrIdeaRuns.Greetings;

var greetingCreator = new GreetingCreator();

var firstName = PromptRequired("First name");
var lastName = PromptRequired("Last name");
var age = PromptAge();

Console.WriteLine();
Console.WriteLine(greetingCreator.CreateGreeting(firstName, lastName, age));

static string PromptRequired(string label)
{
    while (true)
    {
        Console.Write($"{label}: ");
        var value = Console.ReadLine()?.Trim();

        if (!string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        Console.WriteLine($"{label} is required.");
    }
}

static int PromptAge()
{
    while (true)
    {
        Console.Write("Age: ");
        var value = Console.ReadLine();

        if (int.TryParse(value, out var age) && age >= 0)
        {
            return age;
        }

        Console.WriteLine("Age must be a whole number of 0 or greater.");
    }
}
