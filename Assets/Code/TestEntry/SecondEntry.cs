using UnityEngine;
using Zenject;

public class SecondEntry : MonoBehaviour
{
    [Inject] private readonly IPlayer _player;

    public void Start()
    {
        Debug.Log(
            "second place entry, current player info\n" +
            $"{_player.Nickname}\n" +
            $"health: {_player.Health.Health}");

        _player.Health.TakeHit(1000);
    }
}