using UnityEngine;
using Zenject;

class ProjectInstaller : MonoInstaller
{
    #region Configs

    [SerializeField] 
    private WeaponConfig _weaponConfig;
    
    [SerializeField] 
    private RocketPackConfig _rocketPackConfig;

    [SerializeField] 
    private HealthConfig _healthConfig;
    
    #endregion

    public override void InstallBindings()
    {
        BindConfigs();
        BindEquipment();
        BindItems();
        BindHealth();
        BindPlayer();
    }

    private void BindConfigs()
    {
        Container.BindInstance(_weaponConfig).AsSingle();
        Container.BindInstance(_rocketPackConfig).AsSingle();
    }
    
    private void BindEquipment()
    {
        Container.Bind<IEquipment>().To<Equipment>().AsSingle();
    }

    private void BindItems()
    {
        Container.BindFactory<WeaponStats, string, Weapon, WeaponFactory>();
        Container.BindFactory<RocketPackStats, string, RocketPack, RocketPackFactory>();

        Container.Bind<WeaponStatProvider>().AsSingle();
        Container.Bind<RocketPackStatProvider>().AsSingle();

        Container.Bind<IItemResolver>().To<WeaponResolver>().AsSingle();
        Container.Bind<IItemResolver>().To<RocketPackResolver>().AsSingle();
        Container.Bind<IItemResolver>().To<DefaultItemResolver>().AsSingle();
        
        Container.Bind<ItemFactory>().AsSingle();
        
        Container.Bind<IItemLoadout>().To<ItemLoadout>().AsSingle();
    }

    private void BindHealth()
    {
        var healthStats = new HealthStats(
            health: _healthConfig.Health,
            lives: _healthConfig.Lives
        );

        Container.BindInstance(healthStats).AsSingle();
        Container.Bind<IHealth>().To<Health>().AsSingle();
    }

    private void BindPlayer()
    {
        var playerInfo = new PlayerInfo(
            name: "Test"
        );
        Container.BindInstance(playerInfo).AsSingle();
        Container.Bind<IPlayer>().To<Player>().AsSingle();
    }
    
}