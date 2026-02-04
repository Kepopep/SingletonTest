public class HealthStats
{
    public int Health { get; }
    public int Lives { get; }
    
    public HealthStats(int health, int lives)
    {
        Health = health;
        Lives = lives;
    }
}