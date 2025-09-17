using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public Hero hero1;
    public List<Monsters> monstersPrefabs; //For Prefabs
    public List<Monsters> monsters = new List<Monsters>(); //Monster
    public Monsters currentMonster;

    //private List<Monsters> monsters = new List<Monsters>();
    // Start is called once(ครั้งเดียว) before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero1.Init("Yasuo", 50, 10);
        hero1.ShowStat();

        //Monster 1 Goblin
        currentMonster = Instantiate(monstersPrefabs[0]);
        currentMonster.Init("Goblin", 50, 10, 5);
        monsters.Add(currentMonster);
        currentMonster.ShowStat();

        //Monster 2 Orc
        currentMonster = Instantiate(monstersPrefabs[1]);
        currentMonster.Init("Orc", 100, 15, 10);
        monsters.Add(currentMonster);
        currentMonster.ShowStat();

        //Monster 3 Dragon
        currentMonster = Instantiate(monstersPrefabs[2]);
        currentMonster.Init("Dragon", 150, 20, 15);
        monsters.Add(currentMonster);
        currentMonster.ShowStat();

        /*Create Hero
        Hero hero = new Hero("Yasuo",50,20);

        //Create Monsters
        Monsters monster1 = new Monsters("Orc", 25, 10, 15 );
        Monsters monster2 = new Monsters("Goblin", 30, 15, 25);
        Monsters monster3 = new Monsters("Dragon", 35, 20, 35);

        monsters.Add(monster1);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monsters("Evill King",20,10,30)); //Add Instantly

        //Console.WriteLine
        //Show Hero Stats
        //Debug.Log($"Hero Name: {hero.Name} , Health: {hero.Health} , Gold: {hero.Gold}");
        hero.ShowStat();

        //Show Monster stats
        //Debug.Log($"Monster1: {monster1.Name} , Health: {monster1.Health}");
        //Debug.Log($"Monster2: {monster2.Name} , Health: {monster2.Health}");
        //Debug.Log($"Monster3: {monster3.Name} , Health: {monster3.Health}");

        foreach (var m in monsters)
        {
            //Debug.Log($"Monster3: {m.Name} , Health: {m.Health}");
            m.ShowStat();
        }

        hero.Name = "";
        hero.Health = 100;
        hero.Gold = 2000;


        //Hero is hit
        hero.TakeDamage(monster1.AttackPower);

        Debug.Log($"Hero Name: {hero.Name} , Health: {hero.Health} , Gold: {hero.Gold}");

        Debug.Log($"Hero is Alive : {hero.IsAlive()}");

        //Player Attack
        monster2.ShowStat();

        hero.Attack(monster2);

        monster2.ShowStat();

        //Monster Attack
        hero.ShowStat();

        monster2.Attack(hero);

        hero.ShowStat();*/




    }




}
