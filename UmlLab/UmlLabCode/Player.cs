public partial class Player
{
    private string name;
    private Weapon? currentWeapon;
    public Player(string name) => this.name = name;
    public void Equip(Weapon w)
    {
        currentWeapon = w;
        Console.WriteLine($"{name} melengkapi diri dengan senjata baru.");
    }
}