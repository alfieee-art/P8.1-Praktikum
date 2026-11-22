public partial class Player
{
    public void PickUp(ItemPickup pickup)
    {
        Console.WriteLine($"{name} mengambil item obat.");
        pickup.Collect();                      
    }

    public void ShowNotification(string message) 
    {
        Console.WriteLine($"[Notifikasi untuk {name}] {message}");
    }
}
