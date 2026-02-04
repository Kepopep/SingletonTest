public interface IPlayer
{
    public string Nickname { get; }

    public IHealth Health { get; }

    public IEquipment Equipment { get; }
        
    public string[] Skills { get; }
}