using System;
using Zenject;

public class DefaultItemResolver : IItemResolver
{
    private readonly DiContainer _container;

    public DefaultItemResolver(DiContainer container)
    {
        _container = container;
    }

    public bool CanResolve(Type type)
    {
        return typeof(IItem).IsAssignableFrom(type);
    }

    public IItem Create(Type type)
    {
        return (IItem)_container.Instantiate(type);
    }
}
