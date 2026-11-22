public abstract class Weapon
{
    protected string Name = " ";
    protected int Damage;
    public abstract void Fire();
    public void Reload()
    {
        Console.WriteLine($"{Name} sedang diisi ulang.");
    }
}