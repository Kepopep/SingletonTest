using System;

public class WeaponResolver : IItemResolver
{
    private readonly WeaponFactory _factory;
    private readonly WeaponStatProvider _statProvider;
    private readonly WeaponConfig _config;

    public WeaponResolver(WeaponFactory factory, WeaponStatProvider statProvider, WeaponConfig config)
    {
        _factory = factory;
        _statProvider = statProvider;
        _config = config;
    }

    public bool CanResolve(Type type)
    {
        return type == typeof(Weapon);
    }

    public IItem Create(Type type)
    {
        var stats = _statProvider.CreateStats(_config);
        return _factory.Create(stats, _config.Name);
    }
}