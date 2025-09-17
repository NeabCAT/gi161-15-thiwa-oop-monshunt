using System.Xml.Linq;
using UnityEngine;

public class Monsters : Charactor
{

    private int lootGold;
    public int LootGold { get => lootGold ; set => lootGold = value; }

    private bool monsterDefeated;

    //Constructor (For create object)
    public void Init(string newName, int newHealth,int newAttackPower , int gold) //Same -Name- Different -Parameter- (Method Overloading)    
    {
        base.Init(newName, newHealth, newAttackPower);
        monsterDefeated = false;
        LootGold = gold;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"{Name} Loot Gold: {LootGold}");
    }

    public int DropReward()
    {
        return LootGold;
    }


}