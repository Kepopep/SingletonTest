public class WeaponStats
{
    public int Damage { get; private set; }
    public int Ammo { get; private set; }

    public WeaponStats(int damage, int ammo)
    {
        Damage = damage;
        Ammo = ammo;
    }
}