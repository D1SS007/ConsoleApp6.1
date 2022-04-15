using System;

namespace ConsoleApp6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Ваня", 100, 40);

            player1.ShowInfo();            
        }
    }

    class Player
    {
        private string _name;
        private int _health;
        private int _damage;

        public Player(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Игрок {_name}, имеет здоровье {_health} и урон {_damage}");
        }

    }
}
