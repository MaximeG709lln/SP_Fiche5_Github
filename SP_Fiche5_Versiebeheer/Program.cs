Console.Clear();
Console.WriteLine($"SP Program - Versiebeheer Github:");
Personage gys = new Personage();
gys.ShowInfo();

Console.WriteLine("(Program end - Versiebeheer)");

class Personage
{
    string name = "Gys";
    int lvl = 10;
    string role = "Knight";
    string specialPower = "Double Slash";

    public void ShowInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Player's information:");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Level: {lvl}");
        Console.WriteLine($"Role: {role}");
        Console.WriteLine($"Special Power: {specialPower}");
        Console.WriteLine("-----------------------");
        Console.ResetColor();
    }
}