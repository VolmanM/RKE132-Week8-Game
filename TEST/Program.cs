string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";


try
{
    string[] heroes = File.ReadAllLines(Path.Combine(folderPath, villainFile));
    Console.WriteLine("File read successfully");

    Console.WriteLine(heroes.Length);

    foreach (var h in heroes)
    {
        Console.WriteLine(h);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Access denied");
}
catch (Exception ex)
{
    Console.WriteLine($"Error reading the file.");
}
