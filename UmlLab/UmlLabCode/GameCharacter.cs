public abstract class GameCharacter : IDamageable
{
    protected string name = " ";
    protected int health;
    public abstract void Attack();
    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}