using apbd_cw1_git_s29442;

Console.WriteLine("=== Statistics Calculator ===");

try
{
    Console.WriteLine("Enter numbers separated by comma:");

    string input = Console.ReadLine();

    int[] numbers = input.Split(',')
        .Select(x => int.Parse(x))
        .ToArray();

    double avg = StatisticsHelper.CalculateAverage(numbers);

    Console.WriteLine("----------------------------");
    Console.WriteLine($"Average: {avg}");
    Console.WriteLine("----------------------------");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}