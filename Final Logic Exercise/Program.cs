var generator = new FooBarGenerator();

// 1. Input jumlah rule
Console.Write("Berapa jumlah rule? ");
string? ruleInput = Console.ReadLine();

if (ruleInput == null)
{
    Console.WriteLine("Input tidak boleh null");
    return;
}

int ruleCount = int.Parse(ruleInput);

// 2. Input setiap rule
for (int i = 0; i < ruleCount; i++)
{
    Console.WriteLine($"\nRule ke-{i + 1}");

    Console.Write("Masukkan divisor: ");
    string? divisorInput = Console.ReadLine();

    if (divisorInput == null)
    {
        Console.WriteLine("Input tidak boleh null");
        return;
    }

    int divisor = int.Parse(divisorInput);

    Console.Write("Masukkan output: ");
    string? output = Console.ReadLine();

    if (output == null)
    {
        Console.WriteLine("Input tidak boleh null");
        return;
    }

    generator.AddRule(divisor, output);
}

// 3. Input jumlah angka
Console.Write("\nGenerate sampai angka berapa? ");
string? nInput = Console.ReadLine();

if (nInput == null)
{
    Console.WriteLine("Input tidak boleh null");
    return;
}

int n = int.Parse(nInput);

// 4. Generate hasil
var result = generator.Generate(n);

Console.WriteLine("\nHasil:");
Console.WriteLine(result);

class FooBarGenerator
{
    private readonly List<(int divisor, string output)> _rules;

    public IReadOnlyList<(int divisor, string output)> Rules => _rules;

    public FooBarGenerator()
    {
        _rules = new List<(int divisor, string output)>();
    }

    public void AddRule(int divisor, string output)
    {
        _rules.Add((divisor, output));
    }

    public string Generate(int n)
    {
        var results = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string resultText = "";

            foreach (var rule in _rules)
            {
                if (i % rule.divisor == 0)
                    resultText += rule.output;
            }

            if (resultText == "")
                resultText = i.ToString();

            results.Add(resultText);
        }

        return string.Join(", ", results);
    }
}

