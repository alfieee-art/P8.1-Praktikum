public class Pistol : Weapon
{
    private int magazineSize;

    public Pistol()
    {
        Name = "Pistol";
        Damage = 15;
        magazineSize = 12;
    }

    public override void Fire()
    {
        Console.WriteLine($"{Name}: DOR! (damage {Damage}, kapasitas magazen {magazineSize})");
    }
}
