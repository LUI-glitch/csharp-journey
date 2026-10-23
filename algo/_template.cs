    string line = Console.ReadLine();
    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    long sum = 0;
    long a = 0;
    for (int i = 0; i < parts.Length; i++)
    {
       sum = sum + long.Parse(parts[i]);
    }
    Console.WriteLine(sum);
