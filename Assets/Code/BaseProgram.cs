using System;
using System.Collections.Generic;

namespace BaseVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = Player.Instance; // Получаем экземпляр класса Player

            // Инициализируем игрока
            // health
            player.Health = 100;
            player.Lives = 3;

            // name
            player.Nickname = "John";

            // skils
            player.Skills = new string[] { "Skill1", "Skill2", "Skill3" };

            //equipment
            player.Equipment = new Equipment();

            Console.WriteLine("Здоровье игрока: " + player.Health);
            Console.WriteLine("Никнейм игрока: " + player.Nickname);

            Equipment equipment = player.Equipment;
            equipment.AddItem(new Weapon("Винтовка", 50));
            equipment.AddItem(new Parachute("Парашут"));
            equipment.AddItem(new RocketPack(3)); // Ракетный ранец с 3 зарядами

            Console.ReadKey();
        }
    }

    // Класс игрока
    public class Player
    {
        private static Player _instance;
        public int Health { get; set; }
        public int Lives { get; set; }
        public string Nickname { get; set; }

        // Таблица навыков
        public string[] Skills { get; set; }
                
        // Экипировка
        public Equipment Equipment { get; set; }

        public Player()
        {
            _instance = this;
        }

        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Player();
                }
                return _instance;
            }
        }
    }

    // Интерфейс для экипировки
    interface IEquipment
    {
        void AddItem(Item item);
    }

    // Реализация экипировки
    public class Equipment : IEquipment
    {
        List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }
    }

    // Предмет экипировки
    public abstract class Item
    {
        protected string name;

        public Item(string name)
        {
            this.name = name;
        }
    }

    // Оружие
    class Weapon : Item
    {
        int ammo;

        public Weapon(string name, int ammo) : base(name)
        {
            this.ammo = ammo;
        }
    }

    // Парашют
    public class Parachute : Item
    {
        public Parachute(string name) : base(name)
        {
        }
    }

    // Ракетный ранец
    class RocketPack : Item
    {
        int charges;

        public RocketPack(int charges) : base("RocketPack")
        {
            this.charges = charges;
        }
    }
}

