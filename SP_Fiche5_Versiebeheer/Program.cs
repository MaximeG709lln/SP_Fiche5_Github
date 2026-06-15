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
        Console.WriteLine($"The player's name is {name}.");
        Console.WriteLine($"They are level {lvl}.");
        Console.WriteLine($"Their role is a {role}.");
        Console.WriteLine($"As a {role}, they have a special power called {specialPower}!");
        Console.WriteLine("-----------------------");
        Console.ResetColor();
    }
}