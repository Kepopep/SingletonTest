using System;
using System.Collections.Generic;

public class ItemFactory 
{
    private readonly List<IItemResolver> _resolvers;


    public ItemFactory(List<IItemResolver> resolvers)
    {
        _resolvers = resolvers;
    }

    public IItem Create(Type itemType)
    {
        foreach (var resolver in _resolvers)
        {
            if(resolver.CanResolve(itemType))
                return resolver.Create(itemType);
        }

        throw new Exception($"No resolver to type {itemType}");
    }
}