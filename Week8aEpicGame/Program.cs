string folderPath = @"C:\Users\marku\Downloads\MÄNG";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));



//string[] heroess = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "Voldemort", "Darth ´Vader", "Dracula", "Joker", "Sauron" };


string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };



string hero = GetRandomValueFromArray(heroes);
string heroweapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroweapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainweapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainweapon} tries to take over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}