// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var num in numbers)
    {
        sum += num;
    }

    return (double) sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double avg = GetAverage(numbers);
Console.WriteLine(avg);

static int GetMax(int[] numbers)
{
    int max = numbers[0];

    foreach (var num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    
    return max;
}