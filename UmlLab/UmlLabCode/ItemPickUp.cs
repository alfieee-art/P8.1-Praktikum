public class ItemPickup
{
    private readonly Inventory inventory;

    public ItemPickup(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void Collect()
    {
        Console.WriteLine("ItemPickup.Collect() dipanggil.");
        inventory.AddItem("potion");   
    }       
}
