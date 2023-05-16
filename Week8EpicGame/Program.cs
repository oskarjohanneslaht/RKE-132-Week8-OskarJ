
string folderPath = @"C:\Users\OSKAR\Desktop\Data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Harry", "Luke", "Lara", "Scooby" };
//string[] villains = { "Voldemort", "Vader", "Joker", "Thanos", "Dracula" };

string[] weapon = { "fork", "spoon" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Todays hero is {hero} and weapon {heroWeapon}");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Todays villain is {villain} and weapon {villainWeapon}");

static string GetRandomValueFromArray(string[] SomeArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, SomeArray.Length);
    string randomStringFromArray = SomeArray[randomIndex]; 
    return randomStringFromArray;
}


