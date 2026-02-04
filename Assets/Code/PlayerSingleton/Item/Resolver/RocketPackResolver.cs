using System;

public class RocketPackResolver : IItemResolver
{
    private readonly RocketPackFactory _factory;
    private readonly RocketPackStatProvider _statProvider;
    private readonly RocketPackConfig _config;

    public RocketPackResolver(RocketPackFactory factory, RocketPackStatProvider statProvider, RocketPackConfig config)
    {
        _factory = factory;
        _statProvider = statProvider;
        _config = config;
    }

    public bool CanResolve(Type type)
    {
        return type == typeof(RocketPack);
    }

    public IItem Create(Type type)
    {
        var stats = _statProvider.CreateStats(_config);
        return _factory.Create(stats, _config.Name);
    }
}