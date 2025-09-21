using System;

public struct Interval
{
    private readonly Random _random = new Random();
    public float Min { get; }
    public float Max { get; }

    public float Get()
    {
        return _random.NextFloat(Min, Max);
    }

    public Interval(int minValue, int maxValue)
    {
        if (minValue > maxValue)
        {
            (minValue, maxValue) = (maxValue, minValue);
        }

        if (minValue < 0)
        {
            minValue = 0;
        }

        if (maxValue < 0)
        {
            maxValue = 0;
        }

        if (minValue == maxValue)
        {
            maxValue += 10;
        }

        Min = minValue;
        Max = maxValue;
    }
}

public class Unit
{
    public string Name { get; }
    public float Health { get; private set; }
    public Interval DamageInterval { get; }
    public float Armor { get; }

    public Unit() : this("Unknown Unit") { }

    public Unit(string name) : this(name, new Interval(0, 5)) { }

    public Unit(string name, Interval damageInterval)
    {
        Name = name;
        Health = 100f;
        DamageInterval = damageInterval;
        Armor = 0.6f;
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float damage)
    {
        Health -= damage * (1f - Armor);
        return Health <= 0f;
    }
}

public class Weapon
{
    public string Name { get; }
    public Interval DamageInterval { get; private set; }
    public float Durability { get; }

    public Weapon(string name)
    {
        Name = name;
        Durability = 1;
        DamageInterval = new Interval(1, 10);
    }

    public Weapon(string name, Interval damageInterval)
        : this(name)
    {
        DamageInterval = damageInterval;
    }
}

public struct Room
{
    public Unit Unit { get; }
    public Weapon Weapon { get; }

    public Room(Unit unit, Weapon weapon)
    {
        Unit = unit;
        Weapon = weapon;
    }
}

public class Dungeon
{
    private Room[] _rooms;

    public Dungeon()
    {
        _rooms = new Room[5];
        _rooms[0] = new Room(
            new Unit("Warrior", new Interval(5, 15)),
            new Weapon("Sword", new Interval(10, 20))
        );
        _rooms[1] = new Room(
            new Unit("Mage", new Interval(1, 10)),
            new Weapon("Staff", new Interval(5, 15))
        );
        _rooms[2] = new Room(
            new Unit("Archer", new Interval(3, 8)),
            new Weapon("Bow", new Interval(7, 12))
        );
        _rooms[3] = new Room(
            new Unit("Healer", new Interval(2, 5)),
            new Weapon("Dagger", new Interval(3, 7))
        );
        _rooms[4] = new Room(
            new Unit("Tank", new Interval(8, 18)),
            new Weapon("Axe", new Interval(15, 25))
        );
    }

    public void ShowRooms()
    {
        foreach (var room in _rooms)
        {
            Console.WriteLine($"Комната:");
        }
    }
}