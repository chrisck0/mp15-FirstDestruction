using System;

public class Program
{
    static void Main(string[] args)
    {
        Monster monster = new Monster(20, 10);
        Console.WriteLine($"Monster 체력 : {monster.Health} 공격력 : {monster.Attack}");
    }
}