public class WeaponStatProvider
{
    public WeaponStats CreateStats(WeaponConfig config)
    {
        return new WeaponStats(
            damage: config.Damage,
            ammo: config.Ammo
        );
    }
}