using System.Text.Json;

GameCharacter goblin = new GameCharacter()
{
    Name = "Artur",
    Level = 67,
    Health = 100,
    Inventory = new string[]
    {
        "six", "seven", "tears"
    }
};
var options = new JsonSerializerOptions
{
    WriteIndented = true
};
string json = JsonSerializer.Serialize(goblin, options);

GameCharacter newGoblin =
    JsonSerializer.Deserialize<GameCharacter>(json);

Console.WriteLine($"имя: {newGoblin.Name}\nколво предметов: { newGoblin.Inventory.Length} ");