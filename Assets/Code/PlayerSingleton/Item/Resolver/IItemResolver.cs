using System;

public interface IItemResolver
{
    bool CanResolve(Type type);
    IItem Create(Type type);
}