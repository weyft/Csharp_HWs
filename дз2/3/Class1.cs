using System;

public interface ICombatant
{
    string Name { get; }
    int HP { get; set; }
    bool IsDead { get; }
    int Damage { get; }

    void Attack(ICombatant target);
    void TakeDamage(int amount);
}

public class Knight : ICombatant
{
    public string Name { get; }

    public int HP { get; set; } = 150;

    public bool IsDead => HP <= 0;

    public int Damage { get; } = 25;

    public Knight(string name)
    {
        Name = name;
    }

    public void Attack(ICombatant target)
    {
        if (IsDead)
        {
            Console.WriteLine($"Рыцарь {Name} мёртв и не может атаковать!");
        }
        else if (target.IsDead)
        {
            Console.WriteLine($"Рыцарь {Name} не может атаковать мёртвую цель!");
        }
        else
        {
            Console.WriteLine($"Рыцарь {Name} атакует!");
            target.TakeDamage(Damage);
        }
    }

    public void TakeDamage(int amount)
    {
        HP = Math.Clamp(HP - amount, 0, 150);
        Console.WriteLine($"Рыцарь {Name} получил {amount} урона. Осталось HP: {HP}");
    }
}

public class Mage : ICombatant
{
    public string Name { get; }

    public int HP { get; set; } = 80;

    public bool IsDead => HP <= 0;

    public int Damage { get; } = 40;

    public Mage(string name)
    {
        Name = name;
    }

    public void Attack(ICombatant target)
    {
        if (IsDead)
        {
            Console.WriteLine($"Маг {Name} мёртв и не может атаковать!");
        }

        else if (target.IsDead)
        {
            Console.WriteLine($"Маг {Name} не может атаковать мёртвую цель");
        }
        else
        {
            Console.WriteLine($"Маг {Name} атакует!");
            target.TakeDamage(Damage);
        }

        if (!target.IsDead)
        {
            target.TakeDamage(Damage);
        }
    }

    public void TakeDamage(int amount)
    {
        HP = Math.Clamp(HP - amount, 0, 80);

        Console.WriteLine($"Маг {Name} получил {amount} урона. Осталось HP: {HP}");
    }
}
