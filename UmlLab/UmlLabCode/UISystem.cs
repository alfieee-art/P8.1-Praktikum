public class UISystem
{
    public event Action<string>? OnNotify;
    public void RefreshDisplay()
    {
        Console.WriteLine("Tampilan inventory diperbarui.");
    }
    public void ShowNotification(string message)
    {
        Console.WriteLine($"[Notifikasi] {message}");
    }
}