using static System.Net.Mime.MediaTypeNames;

Knight knight = new Knight("Сергей");
Mage mage = new Mage("Антошка");

while (!knight.IsDead && !mage.IsDead)
{
    knight.Attack(mage);

    if (mage.IsDead)
    {
        break;
    }

    mage.Attack(knight);

}

if (!knight.IsDead)
{
    Console.WriteLine($"Победил Рыцарь {knight.Name}!");
}
else
{
    Console.WriteLine($"Победил Маг {mage.Name}!");
}