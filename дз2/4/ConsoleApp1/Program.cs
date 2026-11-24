Player player = new Player("Герой", 100, 20);

List<IUsableItem> items = new List<IUsableItem>
        {
            new HealthPotion(),
            new Sword(),
            new AncientScroll()
        };

foreach (IUsableItem item in items)
{
    Console.WriteLine($"Используется предмет: {item.Name}");
    Console.WriteLine($"Описание: {item.Description}");
    Console.WriteLine($"Редкость: {item.Rarity}");
    item.Use(player);
}
Console.WriteLine($"Имя: {player.Name}");
Console.WriteLine($"HP: {player.HP}");
Console.WriteLine($"Урон: {player.Damage}");
if (player.IsDead)
{
    Console.WriteLine("Игрок мёртв");
}
else
{
    Console.WriteLine("Игрок жив");
}