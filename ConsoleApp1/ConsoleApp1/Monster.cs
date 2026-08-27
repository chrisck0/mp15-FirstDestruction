using System;

public class Monster
{
    public int Mp { get; private set; }
    public int Speed { get; private set; }

    public Monster(int mp, int speed)

    
    public int Health { get; private set; }
    public int Attack { get; private set; }
   
     
    
    public Monster(int health, int attack)
    {
        Mp = mp;
        Speed = speed;
    }

    public void MpState(int mp)

    public virtual void AttackPlayer(int damage)
    {
    }
    public void Damage(int damage)
    {
        Mp -= mp;
    }
}

