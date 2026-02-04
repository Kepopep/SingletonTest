using UnityEngine;

[CreateAssetMenu(menuName = "Configs/GunConfig")]
public class WeaponConfig : ScriptableObject
{
    public string Name; 
    public int Ammo; 
    public int Damage; 
} 