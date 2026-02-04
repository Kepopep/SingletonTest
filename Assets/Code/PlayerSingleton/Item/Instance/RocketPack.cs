using UnityEngine;
using Zenject;

public class RocketPack : IItem
{
    public string Name => _name;
    private readonly RocketPackStats _stats;
    private int _charges;
    private string _name;

    [Inject]
    public RocketPack(RocketPackStats stats, string name)
    {
        _stats = stats;

        _charges = _stats.Charges;
        _name = name;
    }

    public  void Use()
    {
        _charges--;
        Debug.Log($"{Name} goes up the sky, charges remain {_charges}");
    }
}