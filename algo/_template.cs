    string line = Console.In.ReadToEnd();
    string[] parts = line.Split(new[] { ' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

    long sum = 0;

    int n = int.Parse(parts[0]);

    for (int i = 1; i <= n; i++)
    {
       sum = sum + long.Parse(parts[i]);
    }
    Console.WriteLine(sum);
