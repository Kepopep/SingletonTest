using UnityEngine;

public class Parachute : IItem
{
    public string Name => "Parachute";

    public Parachute()
    {
        
    }

    public void Use()
    {
        Debug.Log($"Parachute open => happy landing");
    }
}