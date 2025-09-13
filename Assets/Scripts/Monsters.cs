using System.Xml.Linq;
using UnityEngine;

class Monsters
{

    //Attribute
    private string name;
    public string Name
    {
        get { return name; }
        set{ if (string.IsNullOrEmpty(value)) name = "Unknown Hero";
             else { name = value; }
        }
    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    private int attackPower;

    // { get; private set; } คือห้ามใครก็แล้วแต่มาเปลี่ยนค่าเด็ดขาด
    public int AttackPower { get; private set; } // { get; set; } เป็น Property เหมือนกัน แต่ความป้องกันจะต่ำ 

    private int lootReward;
    public int LootReward 
    {
        get { return lootReward; }
        set { if (value < 0) lootReward = 0;}
    }

    private bool monsterDefeated;

    //Constructor (For create object)
    public Monsters(string newName, int newHealth,int newAttackPower , int newLootReward)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackPower;
        LootReward = newLootReward;
        monsterDefeated = false;
    }
    
    public void ShowStat()
    {
        Debug.Log($"Monster3: {Name} , Health: {Health} , Attack Power: {AttackPower} , Loot Gold : {LootReward}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"Player Take {damageValue} Damage");
    }

    public void Attack(Hero target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public int DropReward()
    {
        return LootReward;
    }

}