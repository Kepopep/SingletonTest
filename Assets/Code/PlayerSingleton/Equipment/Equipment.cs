using System;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : IEquipment
{
    private int _currentItemIndex = 0;
    List<IItem> _items = new List<IItem>();

    private IItem _currentItem => _items[_currentItemIndex];

    public Equipment()
    {
        
    }

    public void AddItem(IItem item)
    {
        Debug.Log($"--add new equipment {item.Name}");
        _items.Add(item);
    }

    public void UseCurent()
    {
        if(_currentItemIndex > _items.Count)
        {
            throw new IndexOutOfRangeException("equipment index out range");
        }

        _currentItem.Use();
    }

    public void SwitchNext()
    {
        Debug.Log($"--old equipment {_currentItem.Name}");
        _currentItemIndex = (_currentItemIndex + 1) % _items.Count;
        Debug.Log($"--new equipmint {_currentItem.Name}");
    }

    public void SwitchPrew()
    {
        Debug.Log($"--old equipment {_currentItem.Name}");
        _currentItemIndex = (_currentItemIndex - 1 + _items.Count) % _items.Count; 
        Debug.Log($"--new equipment {_currentItem.Name}");
    }
}