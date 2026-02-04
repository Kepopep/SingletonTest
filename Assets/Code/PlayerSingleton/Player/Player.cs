class Player : IPlayer
{
    public string Nickname => _nickname;
    public IHealth Health => _health;
    public IEquipment Equipment => _equipment;
    public string[] Skills => _skils;

    private string _nickname;
    private readonly IHealth _health;
    private readonly IEquipment _equipment;
    private string[] _skils = new string[4];

    public Player(IHealth health, IEquipment equipment, PlayerInfo info)
    {
        _health = health;
        _equipment = equipment;
        
        _nickname = info.Name;
    }
}

public class PlayerInfo
{
    public string Name;

    public PlayerInfo(string name)
    {
        Name = name;
    }
}