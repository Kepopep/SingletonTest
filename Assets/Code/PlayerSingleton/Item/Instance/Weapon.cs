using UnityEngine;
using Zenject;

public class Weapon : IItem
{
    public string Name { get; private set; }
    private readonly WeaponStats _stats;

    private int _remainAmmo;

    [Inject]
    public Weapon(WeaponStats stats, string name)
    {
        _stats = stats;
        _remainAmmo = _stats.Ammo;

        Name = name;
    }


    public void Use()
    {
        _remainAmmo--;
        Debug.Log($"shoot {Name} ammo remain {_remainAmmo}");
    }
}