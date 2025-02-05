using System;

abstract class Creature
{
    public string Name;
    public int Health;

    public Creature(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack(Creature target); 

    public virtual void TakeDamage(int damage)
    {
        if ((Health - damage) > 0)
        {
            Health -= damage;
        }
        else
        {
            Health = 0;
        }
    }
}

class Hero : Creature
{
    public int AttackPower;

    public Hero(string name, int health, int attackpower) : base(name, health)
    {
        AttackPower = attackpower;
    }

    public override void Attack(Creature Target)
    {
        Console.WriteLine($"{Name} attacks for {AttackPower} damage!");
        Target.TakeDamage(AttackPower);
    }
}

class Monster : Creature
{
    public int AttackPower;

    public Monster(string name, int health, int attackpower) : base(name, health)
    {
        AttackPower = attackpower;
    }

    public override void Attack(Creature Target)
    {
        Console.WriteLine($"{Name} attacks for {AttackPower} damage!");
        Target.TakeDamage(AttackPower);
    }
}

class Item
{
    public string Name;
    public string Description;

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Use()
    {
        Console.WriteLine($"Using {Name}: {Description}");
    }
}

class HealingPotion : Item
{
    public int Eff;
    public HealingPotion(string name, string description, int eff) : base(name, description)
    {
        Eff = eff;
    }

    public void Use(Hero hero)
    {
        hero.Health += Eff;
        Console.WriteLine($"Used {Name}: {Description} to heal {Eff} health points.");
    }
}

public class Game
{
    private Hero hero;
    private List<Monster> monsters;
    private List<Item> inventory;

    public Game()
    {
        hero = new Hero("Knight", 100, 20);
        monsters = new List<Monster>
        {
            new Monster("Goblin", 30, 5),
            new Monster("Orc", 50, 10)
        };
        inventory = new List<Item>
        {
            new HealingPotion("Small Healing Potion", "Heals 20 health points", 20)
        };
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the RPG Game!");
        Console.WriteLine($"{hero.Name} starts the journey with {hero.Health} health and {hero.AttackPower} attack power.");

        foreach (var monster in monsters)
        {
            Console.WriteLine($"\nA wild {monster.Name} appears!");

            while (monster.Health > 0 && hero.Health > 0)
            {
                hero.Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(hero);
                }
            }

            if (hero.Health > 0)
            {
                Console.WriteLine($"{hero.Name} defeated the {monster.Name}!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} was defeated by the {monster.Name}...");
                return;
            }
        }

        Console.WriteLine($"\n{hero.Name} has defeated all the monsters!");

        foreach (var item in inventory)
        {
            item.Use();
        }

        Console.WriteLine($"{hero.Name} has {hero.Health} health remaining after using items.");
    }
}

public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Play();
    }
}

