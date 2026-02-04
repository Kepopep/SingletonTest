using UnityEngine;
using Zenject;

public class Entry : MonoBehaviour
{
    [Inject] private readonly IPlayer _player;
    [Inject] private readonly IItemLoadout _itemLadout;

    public void Awake()
    {

        Debug.Log(
            "first place entry, current player info\n" +
            $"{_player.Nickname}\n" +
            $"health: {_player.Health.Health}");

        _itemLadout.Setup();

        _player.Equipment.UseCurent();
        _player.Equipment.SwitchNext();
        _player.Equipment.SwitchPrew();

        _player.Health.TakeHit(12);
    }
}