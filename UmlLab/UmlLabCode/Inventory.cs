public class Inventory
{
    private UISystem ui = new UISystem();
    public UISystem UI => ui;
    public void AddItem(string itemName)
    {
        Console.WriteLine($"{itemName} ditambahkan ke inventory.");
        ui.RefreshDisplay();
    }
}