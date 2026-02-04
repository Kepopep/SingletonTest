public class ItemLoadout : IItemLoadout
{
    private readonly IEquipment _playerEquipment;
    private readonly ItemFactory _itemFactory;

    public ItemLoadout(IEquipment equipment, ItemFactory factory)
    {
           _playerEquipment = equipment;
           _itemFactory = factory;
    }

    public void Setup()
    {
        _playerEquipment.AddItem(_itemFactory.Create(typeof(Weapon)));
        _playerEquipment.AddItem(_itemFactory.Create(typeof(RocketPack)));
        _playerEquipment.AddItem(_itemFactory.Create(typeof(Parachute)));
    }
}