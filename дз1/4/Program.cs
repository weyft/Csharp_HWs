using System.Text.Json;
using System.IO;

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

GameCharacter newGoblin = JsonSerializer.Deserialize<GameCharacter>(json);

Console.WriteLine($"имя: {newGoblin.Name}\nколво предметов: { newGoblin.Inventory.Length} ");

string path = Path.Combine(
    AppContext.BaseDirectory, "save.json"
);
File.WriteAllText(path, json);
string fileJson = File.ReadAllText(path);
GameCharacter fileCharacter = JsonSerializer.Deserialize<GameCharacter>(fileJson);

Console.WriteLine("имя: " + fileCharacter.Name);
Console.WriteLine("уровень: " + fileCharacter.Level);
Console.WriteLine("здоровье: " + fileCharacter.Health);
Console.WriteLine("инвентарь: " + string.Join(", ", fileCharacter.Inventory));