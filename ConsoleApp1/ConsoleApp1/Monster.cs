using System;

public class Monster
{
    public int Mp { get; private set; }
    public int Speed { get; private set; }

    public Monster(int mp, int speed)
    {
        Mp = mp;
        Speed = speed;
    }

    public void MpState(int mp)
    {
        Mp -= mp;
    }
}

