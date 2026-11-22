public class Warrior : GameCharacter
{
    private int armor;
    public Weapon? equippedWeapon;
    public override void Attack()
    {
        Console.WriteLine($"{name} menyerang!");
    }
}