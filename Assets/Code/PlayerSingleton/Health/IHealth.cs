public interface IHealth
{
    public int Health { get; }

    public int Lives { get; }

    public void TakeHit(int damage);
}