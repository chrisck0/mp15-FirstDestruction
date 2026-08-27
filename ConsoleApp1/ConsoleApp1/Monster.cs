using System;

public class Monster
{
    public int Health { get; private set; }
    public int Attack { get; private set; }

    public Monster(int health, int attack)
    {
        Health = health;
        Attack = attack;
    }
}

