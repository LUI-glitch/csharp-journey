    string line = Console.ReadLine();
    string[] parts = line.Split(" ");

    long sum = 0;
    int a = 0;
    for (int i = 0; i < parts.Length; i++)
    {
        a  = 0;
       if (parts[i]!= "") a = int.Parse(parts[i]); 
       sum = sum + a;
    }
    Console.WriteLine(sum);
