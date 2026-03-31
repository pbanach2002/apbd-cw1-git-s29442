using apbd_cw1_git_s29442;

Console.WriteLine("=== STATISTICS APP ===");

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
    int max = StatisticsHelper.CalculateMax(numbers);
    Console.WriteLine($"Max: {max}");
    int min = StatisticsHelper.CalculateMin(numbers);
    Console.WriteLine($"Min: {min}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}