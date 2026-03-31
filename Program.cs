using apbd_cw1_git_s29442;

Console.WriteLine("Enter numbers separated by comma:");

string input = Console.ReadLine();
int[] numbers = input.Split(',')
    .Select(x => int.Parse(x))
    .ToArray();

double avg = StatisticsHelper.CalculateAverage(numbers);

Console.WriteLine($"Average: {avg}");