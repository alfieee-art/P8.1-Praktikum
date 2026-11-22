public class Shotgun : Weapon
{
    private int pelletCount;

    public Shotgun()
    {
        Name = "Shotgun";
        Damage = 40;
        pelletCount = 8;
    }

    public override void Fire()
    {
        Console.WriteLine($"{Name}: BLAM! menembakkan {pelletCount} peluru (damage {Damage})");
    }
}
