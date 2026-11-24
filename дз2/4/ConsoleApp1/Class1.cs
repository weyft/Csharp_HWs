public enum Rarity
{
    Common,
    Rare,
    Legendary
}

public interface IUsableItem
{
    string Name { get; }
    string Description { get; }
    Rarity Rarity { get; }
    void Use(Player player);
}

public class Player
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Damage { get; set; }
    public bool IsDead => HP <= 0;
    public Player(string name, int hp, int damage)
    {
        Name = name;
        HP = hp;
        Damage = damage;
    }
    public void Heal(int amount)
    {
        HP += amount;
        Console.WriteLine($"{Name} восстановил {amount} HP. Текущее HP: {HP}");
    }

    public void IncreaseDamage(int amount)
    {
        Damage += amount;
        Console.WriteLine($"{Name} увеличил урон на {amount}. Теперь урон: {Damage}");
    }

    public void TakeDamage(int amount)
    {
        HP = Math.Clamp(HP-amount,0,HP);
        Console.WriteLine($"{Name} получил {amount} урона. Осталось HP: {HP}");
    }
}

public class HealthPotion : IUsableItem
{
    public string Name { get; } = "Зелье здоровья";
    public string Description { get; } = "Восстанавливает 50 HP";
    public Rarity Rarity { get; } = Rarity.Common;
    public void Use(Player player)
    {
        player.Heal(50);
        Console.WriteLine("Вы выпили зелье и восстановили 50 HP");
    }
}

public class Sword : IUsableItem
{
    public string Name { get; } = "Меч";
    public string Description { get; } = "Увеличивает урон на 10";
    public Rarity Rarity { get; } = Rarity.Rare;
    public void Use(Player player)
    {
        player.IncreaseDamage(10);
        Console.WriteLine("Вы экипировали меч");
    }
}

public class AncientScroll : IUsableItem
{
    public string Name { get; } = "Древний свиток";
    public string Description { get; } = "Наносит 20 урона и увеличивает урон на 30";
    public Rarity Rarity { get; } = Rarity.Legendary;
    public void Use(Player player)
    {
        player.TakeDamage(20);
        player.IncreaseDamage(30);
        Console.WriteLine("Вы использовали древний свиток!");
    }
}